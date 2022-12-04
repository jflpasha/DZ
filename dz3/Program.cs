// Считываем данные с консоли 
string? num1Line = Console.ReadLine();

// проверяем, чтобы данные были не пустыми 
if (num1Line != null)
{
// Изменяем введенную строку в целое число
    int num1 = int.Parse(num1Line);
       
    if (num1 % 2 == 0)                      //находим целочисленный остаток
    {
        Console.WriteLine("Число Четное!!!");   // Вывод результата
        
    }
    else
    {
        Console.WriteLine("Число Не Четное!!!");  // Вывод результата
        
        
    }
    
}