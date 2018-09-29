# Coin acceptor
## Procedures:
```
Setting : N0 // very important dont use NC.
Connection:
Coin Acceptor
+ 5V
- GND
Counter

Microcontroller
- GND
PIN 2 (Interrupt Pin 0)
```

Reminder:
Always connect your GND to your arduino.



# Thermal Printer
## Procedures:
```
Connection:
USB to UART.
+ 5V 
- GND
TX

Thermal Printer WH-A73R90-31E825
+ 5V // first pin of the power pins.
- GND // third pin of the power pins.
RX // third to the last of the TLL panel.

```

Reminder:
Always remove jumper pins. 
User TLL communication for this.