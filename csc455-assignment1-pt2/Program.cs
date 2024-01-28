//  Assignment 1 - Program performs 4 different features based on the user's inpt.

//  Displays menu options
using System;
using System.Text.RegularExpressions;

Console.WriteLine("Choose a feature you'd like this program to run by entering a number between 1 and 4.");
Console.WriteLine("     1 - Random Positive Integer Between 1 And 10");
Console.WriteLine("     2 - Output Today's Date In Short Date String");
Console.WriteLine("     3 - Output A Random Dinosaur Name");
Console.WriteLine("     4 - Perform A Random Action On A String");

string userInput = Console.ReadLine();

//  If statements to contain features of the program
if(userInput == "1")
{
    //  Displays a random positive integer between 1 and 10
    Random randomNum = new Random();
    Console.WriteLine("Here is a random integer number between 1 and 10: {0}",randomNum.Next(1,10));
}else if(userInput == "2")
{

}else if(userInput == "3")
{

}else if(userInput == "4")
{

}
else
{
    Console.WriteLine("Input a valid integer number between 1 and 4.");
}