/*
Задача 70: Напишите программу, которая на вход принимает два числа 
и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

void SumOfNumbers(int number1, int number2, int count)
{
    Console.Write($"{number1} ");
    if (count - 1 > 0)
    {
        SumOfNumbers(number2, number1 + number2, --count);
    }
}

SumOfNumbers(3, 4, 5);
Console.WriteLine();
SumOfNumbers(6, 10, 4);

