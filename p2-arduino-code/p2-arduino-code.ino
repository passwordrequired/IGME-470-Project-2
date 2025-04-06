int lclick = 7; //left click
int rclick = 8; //right click
int xmouse = A1; //mouse x position
int ymouse = A0; //mouse y position

int input; //holds value to send to C# program

void setup() {
  Serial.begin(9600); //start the serial communication
}

void loop() {
  input = digitalRead(lclick);
  Serial.println(input);
  delay(50); //to keep in sync with the C# program
  input = digitalRead(rclick);
  Serial.println(input);
  delay(50); //to keep in sync with the C# program
  input = analogRead(xmouse);
  Serial.println(input);
  delay(50); //to keep in sync with the C# program
  input = analogRead(ymouse);
  Serial.println(input);
  delay(50); //to keep in sync with the C# program

  delay(200); //adds a break to make values on vs console readable
}