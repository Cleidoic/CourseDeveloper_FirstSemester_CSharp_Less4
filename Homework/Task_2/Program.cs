/*
Задача 2: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    Console.WriteLine($"{message}");
    while(!isCorrect)
    {
        isCorrect = int.TryParse(Console.ReadLine(), out result);

        if(!isCorrect) {
            Console.WriteLine($"Ввели не число или оно слишком большое. Введите корректное число \n");
        }
    }

    return result;
}

int SumDigit(int num) {
    int result = 0;
    while (num > 0) {
        result = result + num % 10;
        num = num /10;
    }
    return result;
}

Console.WriteLine(SumDigit(GetNumber("Введите число: ")));