///Lab 01b DGM 1400
///1/13/2024
///Sam Ford

///there are to prompts that go with this assignment.
///Both will be completed and then built upon at the challenge.

///Challenge prompt 1
///Create a program that asks the user to enter the current temperature in Celsius.
///Use an "if" statement to check if the temperature exceeds 30 degrees Celsius.
///If it is, display a message suggesting the user stay hydrated and avoid staying in the sun for too long. 
///If the temperature is below 30 degrees Celsius, display a message suggesting the user enjoys the pleasant weather.

///declairation of bool for while loop
bool goodTemp = false;

/// declairation of int because it wouldn't exist if only declaired in the try statement
int temperature = 0;

///while loop to keep asking for input untill a whole integer is given
while (goodTemp == false){

    ///write and read for input from user
    Console.WriteLine("Input temperature in degrees Celsius as a whole number:");
    string inputTemp = Console.ReadLine();

    ///try case to verify that input is acceptible and doesn't error out.
    ///a bad input will produce accpetion and repeats the while loop.
    try {
        temperature = Convert.ToInt32(inputTemp);
        goodTemp = true;
    } catch (Exception){
        Console.WriteLine("Input an acceptible temperature format");
    }
}

///start of if statements based on the input temperature
if (temperature > 30){
Console.WriteLine("Make sure to stay hydrated and avoid staying in the sun for too long. Shade is your friend!");
} else if (temperature < 30) {
    Console.WriteLine("Enjoy the pleasant weather!");
}

///Challenge 2: Exam Grader
///Extend your program to prompt users to enter their exam scores as percentages.
///Use an "if-else" statement to check the score and provide a corresponding grade.
///For example, if the score is between 90 and 100, display an "A" grade message.
///If the score is between 80 and 89, display a "B" grade message, and so on.
///Provide appropriate feedback for various score ranges.

///declairation of bool for while loop
bool goodGrade = false;

/// declairation of int because it wouldn't exist if only declaired in the try statement
int examGrade = 0;

///while loop to keep asking for input untill a whole integer is given
while (goodGrade == false){

    ///write and read for input from user
    Console.WriteLine("Input exam score as a whole number:");
    string inputGrade = Console.ReadLine();

    ///try case to verify that input is acceptible and doesn't error out.
    ///a bad input will produce accpetion and repeats the while loop.
    try {
        examGrade = Convert.ToInt32(inputGrade);
        goodGrade = true;
    } catch (Exception){
        Console.WriteLine("Input an acceptible grade format");
    }
}

///if statments to determine the letter grade
if (examGrade > 90){
    Console.WriteLine("You recieved an A");
} else if (examGrade <= 90 || examGrade > 80){
    Console.WriteLine("You recieved a B");
} else if (examGrade <= 80 || examGrade > 70){
    Console.WriteLine("You recieved a C");
} else if (examGrade <= 70 || examGrade > 60){
    Console.WriteLine("You recieved a D");
} else if (examGrade <= 60 ){
    Console.WriteLine("You recieved a F");
}