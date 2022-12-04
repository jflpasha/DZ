// Считываем данные с консоли 
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

// проверяем, чтобы данные были не пустыми 
if (num1Line != null && num2Line != null)
{
    // Изменяем введенную строку в целое число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
// Сравниваем числа
    if (num1 > num2)
    {
        Console.WriteLine("Первое число MAX!"); //Вывод результата
        Console.WriteLine("Вротое число MIN!");
    }
    else
    {
        Console.WriteLine("Второе число MAX!");// Вывод результата
        Console.WriteLine("Первое число MIN!");
        
    }
    
}
