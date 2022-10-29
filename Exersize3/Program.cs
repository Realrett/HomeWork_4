// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
/*
Я честно не знаю как пользоваться сплитом, и как из строки через цикл перенести элементы в массив. 
Поэтому я взял программу из семинара, и немного дополнил.
*/

Random rnd = new Random();
Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(0, 100);

if(i < array.Length -1)
Console.Write($"{array[i]}, ");

else 
Console.WriteLine($"{array[i]}]");

}