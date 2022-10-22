// Requrst for input data
Console.WriteLine("Enter the first number");
string number_1 = Console.ReadLine() ?? "";
Console.WriteLine("Enter the second number");
string number_2 = Console.ReadLine() ?? "";
Console.WriteLine("Enter the third number");
string number_3 = Console.ReadLine() ?? "";

// Processing of input data

int a = int.Parse(number_1);
int b = int.Parse(number_2);
int c = int.Parse(number_3);

// Decision
int num_max = a;

if (b > num_max)
{
    num_max = b;
}
if (c > num_max)
{
    num_max = c;
}

Console.WriteLine("max=" + num_max);