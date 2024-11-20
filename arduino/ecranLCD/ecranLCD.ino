#include <LiquidCrystal.h>                //appel bibli LiquidCrystal
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);    //déclaration de la variable lcd de type afficheur branché aux pins indiqués
String message = "coucou";

void setup() {
  lcd.begin(16, 2);                       //initialise l'afficher comme étant à 16 caractères sur 2 lignes

}

void loop() {
  lcd.setCursor(0,0);                     //positionnement du curseur en ligne 0 collone 0
  lcd.print(message);                     //affichage de la variable message
  delay(1000);
  lcd.clear();                            //vidage de l'écran
  delay(1000);
}
