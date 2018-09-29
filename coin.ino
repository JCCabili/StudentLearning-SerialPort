const int coinInt = 0;
//Attach coinInt to Interrupt Pin 0 (Digital Pin 2). Pin 3 = Interrpt Pin 1.

volatile int coinsValue = 0;
//Set the coinsValue to a Volatile float
//Volatile as this variable changes any time the Interrupt is triggered

void setup()
{
  Serial.begin(9600);
//Start Serial Communication
  attachInterrupt(coinInt, coinInserted, FALLING);
//If coinInt goes HIGH (a Pulse), call the coinInserted function
//An attachInterrupt will always trigger, even if your using delays
  pinMode(13, OUTPUT);
}

void coinInserted()
//The function that is called every time it recieves a pulse
{
  coinsValue = coinsValue + 1;
   Serial.println('1');
}

void loop()
{

}
