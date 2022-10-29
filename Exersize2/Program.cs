// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
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

int A = GetConsole("Введите число: ");
int B = A;
int sum = 0;
while (A > 0)
{
sum = sum + A % 10;
A = A /10 ;
}

Console.Write($"Сумма цифр числа {B} равна {sum}");