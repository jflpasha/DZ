Console.Write("Введи трёхзначное число: ");   //выводи текст

// Преобразуем в масив
int threeDigitNumber = Convert.ToInt32(Console.ReadLine()); 
string stringNumber = Convert.ToString(threeDigitNumber);
//выводим второе число масива
Console.WriteLine("вторая цифра этого числа --> "+stringNumber[1]);
