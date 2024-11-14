long duree, distance;

void setup() {
  pinMode(4, INPUT);
  pinMode(2, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(4, LOW);
  delayMicroseconds(2);
  digitalWrite(4, HIGH);
  delayMicroseconds(2);
  digitalWrite(4, LOW);
  
  duree = pulseIn(2, HIGH);
  distance = duree*340/(2*10000);

  Serial.print("La distance est : ");
  Serial.print(distance);
  Serial.println(" cm");
  delay(1000);
}