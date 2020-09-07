void setup() {
   Serial.begin(115200);
  Serial.println("ESP8266 in normal mode");
}

void loop() {
  getVoltage();
  delay(1000);
}
void getVoltage(){
    int nVoltageRaw = analogRead(A0);
    float fVoltage = (float)nVoltageRaw * 0.242;  
  Serial.print("A0 "); Serial.println(nVoltageRaw);
  Serial.print("Voltage "); Serial.println(fVoltage);
}
