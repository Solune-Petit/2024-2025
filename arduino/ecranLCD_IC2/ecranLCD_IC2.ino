#include <Adafruit_LiquidCrystal.h>

int seconds = 0;
bool versLaDroite = true;
float compteur;

Adafruit_LiquidCrystal lcd_1(0);

void setup()
{
  lcd_1.begin(16, 2);

  lcd_1.print("hello world");
}

void loop()
{
  lcd_1.setCursor(0, 1);
  lcd_1.print(seconds);
  lcd_1.setBacklight(1);
  delay(500); // Wait for 500 millisecond(s)
  lcd_1.setBacklight(0);
  delay(500); // Wait for 500 millisecond(s)
  seconds++;
  compteur++;
  
  if (versLaDroite)             // Si VersLaDroite vaut true alors..
  {
    lcd_1.scrollDisplayRight(); // on défile vers la droite
  } else                        // sinon si VersLaDroite vaut false..
  {
  lcd_1.scrollDisplayLeft();    // on défile vers la gauche
  };   

  if (int(compteur/5)==compteur/5)  // Si la valeur de compteur est un multiple de 5 
  {
    versLaDroite=!versLaDroite;     // Alors on inverse la valeur de VersLaDroite
  }
}