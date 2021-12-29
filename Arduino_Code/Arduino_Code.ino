#include "CommandLine.h"

int ledPin = 13;
int inp0 = 0;
int inp1 = 0;
int inp2 = 0;
int inp3 = 0;
int inp4 = 0;

void setup() {
  // declare the ledPin as an OUTPUT:
  pinMode(ledPin, OUTPUT);
  digitalWrite(ledPin, HIGH);
  Serial.begin(9600);
}

void loop() {
  bool received = getCommandLineFromSerialPort(CommandLine);      //global CommandLine is defined in CommandLine.h
  if (received)
  {
    //Serial.println(CommandLine);
    processSerialData((String)CommandLine);
  }
}



String getValue(String data, char separator, int index)
{
  int found = 0;
  int strIndex[] = {0, -1};
  int maxIndex = data.length() - 1;

  for (int i = 0; i <= maxIndex && found <= index; i++) {
    if (data.charAt(i) == separator || i == maxIndex) {
      found++;
      strIndex[0] = strIndex[1] + 1;
      strIndex[1] = (i == maxIndex) ? i + 1 : i;
    }
  }

  return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void processSerialData(String message)
{
  if (getValue(message, ' ', 0) == "readData")
  {
    inp0 = analogRead(A0);
    inp1 = analogRead(A1);
    inp2 = analogRead(A2);
    inp3 = analogRead(A3);
    inp4 = analogRead(A4);
    Serial.println("readData "+String(inp0) + " " + String(inp1) + " " + String(inp2) + " " + String(inp3) + " " + String(inp4) + ";");
  }
  if (getValue(message, ' ', 0) == "ledOn")
  {
    digitalWrite(ledPin, HIGH);
  }
  if (getValue(message, ' ', 0) == "ledOff")
  {
    digitalWrite(ledPin, LOW);
  }
}
