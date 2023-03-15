// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System;
Console.WriteLine("Hello, World!");

//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25



int numOne = Convert.ToInt32(Console.ReadLine());
int numTwo = Convert.ToInt32(Console.ReadLine());   
string resulOne = Console.ReadLine();
Console.WriteLine("The result is :" + resulOne);

if (resulOne == "+")
{
    Console.WriteLine(numOne + numTwo);
}
if (resulOne == "-")
{
    Console.WriteLine(numOne - numTwo);
}

if (resulOne == "*")
{
    Console.WriteLine(numOne * numTwo);
}

if (resulOne == "/")
{
    Console.WriteLine(numOne / numTwo);
}

//Task 2
//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

int inputOne = Convert.ToInt32(Console.ReadLine());
int inputTwo = Convert.ToInt32(Console.ReadLine());
int inputThree = Convert.ToInt32(Console.ReadLine());
int inputFour = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((inputOne + inputTwo + inputThree + inputFour) / 4);

