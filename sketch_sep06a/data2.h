const String CityID = "1581130";
const String key = "fd80d32667c943248c67243e7c393d6d";
char* servername = "api.weatherbit.io";
DynamicJsonDocument doc(3000);
void sendNextion(String labe, String msg) {
  String command = labe + ".txt=\"" + msg + "\"";
  Serial.print(command);
  Serial.write(0xff);
  Serial.write(0xff);
  Serial.write(0xff);
}
void getWeatherForecastData() 
{
  String result = "";
  WiFiClient client;
  const int httpPort = 80;
  if (!client.connect(servername, httpPort)) {
    return;
  }
  String url = "/v2.0/forecast/daily?city_id=" + CityID + "&days=4&key=" + key;
  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + servername + "\r\n" +
               "Connection: close\r\n\r\n");
  unsigned long timeout = millis();
  while (client.available() == 0) {
    if (millis() - timeout > 3000) {
      client.stop();
      return;
    }
  }
  while (client.available()) {
    result = client.readStringUntil('\r');
  }
  deserializeJson(doc, (char*)result.c_str());
  JsonArray r = doc["data"];
  for (int i = 0; i < 4; i++)
  {
    JsonObject data = r[i];
    String valid_date = data["valid_date"].as<String>();
    String wind_spd = data["wind_spd"].as<String>();
    String wind_cdir_full = data["wind_cdir_full"].as<String>();
    String low_temp = data["low_temp"].as<String>();
    String max_temp = data["max_temp"].as<String>();
    String temp = data["temp"].as<String>();
    String pop = data["pop"].as<String>();
    String pres = data["pres"].as<String>();
    String rh = data["rh"].as<String>();
    String uv = data["uv"].as<String>();
    String weather_icon = data["weather"]["icon"].as<String>();
    String weather_code = data["weather"]["code"].as<String>();
    String weather_description = data["weather"]["description"].as<String>();
    sendNextion("Date", valid_date);
    sendNextion("WindSpd", wind_spd);
    sendNextion("WindSpeFull", wind_cdir_full);
    sendNextion("LowTemp", low_temp);
    sendNextion("MaxTemp", max_temp);
    sendNextion("Temp", temp);
    sendNextion("Pop", pop);
    sendNextion("Pres", pres);
    sendNextion("Rh", rh);
    sendNextion("Uv", uv);
    sendNextion("Icon", weather_icon);
    sendNextion("Code", weather_code);
    sendNextion("Description", weather_description);
    Serial.println();
  }
}
