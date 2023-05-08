// C++ code
//
#include <LiquidCrystal_I2C.h>

#include <Adafruit_LiquidCrystal.h>

#include <Servo.h>

int switch_1 = 0;

int switch_2 = 0;

int temp_input = 0;

int unnamed = 0;

int i = 0;

int j = 0;

int moisture_1 = 0;

int moisture_2 = 0;

int k = 0;

int light_input = 0;

int m = 0;

int n = 0;

LiquidCrystal_I2C lcd_2(32, 16, 2);

Adafruit_LiquidCrystal lcd_1(0);

Servo servo_3;

Servo servo_6;

void setup()
{
  pinMode(12, INPUT);
  pinMode(13, INPUT);
  lcd_2.init();
  lcd_1.begin(16, 2);
  Serial.begin(9600);
  servo_3.attach(3, 500, 2500);
  servo_6.attach(6, 500, 2500);
  pinMode(A1, INPUT);
  pinMode(A2, INPUT);
  pinMode(2, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(A0, INPUT);
  pinMode(A3, INPUT);
  pinMode(5, OUTPUT);
}

void loop()
{
  switch_1 = digitalRead(12);
  switch_2 = digitalRead(13);
  lcd_1.setCursor(0, 0);
  // Reading all the data
  Serial.println(switch_1);
  Serial.println(switch_2);
  servo_3.write(0);
  servo_6.write(0);
  if (switch_1 + switch_2 == 0) {
    lcd_1.noDisplay();
    // both dont work, the whole system should not work
  } else {
    while (switch_1 + switch_2 > 0) {
      lcd_1.display();
      // at least one works, system is up
      light_input = analogRead(A1);
      Serial.print("light: ");
      Serial.print(light_input);
      Serial.println("");
      temp_input = analogRead(A2);
      Serial.print("temp: ");
      Serial.print(temp_input);
      Serial.println(" ");
      if (temp_input <= 130) {
        digitalWrite(2, HIGH);
        digitalWrite(4, LOW);
        digitalWrite(7, LOW);
      } else {
        if (temp_input <= 170) {
          digitalWrite(4, HIGH);
          digitalWrite(2, LOW);
          digitalWrite(7, LOW);
        } else {
          digitalWrite(7, HIGH);
          digitalWrite(2, LOW);
          digitalWrite(4, LOW);
        }
      }
      if (light_input <= 230) {
        digitalWrite(10, HIGH);
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
      } else {
        if (light_input <= 550) {
          digitalWrite(9, HIGH);
          digitalWrite(8, LOW);
          digitalWrite(10, LOW);
        } else {
          digitalWrite(8, HIGH);
          digitalWrite(10, LOW);
          digitalWrite(9, LOW);
        }
      }
      if (switch_1 + switch_2 == 2) {
        // both work
        lcd_1.setCursor(0, 0);
        lcd_1.print("plant1: ");
        lcd_1.setCursor(0, 1);
        lcd_1.print("plant2: ");
        moisture_1 = analogRead(A0);
        moisture_2 = analogRead(A3);
        // 1 works
        moisture_1 = analogRead(A0);
        Serial.print("moist1: ");
        Serial.print(moisture_1);
        Serial.println("");
        delay(2000); // Wait for 2000 millisecond(s)
        if (moisture_1 <= 240) {
          servo_3.write(90);
          delay(2000); // Wait for 2000 millisecond(s)
          servo_3.write(0);
          delay(5000); // Wait for 5000 millisecond(s)
          lcd_1.setCursor(8, 0);
          lcd_1.print("        ");
          lcd_1.setCursor(8, 0);
          lcd_1.print("watered");
        } else {
          servo_3.write(0);
          if (moisture_1 >= 580) {
            digitalWrite(5, HIGH);
            lcd_1.setCursor(8, 0);
            lcd_1.print("        ");
            lcd_1.setCursor(8, 0);
            lcd_1.print("2muchH2O");
            delay(2000); // Wait for 2000 millisecond(s)
            digitalWrite(5, LOW);
            delay(2000); // Wait for 2000 millisecond(s)
          } else {
            lcd_1.setCursor(8, 0);
            lcd_1.print("        ");
            lcd_1.setCursor(8, 0);
            lcd_1.print("good");
            delay(2000); // Wait for 2000 millisecond(s)
          }
        }
        moisture_2 = analogRead(A3);
        Serial.print("moist2: ");
        Serial.print(moisture_2);
        Serial.println("");
        delay(2000); // Wait for 2000 millisecond(s)
        if (moisture_2 <= 240) {
          servo_6.write(90);
          delay(2000); // Wait for 2000 millisecond(s)
          servo_6.write(0);
          delay(5000); // Wait for 5000 millisecond(s)
          lcd_1.setCursor(8, 1);
          lcd_1.print("        ");
          lcd_1.setCursor(8, 1);
          lcd_1.print("watered");
        } else {
          servo_6.write(0);
          if (moisture_2 >= 580) {
            Serial.print("moist2: ");
            Serial.print(moisture_2);
            Serial.println("");
            digitalWrite(5, HIGH);
            lcd_1.setCursor(8, 1);
            lcd_1.print("        ");
            lcd_1.setCursor(8, 1);
            lcd_1.print("2muchH2O");
            delay(2000); // Wait for 2000 millisecond(s)
            digitalWrite(5, LOW);
            delay(2000); // Wait for 2000 millisecond(s)
          } else {
            lcd_1.setCursor(8, 1);
            lcd_1.print("        ");
            lcd_1.setCursor(8, 1);
            lcd_1.print("good");
            delay(2000); // Wait for 2000 millisecond(s)
          }
        }
      } else {
        if (switch_1 == 1) {
          // 1 works
          lcd_1.setCursor(0, 1);
          lcd_1.print("                ");
          lcd_1.setCursor(0, 0);
          lcd_1.print("plant1: ");
          moisture_1 = analogRead(A0);
          Serial.print("moist1: ");
          Serial.print(moisture_1);
          Serial.println("");
          delay(2000); // Wait for 2000 millisecond(s)
          if (moisture_1 <= 240) {
            servo_3.write(90);
            delay(2000); // Wait for 2000 millisecond(s)
            servo_3.write(0);
            delay(5000); // Wait for 5000 millisecond(s)
            lcd_1.setCursor(8, 0);
            lcd_1.print("        ");
            lcd_1.setCursor(8, 0);
            lcd_1.print("watered");
          } else {
            servo_3.write(0);
            if (moisture_1 >= 580) {
              digitalWrite(5, HIGH);
              lcd_1.setCursor(8, 0);
              lcd_1.print("        ");
              lcd_1.setCursor(8, 0);
              lcd_1.print("2muchH2O");
              delay(2000); // Wait for 2000 millisecond(s)
              digitalWrite(5, LOW);
              delay(2000); // Wait for 2000 millisecond(s)
            } else {
              lcd_1.setCursor(8, 0);
              lcd_1.print("        ");
              lcd_1.setCursor(8, 0);
              lcd_1.print("good");
              delay(2000); // Wait for 2000 millisecond(s)
            }
          }
        } else {
          // 2 works
          if (switch_2 == 1) {
            lcd_1.setCursor(0, 0);
            lcd_1.print("                ");
            lcd_1.setCursor(0, 1);
            lcd_1.print("plant2: ");
            moisture_2 = analogRead(A3);
            Serial.print("moist2: ");
            Serial.print(moisture_2);
            Serial.println("");
            delay(2000); // Wait for 2000 millisecond(s)
            if (moisture_2 <= 240) {
              servo_6.write(90);
              delay(2000); // Wait for 2000 millisecond(s)
              servo_6.write(0);
              delay(5000); // Wait for 5000 millisecond(s)
              lcd_1.setCursor(8, 1);
              lcd_1.print("        ");
              lcd_1.setCursor(8, 1);
              lcd_1.print("watered");
            } else {
              servo_6.write(0);
              if (moisture_2 >= 580) {
                Serial.print("moist2: ");
                Serial.print(moisture_2);
                Serial.println("");
                digitalWrite(5, HIGH);
                lcd_1.setCursor(8, 1);
                lcd_1.print("        ");
                lcd_1.setCursor(8, 1);
                lcd_1.print("2muchH2O");
                delay(2000); // Wait for 2000 millisecond(s)
                digitalWrite(5, LOW);
                delay(2000); // Wait for 2000 millisecond(s)
              } else {
                lcd_1.setCursor(8, 1);
                lcd_1.print("        ");
                lcd_1.setCursor(8, 1);
                lcd_1.print("good");
                delay(2000); // Wait for 2000 millisecond(s)
              }
            }
          } else {
            // 2 works
          }
        }
      }
      switch_1 = digitalRead(12);
      switch_2 = digitalRead(13);
    }
  }
}