using System.Diagnostics;
using System.IO.Ports;
using System.Text;

namespace Adruino_Read
{
    public partial class Form1 : Form
    {
        private SerialPort port;
        String serialCmd = "";
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            var hexString = ConvertStringToHex(value, System.Text.Encoding.Unicode);

            if (hexString.Contains("0D000A00") || hexString.Contains("0A00") || hexString.Contains("3B00"))
            {
                hexString = hexString.Replace("0D00","");
                hexString = hexString.Replace("0A00", "");
                hexString = hexString.Replace("3B00", "");
                
                if (hexString != "")
                {
                    serialCmd += ConvertHexToString(hexString, System.Text.Encoding.Unicode);
                    text1.Text = serialCmd;
                    processCommand(serialCmd);
                }
                else
                {
                    if (text1.Text == "")
                    {
                        Debug.WriteLine("Blank line");
                        port.WriteLine("readData");
                    }
                    
                }
                
                serialCmd = "";
            }
            else
            {
                Debug.WriteLine("HEX Pass>" + hexString);
                serialCmd += value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            
            listPorts();
        }

        private void listPorts()
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            //Debug.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                
                comboBox1.Items.Add(port);
                //Debug.WriteLine(port);
            }
        }
        private void processCommand(String cmd)
        {
            string[] words = cmd.Split(' ');
            if(words[0]=="readData")
            {
                Debug.WriteLine("readData Command");
            }
        }

        public static string ConvertStringToHex(String input, System.Text.Encoding encoding)
        {
            Byte[] stringBytes = encoding.GetBytes(input);
            StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.AppendFormat("{0:X2}", b);
            }
            return sbBytes.ToString();
        }

        public static string ConvertHexToString(String hexInput, System.Text.Encoding encoding)
        {
            int numberChars = hexInput.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
            }
            return encoding.GetString(bytes);
        }

        private void SerialPortProgram()
        {
            try
            {
                port = new SerialPort(comboBox1.Text, 9600, Parity.None, 8, StopBits.One);
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                port.Open();
            } catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
            }
        }


        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AppendTextBox(port.ReadExisting());
        }

        private void read_Click(object sender, EventArgs e)
        {
            port.WriteLine("readData");
        }

        private void btn_led_off_Click(object sender, EventArgs e)
        {
            port.WriteLine("ledOff");
        }

        private void btn_led_on_Click(object sender, EventArgs e)
        {
            port.WriteLine("ledOn");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            SerialPortProgram();
        }
    }
}