#include <Stepper.h>  // Inclut la bibliothèque Stepper

const int NbreDePasPourUnTour = 64;  // Déclare une constante
                                     // Angle de 5,625 (données techniques) ce qui fait 64 pas pour un tour + rapport de 1/32.
                                     // Donc 32 x 64=2048 pas par tour

Stepper myStepper(NbreDePasPourUnTour, 3, 5, 4, 2);  // Déclare un Stepper
                                                     // INT1 sur D2,INT2 sur D3,INT3 sur D4,INT4 sur D5 ATTENTION ce n'est pas dans l'ordre "logique" (D3,D5,D4,D2) au lieu de (D2,D3,D4,D5)

int NbreDePas = 0;  // Déclare une variable de type entier

void setup() {
  myStepper.setSpeed(700);  // Règle la vitesse à 10 tours/minute
  Serial.begin(9600);       //initialise le moniteur à 9600 bauds
  myStepper.version();
}

void loop() {
  while (Serial.available() > 0) {  // Tant que des données arrivent sur le moniteur
    NbreDePas = Serial.parseInt();  // Je lis les données et j'en extrait les valeurs entières
    if (NbreDePas != 0) {           // Si je trouve un entier différent de 0
      Serial.println(NbreDePas);    // J'affiche cet entier sur le moniteur
      myStepper.step(-NbreDePas);   // Recule de NbreDePas (sens anti-horaire)
      delay(500);                   // J'attends une demi-seconde
      myStepper.step(NbreDePas);    // Avance de NbreDePas (sens horaire)
      delay(500);
    }
  }
}
