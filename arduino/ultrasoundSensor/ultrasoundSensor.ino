long duree, distance;

void setup() {
  pinMode(4, OUTPUT);
  pinMode(2, INPUT);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(4, LOW);
  delayMicroseconds(1);
  digitalWrite(4, HIGH);
  delayMicroseconds(1);
  digitalWrite(4, LOW);
  
  duree = pulseIn(2, HIGH);
  distance = duree*340/(2*10000);

  Serial.print("La distance est : ");
  Serial.print(distance);
  Serial.println(" cm");
  delay(1);
}