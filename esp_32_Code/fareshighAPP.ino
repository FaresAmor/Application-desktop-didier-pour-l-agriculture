#include <FirebaseESP32.h>
#include <WiFi.h>
#include <DHT.h>
#define WIFI_SSID "Galaxy32"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://tempapp-593c8-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "N0mhfRGO9ZEzhBpmV7uXDJ7sREkX1RiA9z6KIu7E"
WiFiClient client;
FirebaseData firebaseData;
int gaz = 33;
int V = 0;
int r=5;
int g =18;
int b=19;
int bot =23;
#define DHTPIN 4 
#define DHTTYPE DHT11 

DHT dht(DHTPIN, DHTTYPE);
void setup() {
Serial.begin(9600);
dht.begin();
pinMode(r,OUTPUT);
pinMode(g,OUTPUT);
pinMode(b,OUTPUT);
pinMode(gaz,INPUT);
pinMode(bot,INPUT);
// Connect to Wi-Fi
WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
while (WiFi.status() != WL_CONNECTED) {
delay(1000);
Serial.println("Connecting to WiFi...");
}
Serial.println("Connected to WiFi");
// Connect to Firebase
Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
Serial.println("Connected to Firebase");
}
void loop() {
delay(1000); // Attendez 2 secondes entre chaque lecture.
float temperature = dht.readTemperature();
float humidity = dht.readHumidity();
int gazv=digitalRead(gaz);
int botv=digitalRead(bot);
if (isnan(temperature) || isnan(humidity)) {
Serial.println("Erreur lors de la lecture des données du DHT11");
} else {
Serial.print("Température : ");
Serial.print(temperature);
Serial.println(" °C");
Serial.print("Humidité : ");
Serial.println(humidity);
Serial.print("gaz : ");
Serial.println(gazv);
Serial.println(" %");
Firebase.setFloat(firebaseData, "/sensors/temp", temperature);
Firebase.setFloat(firebaseData, "/sensors/hum", humidity);
Firebase.setInt(firebaseData, "/sensors/gaz", gazv);
Firebase.setInt(firebaseData, "/sensors/bot", botv);
}
Firebase.getInt(firebaseData, "/V");
int V = firebaseData.intData();
Firebase.getInt(firebaseData, "/a");
int a = firebaseData.intData();

   if(V==0){
        analogWrite(r,0);
    analogWrite(g,0);
    analogWrite(b,0);
    
  }
   if(a==0 && V==1){
    analogWrite(r,255);
    analogWrite(g,0);
    analogWrite(b,0);
    
  }
   else if(a==1 && V==1){
    analogWrite(r,0);
    analogWrite(g,255);
    analogWrite(b,0);
    
  }
     else if(a==2 && V==1){
    analogWrite(r,0);
    analogWrite(g,0);
    analogWrite(b,255);
    
  }
     else if(a==3 && V==1){
    analogWrite(r,255);
    analogWrite(g,255);
    analogWrite(b,0);
    
  }
     else if(a==4  && V==1){
    analogWrite(r,255);
    analogWrite(g,255);
    analogWrite(b,255);
    
  }
     else if(a==5 && V==1){
    analogWrite(r,66);
    analogWrite(g,4);
    analogWrite(b,17);
    
  }
     else if(a==6 && V==1){
    analogWrite(r,239);
    analogWrite(g,125);
    analogWrite(b,244);
    
  }
     else if(a==7 && V==1){
    analogWrite(r,85);
    analogWrite(g,10);
    analogWrite(b,131);
    
  }
     else if(a==8 && V==1){
    analogWrite(r,174);
    analogWrite(g,168);
    analogWrite(b,177);
    
  }
     else if( a==9 && V==1){
    analogWrite(r,238);
    analogWrite(g,84);
    analogWrite(b,60);
    
  }



}