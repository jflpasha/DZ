string? num1Line = Console.ReadLine();

if (num1Line != null)
{
    int num1 = int.Parse(num1Line);
       
    if (num1 % 2 == 0)
    {
        Console.WriteLine("Число Четное!!!");
        
    }
    else
    {
        Console.WriteLine("Число Не Четное!!!");
        
        
    }
    
}