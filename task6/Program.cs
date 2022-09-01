Console.WriteLine("Введите первое число");
string input = Console.ReadLine();
int number = int.Parse(input);
if (number%2 == 0)
{
Console.WriteLine($"Число {number} - четное");
}
else 
{
    Console.WriteLine($"Число {number} - не четное");
}