#include <Keypad.h>


//definition of the keypad
/////////////////////////////////////////////////////////////////////////////////////////////////////////

const byte ROWS = 4; //four rows
const byte COLS = 4; //four columns
//define the cymbols on the buttons of the keypads
char hexaKeys[ROWS][COLS] = {
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}
};
byte rowPins[ROWS] = {5, 4, 3, 2}; //connect to the row pinouts of the keypad
byte colPins[COLS] = {9, 8, 7, 6}; //connect to the column pinouts of the keypad
//initialize an instance of class NewKeypad
Keypad customKeypad = Keypad( makeKeymap(hexaKeys), colPins, rowPins, ROWS, COLS); 

/////////////////////////////////////////////////////////////////////////////////////////////////////////



//definition of the LEDs
/////////////////////////////////////////////////////////////////////////////////////////////////////////

int LED00 = 33;
int LED01 = 32;
int LED02 = 31;
int LED03 = 30;
int LED10 = 43;
int LED11 = 42;
int LED12 = 41;
int LED13 = 40;


/////////////////////////////////////////////////////////////////////////////////////////////////////////

void setup(){
  pinMode(LED00, OUTPUT);
  pinMode(LED01, OUTPUT);
  pinMode(LED02, OUTPUT);
  pinMode(LED03, OUTPUT);
  pinMode(LED10, OUTPUT);
  pinMode(LED11, OUTPUT);
  pinMode(LED12, OUTPUT);
  pinMode(LED13, OUTPUT);
}
  
void loop(){
  
  char keypadBtn = customKeypad.getKey();

  switch(keypadBtn){

    case '1':
      digitalWrite(LED00,HIGH);
      digitalWrite(LED10,HIGH);
      delay(1000);
      digitalWrite(LED00,LOW);
      digitalWrite(LED10,LOW);
      break;

    case '2':
      digitalWrite(LED01,HIGH);
      digitalWrite(LED10,HIGH);
      delay(1000);
      digitalWrite(LED01,LOW);
      digitalWrite(LED10,LOW);
      break;

    case '3':
      digitalWrite(LED02,HIGH);
      digitalWrite(LED10,HIGH);
      delay(1000);
      digitalWrite(LED02,LOW);
      digitalWrite(LED10,LOW);
      break;
  }
  
}
