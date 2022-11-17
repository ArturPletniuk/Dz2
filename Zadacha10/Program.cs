//Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает вторую цифру этого числа. Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).
int ned()
{ 
    Console.WriteLine("Введите число: ");
    int name = Convert.ToInt32(Console.ReadLine());
    if (name > 0)
    {
        int x = name / 10;
        int c = x % 10;
        if (x < 10 || x > 100)
        {
            return 1;
        }
        else
        {
            x = name / 10;
            c = x % 10;
            return c;
        }
    }
    else
    {
        int x = name / 10;
        int c = x % 10;
        if (x > -10 || x < -100)
        {
            return 1;
        }
        else
        {
            x = name / 10;
            c = x % -10;
            return c;
        }
    } 
}
int y = ned();
if (y != 1) Console.WriteLine(y);
else Console.WriteLine("Вы ввели не правильное число");
Console.WriteLine();
Console.WriteLine("Exit.");
Console.ReadLine();
