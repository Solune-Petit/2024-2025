#include <Servo.h>

int position;
Servo monServo;

void setup() {
  monServo.attach(9); //liaison du servo avec le pin 9
  pinMode(A5, INPUT); //liaison de potentiomètre avec le le pin A5
}

void loop() {
  position = analogRead(A5); //récupération de l'info du potentiomètre
  position = map(position, 0, 1023, -180, 180); //conversion des valeurs du potentiomètre vers 0 <--> 180
  monServo.write(position); //aplication des valeurs converites au servo
  delay(100);
}