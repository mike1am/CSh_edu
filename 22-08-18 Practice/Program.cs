/*
Console.Write("Please, enter first integer number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter second integer number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2) {
    Console.WriteLine("First number is a quad of second number");
}
else {
    Console.WriteLine("First number is not a quad of second number");
}
*/


Console.Write("Please, enter a possitive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = 10;

int i = num * (-1);

while (i <= num) {
    Console.Write(i + " ");
    i++;
}
/*
Console.Write("Please, enter a possitive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int lastDig = num % 10;

Console.Write($"The last digit is {lastDig}");
*/