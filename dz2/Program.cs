// Считываем данные с консоли 
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

// проверяем, чтобы данные были не пустыми 
if (num1Line != null && num2Line != null && num3Line != null)
{
// Изменяем введенную строку в целое число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num2Line);
    
      
    if (num1 > num2 && num1>num3)               // Сравниваем 1 число с 2м и 3м
    {
        Console.WriteLine(num1);                // Вывод числа
    }
    
    if
        (num2 > num3)                           //Сравниваем 2е и 3е число
        
    {
        Console.WriteLine(num2);                // Вывод числа
    }
    
    else
    {
        Console.WriteLine(num3);                // Вывод числа
    }   
      

}
