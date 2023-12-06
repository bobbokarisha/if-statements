// See https://aka.ms/new-console-template for more information



using System.ComponentModel.Design;

bool isMale = true;
bool isTall = false;

if (isMale && isTall)
{
    Console.WriteLine("You are a tall male");
} else if (isMale && !isTall) {
    Console.WriteLine("You are a short male");
} else if (!isMale && isTall) {
    Console.WriteLine("You are not a male but you are tall");
} else
{
    Console.WriteLine("You are not male and not tall");
}

Console.ReadLine();