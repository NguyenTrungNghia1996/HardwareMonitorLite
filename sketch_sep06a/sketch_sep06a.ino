#include <time.h>
#include <ArduinoJson.h>
#include <WiFi.h>
//#include <ESP8266WiFi.h>
//#include <ESP8266HTTPClient.h>
#include <DNSServer.h>
//#include <ESP8266WebServer.h>
#include <Ticker.h>
#include "data.h"
#include "data2.h"
Ticker flip;
const char* ssid = "ThanhHien";
const char* password = "1234qwer";
WiFiClient client;
unsigned long time1 = 0;
unsigned long time2 = 0;
void setup() {
  Serial.begin(115200);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  configTime(7 * 3600, 0, "pool.ntp.org", "time.nist.gov");
  while (nam.toInt() < 2000) {                                // Chờ cập nhật thời gian xong
    capNhatThoiGian();                                        // Cập nhật thời gian
    delay(50);
  }
  flip.attach(1, ngat);
  getWeatherForecastData();
}
void loop() {
  if ( (unsigned long) (millis() - time1) > 20000 )
  {
    getWeatherForecastData();
    time1 = millis();
  }
  if ( (unsigned long) (millis() - time2) > 1000 )
  {
    String st = ngayTrongTuan + "/" + ngay + "/" + thang + "/" + String(nam);
    String sp = String(hour) + "/" + String(minute) + "/" + String(sec);
    Serial.println(st);
    Serial.println(sp);
    time2 = millis();
  }

}
