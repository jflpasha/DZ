// Считываем данные с консоли 
string? inputLine = Console.ReadLine();             

// проверяем, чтобы данные были не пустыми 
if(inputLine!=null)                                   
{
   // Изменяем введенную строку в целое число
    int inputNumber = int.Parse( inputLine);        
    // счетчик для начала цикла
    int seed = 2;                                  
    string outLine = string.Empty;

   // цикл до введенного числа+1
    while ( seed <= inputNumber-2)                   
    {
      // приписываем четные числа
       outLine = outLine + seed + ',';             
       seed = seed+2; 
    }
    outLine=outLine+seed;
    //outLine = outLine.TrimEnd(',');

    Console.WriteLine(outLine);
}
