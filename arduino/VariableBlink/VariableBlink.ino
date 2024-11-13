//variable blink

int led = 8;
int duree;

void setup() {
  // initialize digital pin led as an output.
  pinMode(led, OUTPUT);
  pinMode(A5, INPUT);
}

// the loop function runs over and over again forever
void loop() {
  duree = analogRead(A5);
  duree = map(duree, 0, 1023, 100, 1000);
  digitalWrite(led, HIGH);  // turn the LED on (HIGH is the voltage level)
  delay(duree);                      // wait for a second
  digitalWrite(led, LOW);   // turn the LED off by making the voltage LOW
  delay(duree);                      // wait for a second
}
