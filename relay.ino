int value = 0;
int change = 0;
void setup() {
   Serial.begin(9600);
   pinMode(12, OUTPUT);
}

void loop() {
  
 while (Serial.available() == 0); 
    value = Serial.read() - '0'; 
    processChange(value);
}

void processChange(int amountChange){
    while(amountChange != change){
      digitalWrite(12, HIGH);
      delay(1000);
      change++;
      Serial.println(change); 
      }
    digitalWrite(12, LOW);
    change = 0;
}
