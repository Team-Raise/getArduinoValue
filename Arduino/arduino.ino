#include "DHT.h"

#define DHTPIN 2
#define DHTTYPE DHT11

DHT dht (DHTPIN, DHTTYPE);


void setup() {
  Serial.begin(9600);
  dht.begin();

}

void loop() {
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  float hic = dht.computeHeatIndex(t,h, false);

  Serial.println(String(h) + "," + String(t) +"," + String(hic));
  delay(10000);
  //3600000
}
