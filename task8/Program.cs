Console.WriteLine("Введите число"); 
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine("Четные числа:"); 
for (int index = 2; index <= number; index = index + 2)
{
    Console.WriteLine(index);
}

