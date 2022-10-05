/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber ()
{
Console.WriteLine("Input trehznachnoe:");
string NumberStr = Console.ReadLine();
int number = int.Parse(NumberStr);
return number;
}

int num = GetNumber();

int seconddig = (num - 100 * (num / 100)) / 10;


Console.WriteLine (seconddig);

