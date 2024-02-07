///2/7/24
///DGM 1400
///Lab 01 C
///Sam Ford

///Not much to comment.
///Hit run. It shouldn't error. Nested loops are cool I guess
///Only problem I had was with the first loop. 
///I needed a <= rather than a < to have it print the number of rows that was input instead of one less

///Challenge: Number Pyramid
///Create a program that prints a number pyramid pattern using nested loops and conditional statements. 
///The program should prompt the user to enter a positive integer representing the number of rows in the pyramid. 
///Each row should contain numbers in ascending order, starting from 1 and incrementing by 1. 
///Use nested loops to achieve the pattern.

///declair variables
int rowNum = 0;
bool goodInput = false;

///make sure the input is acceptable
while (goodInput == false){

    ///get input from user *if outside while loop, program will loop forever. Had to end it will task manager.
    Console.WriteLine("Input number of rows for the pyramid as a positive intager");
    string rowInput = Console.ReadLine();

    ///try so no ugly crashes
    try {
        rowNum = Convert.ToInt32(rowInput);
    } catch (Exception){
        Console.WriteLine("Please input a positive intager");
    }
    ///check that it is positive
    if (rowNum < 1){
        Console.WriteLine("Please input a positive Intager");
    } else {
        goodInput = true;
    }
}
///nested for loop

///first loop counts row on
for (int rowCount = 0; rowCount <= rowNum; rowCount++){
    ///second loop prints the row number the number of times that the row is
    for (int numCount = 0; numCount < rowCount; numCount++){
        Console.WriteLine(rowCount);
    }
}