//Вывод текста
Console.Write("Введи число: ");
//преобразование в массив
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
//В преобразованном массиве смотрим что бы он был больше 2х 
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);  // Выводим 2е число массива
}
else {
  Console.WriteLine("-> третьей цифры нет");   
}
