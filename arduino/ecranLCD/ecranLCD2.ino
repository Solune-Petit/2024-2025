#include <LiquidCrystal.h>                //appel bibli LiquidCrystal
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);    //déclaration de la variable lcd de type afficheur branché aux pins indiqués
int I;

void setup()
{
  I=3;
  lcd.begin(16,2);
}

void loop()
{
  lcd.clear();
  I=3;
  while(I>0)
  {
    lcd.setCursor(0,1);
    lcd.print(I);
    delay(1000);
    I--;
  }

  lcd.setCursor(0,1);
  lcd.print("partez :-)");
  
  for (int i = 0; i < 4; i++)
  {
    lcd.noDisplay();
    delay(500);
    lcd.display();
    delay(500);
  }
}