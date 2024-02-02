


using System.Net.NetworkInformation;

///Challenge 01b DGM 1400
///1/13/2024
///Sam Ford
///there are to prompts that go with this assignment.
///Code was taken from the lab, modified, and used in this challenge
///Challenge 1: Weather Adviser
///Enhance the "Temperature Adviser" program from the lab assignment.
///Modify the existing code to check for different temperature ranges.
///Provide more specific advice based on the conditions.
///Customize the messages based on the temperature conditions to provide detailed weather advice.
///For example, if the temperature is below 10 degrees Celsius, suggest wearing warm clothing.
///I recommend carrying a light jacket if the temperature is between 10 and 20 degrees Celsius.
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
if (temperature > 40){
    Console.WriteLine("Don't do any physical activity outside, Heat stroke is a threat at these temperatures. You can probably fry an egg on the hood of your car.");
} else if (temperature >= 30 || temperature < 40){
Console.WriteLine("Make sure to stay hydrated and avoid staying in the sun for too long. Shade is your friend! Water activities are recommended.");
} else if (temperature >= 20 || temperature < 30) {
    Console.WriteLine("Enjoy the pleasant weather! Bring a windbreaker, just in case.");
} else if (temperature >= 10 || temperature < 20) {
    Console.WriteLine("Make sure to bring a jacket. It might be a little chilly");
} else if (temperature >= 0 || temperature < 10){
    Console.WriteLine("Bring a warm, wind resistant jacket. Perfect weather for hot chocolate.");
} else if (temperature >= -20 || temperature > 0){
    Console.WriteLine("It'll snow at these temperatures. Bring a coat, gloves, and hat. The roads might be slick due to ice so drive carefully.");
} else if (temperature < -20) {
    Console.WriteLine("It is COLD. Warm coat, snow pants, mittens, boots, and a ski mask are required for outside activites. Do not get wet if you will be outside while still wearing the wet clothing.");
}

///Challenge 2: Subject Selector
///Expand the "Exam Grader" program from the lab assignment.
///In addition to displaying the grade based on the exam score, prompt the user to enter their favorite subject.
///Use a switch statement to display a message related to their chosen topic.
///For example, if the issue is "Math," show a message encouraging them to keep practicing and exploring mathematical concepts.
///Customize the messages for different subjects and make it fun and encouraging.

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

///switch statement for favoirte subject

Console.WriteLine("Input your favoirte subject in school in lowercase:");
string favInput = Console.ReadLine();
switch (favInput)
{
    case "math":
        Console.WriteLine("Take learning math slowly. Master every concept before moving to the next and nothing will stop you.");
        break;
    case "science":
        Console.WriteLine("Being good at math will help but Learn how to problem solve. Many science problems can be solved by observation and the right train of thought");
        break;
    case "art":
        Console.WriteLine("Remember to work on your fundimentals. Style and fun is important but getting really good requires the trained eye and hand.");
        break;
    case "english":
        Console.WriteLine("Don't be afraid to bend the rules in your writing. Lanugage is fluid and beautiful, keeping it in a box limits its potential");
        break;
    case "history":
        Console.WriteLine("Memorizing names and dates is good but the reason we have history is to learn from it. Try to find lessons to learn from in the stories of those who came before us.");
        break;
    case "physical education":
        Console.WriteLine("Work on your study habits. So much knowledge is required if you have a career in physical education. Have fun getting Ripped!");
        break;
}