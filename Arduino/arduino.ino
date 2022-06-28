#include <DHT.h>
#include <DHT_U.h>

#include "DHT.h"

#define DHTPIN 2
#define DHTTYPE DHT11

DHT dht (DHTPIN, DHTTYPE);
int pHSense = A2;
int samples = 10;
float adc_resolution = 1024.0;


void setup() {
  Serial.begin(9600);
  dht.begin();

}
float ph (float voltage) {
    return 7 + ((2.5 - voltage) / 0.18);
}

void loop() {
    int measurings=0;
  for (int i = 0; i < samples; i++)
    {
        measurings += analogRead(pHSense);
        delay(10);

    }

  float voltage = 5 / adc_resolution * measurings/samples;;
  float level = analogRead(A0);
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  Serial.println(String(h) + "," + String(t) +"," + String(level) + "," + String(ph(voltage)));
  delay(3600000);
  //3600000
}
