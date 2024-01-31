/// 1/27/24
/// Sam Ford
/// DGM 1400
/// Challenge 1
/// 
///This assignment seems wildly similar to the lab and the redundancy feels like it could be avoided if cs1400 was a prerequisite for this class.
///Any way This is late because I was tired and didn't want to do it at 11:30 at night


///Declaring variables
int number = 3;
string greeting = "hello every nyan";
bool coin = false;
string coinCall ="";

///Printing variables
Console.WriteLine(number + " variables will be printed. The 3 at the begining is the first");
Console.WriteLine(greeting);
Console.WriteLine(coin);

///variable manipulation
number += 1;
Console.WriteLine("The first number plus 1 is " + number);
number /= 2;
Console.WriteLine("The second number divided by 2 is " + number);
number *= 5;
Console.WriteLine("The third number times 5 is " + number);
number -= 10;
Console.WriteLine("The fourth number minus 10 is "+ number);

///heads or tails, house always wins haehe
///input
Console.WriteLine("heads or tails?");
coinCall = Console.ReadLine();
///logic
if (coinCall == "heads" || coinCall == "Heads")
{
    Console.WriteLine("Result is Tails, you lose");
}
if (coinCall == "tails" || coinCall == "Tails"){
    Console.WriteLine("Result is Tails, you lose");
}