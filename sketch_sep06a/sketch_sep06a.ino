#include <ArduinoJson.h>
//#include <WiFi.h>
#include <ESP8266WiFi.h> 
#include <ESP8266HTTPClient.h>        // Thư viện HTTP Client version 0.4.0
#include <DNSServer.h>
#include <ESP8266WebServer.h>
const char* ssid = "ThanhHien";
const char* password = "1234qwer";
const String CityID = "1581130";             
const String key = "fd80d32667c943248c67243e7c393d6d";
WiFiClient client;
char* servername = "api.weatherbit.io";  // remote server we will connect to
String result;
int  iterations = 20;
void setup() {
  Serial.begin(115200);
  //WiFi.enableSTA(true);
  delay(2000);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
}

void loop() {
  delay(2000);
  if (iterations == 20)//We check for updated weather forecast once every hour
  {
    getWeatherData();
    iterations = 0;
  }
  iterations++;
}
void getWeatherData() //client function to send/receive GET request data.
{
  String result = "";
  WiFiClient client;
  const int httpPort = 80;
  if (!client.connect(servername, httpPort)) {
    return;
  }
  // We now create a URI for the request
  String url = "/v2.0/forecast/daily?city_id=" + CityID + "&days=5&key=" + key;
  // This will send the request to the server
  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
    "Host: " + servername + "\r\n" +
    "Connection: close\r\n\r\n");
  unsigned long timeout = millis();
  while (client.available() == 0) {
    if (millis() - timeout > 5000) {
      client.stop();
      return;
    }
  }

  // Read all the lines of the reply from server
  while (client.available()) {
    result = client.readStringUntil('\r');
  }
  Serial.print(result);
}
