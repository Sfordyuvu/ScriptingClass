///2/9/23
///DGM1400
///Challenge 1C
///Sam Ford

///nothing of note to comment really.
///You can input anything for the favorite foods which can be funny i guess.

///Challenge 1: Number Guesser
///Ceate a game where the program generates a random number between 1 and 10.
///Prompt the user to guess the number. 
///Use a loop to give the user multiple chances to guess. 
///Provide feedback after each guess, indicating if the guess is too high or too low. 
///When the user assumes the correct number, display a congratulatory message and the number of attempts made.

///"enable" random
using System;
/// this appeared on its own. not sure what it does
using System.Runtime.InteropServices;

///declair variables
bool win = false;
bool goodInput = false;
string guessInput = "";
int guessNum = 0;
int luckyNum = 0;
int guessCount = 1;

///make the number that is guessed to win
Random RNG = new Random();
luckyNum = RNG.Next(1,10);

///while loop to keep the game running
while (win == false){

    ///while to check that it is proper input
    while (goodInput == false){

        ///get user input
        Console.WriteLine("Guess a number between 1 and 10");
        guessInput = Console.ReadLine();

        ///try to convert input to int
        try {
            guessNum = Convert.ToInt32(guessInput);

            ///check if guess is between 1 and 10
            if (guessNum >= 1 && guessNum <= 10){
                goodInput = true;
            } else {
                Console.WriteLine("invalid input");
            }
        } catch (Exception) {
            Console.WriteLine("invalid input");
        }
    }
        ///determines if user wins or if the guess was to high or low
        ///adds 1 to guess count if to high or low. exits while loop if guess is correct.
        if (guessNum == luckyNum){
            win = true;
        } else if (guessNum < luckyNum){
            Console.WriteLine("too low");
            guessCount++;
            goodInput = false;
        } else if (guessNum > luckyNum){
            Console.WriteLine("too high");
            guessCount++;
            goodInput = false;
        }
}
///win and guess count message
Console.WriteLine("Correct! The number is " + luckyNum + ". You guessed it in " + guessCount + " guesses.");

///Challenge 2: Favorite Food
///Create a program that prompts the user to enter their three favorite foods.
///Use an array to store these food items.
///Display each item on a new line with a message, such as "I love [food item]!".
///Use a loop to iterate through the array and print the messages.

///declare array
string[] foodInput = {"", "", ""};

///gather inputs
for (int x = 1; x < 4; x++){
    Console.WriteLine("please input your number "+ x + " favorite food:");
    foodInput[x-1] = Console.ReadLine();
}

///iterate through array and print message
for (int length = 0; length < foodInput.Length; length++){
    Console.WriteLine(foodInput[length] + " is yummy");
}