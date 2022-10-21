// Блок запроса входных данных
Console.WriteLine("Enter the first number");
string number1 = Console.ReadLine() ?? "";
Console.WriteLine("Enter the second number");
string number2 = Console.ReadLine() ?? "";

// Блок подготовительный (перевод строки в числао
int a = int.Parse(number1);
int b = int.Parse(number2);

// Блок операции (условие-сравнение двух чисел)
if (a > b)
{
    Console.WriteLine("max=" + a);
}
else
{
    Console.WriteLine("max=" + b);
}
