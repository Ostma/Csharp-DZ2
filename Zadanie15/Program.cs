//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
//6 -> да
//7 -> да
//1 -> нет

int GetNumber()
{
    Console.WriteLine("Input den':");
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}

int num = GetNumber();

if (num == 6 || num == 7)
    Console.WriteLine("да");
else

    Console.WriteLine("нет");