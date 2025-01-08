//ON INCLUT ICI LA LIBRAIRIES QUI VA PERMETTRE D'UTILISER LES SERVO MOTEURS
#include <Servo.h>              //Inclue la librairie dans ce programme pour qu'on puisse utiliser ses mots-clés

int pos = 0;                    //On déclare la variable pos comme un entier. Cette variable servira pour la boucle FOR
Servo MonServo;                 //On déclare MonServo comme étant un Servo 

void setup()
{
  MonServo.attach(22); //On indique ici que le servo MonServo est relié au Pin 9
}

void loop()
{
  for (pos = 0; pos <= 180; pos += 1) {     // crée une boucle qui va aller de pos=0 jusqu'à pos=180 en augmentant pos de 1 à chaque tour
  MonServo.write(pos);                      //indique au servo de se rendre à la position pos (qui vaut 1, puis 2, puis 3 etc..jusqu'à 180)
  // delay(10);                                //on attend 15 millisecondes
  }
  delay(1000);
  for (pos = 180; pos >= 0; pos -= 1) {     // crée une boucle qui va aller de pos=180 jusqu'à pos=0 en diminuant pos de 1 à chaque tour
  MonServo.write(pos);                      //indique au servo de se rendre à la position pos (qui vaut 180, puis 179, puis 178 etc..jusqu'à 0)
  delay(1000);                                //on attend 15 millisecondes
  }
}

//faire en sorte de compter le nombre de fois que ça fait une boucle et puis afficher sur un écran LCD