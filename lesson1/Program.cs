// Console.WriteLine("first code in c#");

Console.WriteLine("write first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("write second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("yes");
}
else Console.WriteLine("no");
