// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetConsole (string message)
{
    int result;

    while(true) 
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out int number)) 
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число, повторите ввод \n");
        }
    }

    return result;
}
int A = GetConsole("Введите число А");
int B = GetConsole("Введите число В");

if (B >= 0)
{
    int result = Convert.ToInt32(Math.Pow(A, B));
    Console.WriteLine($"Число {A} в степени {B} равно: {result}");
}
else
{
    int result = Convert.ToInt32(Math.Pow(A, B*-1));
    Console.WriteLine($"Число {A} в степени {-B} равно: {result} ");
}