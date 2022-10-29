int goled = 9; //Traffic light Led’s and pins
int readyled = 11;
int stopled = 8;

void setup(){
pinMode(goled, OUTPUT); //Pinmodes of the leds
pinMode(readyled, OUTPUT);
pinMode(stopled, OUTPUT);

}
void loop(){
digitalWrite(goled, HIGH); //Green on for 7 seconds

delay(7000);
// flash the ped green
for (int x=0; x<8; x++) {
digitalWrite(goled, HIGH);
delay(250);
digitalWrite(goled, LOW);
delay(250);
}
digitalWrite(goled, LOW); //Green off,

digitalWrite(stopled, HIGH); // red on

delay(7000);
// flash the green

digitalWrite(stopled, LOW);//red off,yellow on,ped red on,
digitalWrite(readyled, HIGH);

delay(3000);
digitalWrite(readyled, LOW);//yellow off,pedgreen off

}