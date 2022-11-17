//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
string value()
{
    Console.WriteLine("Введите число: ");
    int name = Convert.ToInt32(Console.ReadLine());
    while (name <= 0 || name > 7)
    {
        Console.WriteLine("Надо ввести число от 1 до 7!!!");
        Console.WriteLine("Введите число:");
        name = Convert.ToInt32(Console.ReadLine());
    }
    if (name != 7 && name != 6) return "Нет";
    else return "Да";
}
string s = value();
Console.WriteLine(s);
Console.Write("Exit.");
Console.ReadLine();
