int lclick = 4; //left click
int rclick = 8; //right click
int xmouse = A1; //mouse x position
int ymouse = A0; //mouse y position

int input; //holds value to send to C# program

void setup() {
  Serial.begin(9600); //start the serial communication
}

void loop() {

  Serial.println("9999");
  Serial.flush(); //makes sure the start of the cycle is aligned with the vs program

  input = digitalRead(lclick);
  Serial.println(input);
  Serial.flush();  //wait until the vs program has received the data

  input = digitalRead(rclick);
  Serial.println(input);
  Serial.flush();  //wait until the vs program has received the data

  input = analogRead(xmouse);
  Serial.println(input);
  Serial.flush();  //wait until the vs program has received the data

  input = analogRead(ymouse);
  Serial.println(input);
  Serial.flush();  //wait until the vs program has received the data
}