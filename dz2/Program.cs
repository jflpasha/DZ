string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

if (num1Line != null && num2Line != null && num3Line != null)
{
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num2Line);
    
      
    if (num1 > num2 && num1>num3)
    {
        Console.WriteLine(num1);
    }
    
    if
        (num2 > num3)
        
    {
        Console.WriteLine(num2);
    }
    
    else
    {
        Console.WriteLine(num3);
    }   
      

}
