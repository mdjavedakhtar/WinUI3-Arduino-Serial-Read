namespace Adruino_Read
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text1 = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_led_off = new System.Windows.Forms.Button();
            this.btn_led_on = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(12, 52);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(237, 23);
            this.text1.TabIndex = 0;
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(93, 93);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 45);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Read Data";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.read_Click);
            // 
            // btn_led_off
            // 
            this.btn_led_off.Location = new System.Drawing.Point(12, 93);
            this.btn_led_off.Name = "btn_led_off";
            this.btn_led_off.Size = new System.Drawing.Size(75, 45);
            this.btn_led_off.TabIndex = 2;
            this.btn_led_off.Text = "LED Off";
            this.btn_led_off.UseVisualStyleBackColor = true;
            this.btn_led_off.Click += new System.EventHandler(this.btn_led_off_Click);
            // 
            // btn_led_on
            // 
            this.btn_led_on.Location = new System.Drawing.Point(174, 93);
            this.btn_led_on.Name = "btn_led_on";
            this.btn_led_on.Size = new System.Drawing.Size(75, 45);
            this.btn_led_on.TabIndex = 3;
            this.btn_led_on.Text = "Led On";
            this.btn_led_on.UseVisualStyleBackColor = true;
            this.btn_led_on.Click += new System.EventHandler(this.btn_led_on_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(174, 11);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 155);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_led_on);
            this.Controls.Add(this.btn_led_off);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Arduino Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text1;
        private Button btn_read;
        private Button btn_led_off;
        private Button btn_led_on;
        private ComboBox comboBox1;
        private Button btn_connect;
    }
}