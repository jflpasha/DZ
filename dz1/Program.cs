string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

if (num1Line != null && num2Line != null)
{
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
   
    if (num1 > num2)
    {
        Console.WriteLine("Первое число MAX!");
        Console.WriteLine("Вротое число MIN!");
    }
    else
    {
        Console.WriteLine("Второе число MAX!");
        Console.WriteLine("Первое число MIN!");
        
    }
    
}
