#include <ArduinoJson.h>
//#include <WiFi.h>
#include <ESP8266WiFi.h> 
#include <ESP8266HTTPClient.h>      
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
  const size_t capacity = JSON_ARRAY_SIZE(5) + 5*JSON_OBJECT_SIZE(3) + JSON_OBJECT_SIZE(7) + 5*JSON_OBJECT_SIZE(38) + 720;
DynamicJsonDocument doc(capacity);

const char* json = "{\"data\":[{\"moonrise_ts\":1599486599,\"wind_cdir\":\"W\",\"rh\":83,\"pres\":1003.51,\"high_temp\":29.4,\"sunset_ts\":1599477006,\"ozone\":273.217,\"moon_phase\":0.794248,\"wind_gust_spd\":6.10123,\"snow_depth\":0,\"clouds\":100,\"ts\":1599411660,\"sunrise_ts\":1599432330,\"app_min_temp\":27.6,\"wind_spd\":2.46698,\"pop\":65,\"wind_cdir_full\":\"west\",\"slp\":1005.19,\"moon_phase_lunation\":0.65,\"valid_date\":\"2020-09-07\",\"app_max_temp\":35.4,\"vis\":23.0474,\"dewpt\":24.8,\"snow\":0,\"uv\":3.35868,\"weather\":{\"icon\":\"r01d\",\"code\":500,\"description\":\"Light rain\"},\"wind_dir\":264,\"max_dhi\":null,\"clouds_hi\":100,\"precip\":6,\"low_temp\":25.6,\"max_temp\":29.4,\"moonset_ts\":1599446403,\"datetime\":\"2020-09-07\",\"temp\":27.8,\"min_temp\":26.6,\"clouds_mid\":68,\"clouds_low\":6},{\"moonrise_ts\":1599575095,\"wind_cdir\":\"SW\",\"rh\":85,\"pres\":1006.66,\"high_temp\":30.3,\"sunset_ts\":1599563352,\"ozone\":275.033,\"moon_phase\":0.710582,\"wind_gust_spd\":6.72157,\"snow_depth\":0,\"clouds\":97,\"ts\":1599498060,\"sunrise_ts\":1599518742,\"app_min_temp\":26.5,\"wind_spd\":1.97794,\"pop\":65,\"wind_cdir_full\":\"southwest\",\"slp\":1008.46,\"moon_phase_lunation\":0.68,\"valid_date\":\"2020-09-08\",\"app_max_temp\":36,\"vis\":21.8563,\"dewpt\":24.2,\"snow\":0,\"uv\":3.34704,\"weather\":{\"icon\":\"r01d\",\"code\":500,\"description\":\"Light rain\"},\"wind_dir\":235,\"max_dhi\":null,\"clouds_hi\":76,\"precip\":6.125,\"low_temp\":25.5,\"max_temp\":30.4,\"moonset_ts\":1599535785,\"datetime\":\"2020-09-08\",\"temp\":27,\"min_temp\":25.5,\"clouds_mid\":88,\"clouds_low\":18},{\"moonrise_ts\":1599663738,\"wind_cdir\":\"ESE\",\"rh\":81,\"pres\":1005.73,\"high_temp\":31.4,\"sunset_ts\":1599649698,\"ozone\":264.274,\"moon_phase\":0.618012,\"wind_gust_spd\":7.81222,\"snow_depth\":0,\"clouds\":99,\"ts\":1599584460,\"sunrise_ts\":1599605155,\"app_min_temp\":26.5,\"wind_spd\":2.49343,\"pop\":70,\"wind_cdir_full\":\"east-southeast\",\"slp\":1007.44,\"moon_phase_lunation\":0.71,\"valid_date\":\"2020-09-09\",\"app_max_temp\":38.2,\"vis\":23.5781,\"dewpt\":24.1,\"snow\":0,\"uv\":3.34635,\"weather\":{\"icon\":\"t02d\",\"code\":201,\"description\":\"Thunderstorm with rain\"},\"wind_dir\":113,\"max_dhi\":null,\"clouds_hi\":58,\"precip\":7.3125,\"low_temp\":24.9,\"max_temp\":32.2,\"moonset_ts\":1599625263,\"datetime\":\"2020-09-09\",\"temp\":27.7,\"min_temp\":25.4,\"clouds_mid\":69,\"clouds_low\":23},{\"moonrise_ts\":1599752590,\"wind_cdir\":\"S\",\"rh\":82,\"pres\":1001.88,\"high_temp\":32.4,\"sunset_ts\":1599736044,\"ozone\":260.782,\"moon_phase\":0.51901,\"wind_gust_spd\":8.31462,\"snow_depth\":0,\"clouds\":98,\"ts\":1599670860,\"sunrise_ts\":1599691567,\"app_min_temp\":25.9,\"wind_spd\":2.25251,\"pop\":85,\"wind_cdir_full\":\"south\",\"slp\":1003.67,\"moon_phase_lunation\":0.75,\"valid_date\":\"2020-09-10\",\"app_max_temp\":39.7,\"vis\":22.1081,\"dewpt\":24.6,\"snow\":0,\"uv\":3.3338,\"weather\":{\"icon\":\"t03d\",\"code\":202,\"description\":\"Thunderstorm with heavy rain\"},\"wind_dir\":178,\"max_dhi\":null,\"clouds_hi\":94,\"precip\":17.25,\"low_temp\":25.7,\"max_temp\":32.7,\"moonset_ts\":1599714846,\"datetime\":\"2020-09-10\",\"temp\":28.1,\"min_temp\":24.9,\"clouds_mid\":48,\"clouds_low\":19},{\"moonrise_ts\":1599841704,\"wind_cdir\":\"ESE\",\"rh\":83,\"pres\":1002.3,\"high_temp\":32,\"sunset_ts\":1599822389,\"ozone\":261.579,\"moon_phase\":0.416481,\"wind_gust_spd\":7.71154,\"snow_depth\":0,\"clouds\":100,\"ts\":1599757260,\"sunrise_ts\":1599777980,\"app_min_temp\":26.7,\"wind_spd\":2.00653,\"pop\":85,\"wind_cdir_full\":\"east-southeast\",\"slp\":1004.16,\"moon_phase_lunation\":0.78,\"valid_date\":\"2020-09-11\",\"app_max_temp\":39.4,\"vis\":21.4135,\"dewpt\":24.8,\"snow\":0,\"uv\":3.32052,\"weather\":{\"icon\":\"t03d\",\"code\":202,\"description\":\"Thunderstorm with heavy rain\"},\"wind_dir\":107,\"max_dhi\":null,\"clouds_hi\":100,\"precip\":20.8125,\"low_temp\":25.8,\"max_temp\":32.4,\"moonset_ts\":1599804515,\"datetime\":\"2020-09-11\",\"temp\":28,\"min_temp\":25.6,\"clouds_mid\":74,\"clouds_low\":3}],\"city_name\":\"Hanoi\",\"lon\":\"105.84117\",\"timezone\":\"Asia/Ho_Chi_Minh\",\"lat\":\"21.0245\",\"country_code\":\"VN\",\"state_code\":\"44\"}";

deserializeJson(doc, json);

JsonArray data = doc["data"];
int i = 1
for (int i = 0; i < 5; i++)
{
  
}

}
