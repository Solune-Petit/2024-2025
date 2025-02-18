#include "LedControl.h"
#include <Keypad.h>

// jumper pin settings
#define DIN 2
#define CS 3
#define CLK 4
// this variable indicates the number of matrices, counting starts from zero
#define myMat 0
// initialization of LED matrix from library
LedControl ledMat = LedControl(DIN, CLK, CS, myMat);

//définition des nombres sous form de char
byte characters[10][8] = {
    { B01111110, B01111110, B01100110, B01100110, B01100110, B01100110, B01111110, B01111110 }, // char0
    { B00011000, B00111000, B01111000, B01011000, B00011000, B00011000, B01111110, B01111110 }, // char1
    { B00011100, B00111110, B01100110, B00001100, B00011000, B00110000, B01111110, B01111110 }, // char2
    { B00011100, B00111110, B00000110, B00111100, B00111110, B00000110, B00111110, B00111100 }, // char3
    { B00001100, B00011100, B00111100, B01101100, B11111111, B11111111, B00001100, B00001100 }, // char4
    { B01111110, B01111110, B01100000, B01111100, B01111100, B00000110, B01111110, B01111100 }, // char5
    { B00001100, B00011000, B00110000, B01111000, B01111100, B01100110, B01100110, B00111100 }, // char6
    { B11111111, B11111111, B00000110, B00001100, B00011000, B00110000, B01100000, B11000000 }, // char7
    { B00111100, B01111110, B01100110, B00111100, B00111100, B01100110, B01111110, B00111100 }, // char8
    { B01111110, B01111110, B01100110, B01111110, B01111110, B00000110, B01111110, B01111110 }  // char9
};

//définition des formes géométriques
byte stars[8] = {
  B11000011,
  B01100110,
  B00111100,
  B11111111,
  B11111111,
  B01100110,
  B11000011,
  B10000001
};

//definition of the keypad
//define the cymbols on the buttons of the keypads
char hexaKeys[4][4] = {
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}
};
byte rowPins[4] = {41, 42, 43, 44}; //connect to the row pinouts of the keypad (left to middle)
byte colPins[4] = {45, 46, 47, 48}; //connect to the column pinouts of the keypad (middle to right)
//initialize an instance of class NewKeypad
Keypad customKeypad = Keypad( makeKeymap(hexaKeys),  rowPins, colPins, 4, 4); 

void setup() {
  // wake up the matrix to start communication
  ledMat.shutdown(myMat, false);
  // setting the LED matrix to medium brightness (0-15)
  ledMat.setIntensity(myMat, 5);
  // switching off all LEDs on the matrix
  ledMat.clearDisplay(myMat);
  //call the build in LED
  pinMode(LED_BUILTIN, OUTPUT);
  // initialize serial communication at 9600 bits per second to the serial monitor
  Serial.begin(9600);
}

void loop() {
  
  //calling the keypad to know if it has been used
  char keypadBtn = customKeypad.getKey();

  // drawing all of the characters from the variable character


  // for (int number = 0; number < 10; number++){
  //   for (int i = 0; i < 8; i++){
  //     ledMat.setRow(myMat, i, characters[number][i]);
  //   }
  //   delay(1000);
  // }

  switch (keypadBtn)
  {
    case '*':
      for (int i = 0; i < 8; i++)
        {
          ledMat.setRow(myMat, i, stars[i]);
        }
      break;

    default: 
      if (keypadBtn != '\0')
      {
        int number = keypadBtn - 48;
        for (int i = 0; i < 8; i++)
        {
          ledMat.setRow(myMat, i, characters[number][i]);
        }

        //print out the value you read:
        Serial.println(number);
      }
    break;
  }
}
