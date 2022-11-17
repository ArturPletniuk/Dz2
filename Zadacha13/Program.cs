//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
int value()
{
    Console.WriteLine("Введите число: ");
    int name = Convert.ToInt32(Console.ReadLine());
    if (name < 100 && name > -100)
    {
        return 1;
    }
    else
    {
        while (name > 999 || name < -999)
        {
            name /= 10;
        }

        if (name >= 100)
        {
            int c = name % 10;
            return c;
        }
        else
        {
            int c = name % -10;
            return c;
        }    
    }        
}
int y = value();
if (y != 1) Console.WriteLine(y);
else Console.WriteLine("Нет третьей цифры!");
Console.WriteLine();
Console.WriteLine("Exit.");
Console.ReadLine();
