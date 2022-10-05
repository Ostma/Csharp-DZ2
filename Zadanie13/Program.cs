//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int GetNumber()
{
    Console.WriteLine("Input Chislo:");
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}

int num = GetNumber();

if (num < 100)
    Console.WriteLine("третьей цифры нет");
else
{
    string chr = num.ToString();
    Console.WriteLine(chr[2]);
}
//int dlina = char.Length;
//int  = (num - 100 * (num / 100)) / 10;