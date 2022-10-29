int goled = 9; //Traffic light Led’s and pins
int readyled = 11;
int stopled = 8;
int bawaltumawid = 6;
int pwedetumawid = 7;


void setup(){
pinMode(goled, OUTPUT); //Pinmodes of the leds
pinMode(readyled, OUTPUT);
pinMode(stopled, OUTPUT);
pinMode(bawaltumawid, OUTPUT);
pinMode(pwedetumawid, OUTPUT);
}
void loop(){
digitalWrite(goled, HIGH); //Green on for 7 seconds
digitalWrite(bawaltumawid, HIGH); //Pedestrian RedLed on
delay(110000);
// flash the ped green
for (int x=0; x<8; x++) {
digitalWrite(goled, HIGH);
delay(250);
digitalWrite(goled, LOW);
delay(250);
}
digitalWrite(goled, LOW); //Green off,

digitalWrite(readyled, HIGH); // readyled on

delay(10000);
// flash the green

digitalWrite(readyled, LOW);//readyled off,stopled on
digitalWrite(stopled, HIGH);
digitalWrite(bawaltumawid, LOW);  //Pedestrian RedLed off
digitalWrite(pwedetumawid, HIGH); //Pedestrian GreenLed on
delay(90000);

for (int x=0; x<8; x++) { //flash the pedestrian green led
digitalWrite(pwedetumawid, HIGH);
delay(250);
digitalWrite(pwedetumawid, LOW);
delay(250);
}
digitalWrite(pwedetumawid, LOW);//Pedestrian GreenLed off
digitalWrite(stopled, LOW);//stopled off

}