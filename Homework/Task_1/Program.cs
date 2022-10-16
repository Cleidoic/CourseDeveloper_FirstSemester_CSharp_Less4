/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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


int Pow (int num, int count) {
    int result = num;
    for (int i = 1; i < count; i++)
    {
        result = result * num;
    }
    return result;
}

Console.WriteLine(Pow(GetNumber("Введите число, которое необходимо возвести в степень: "), GetNumber("Введите степень, в которую необходимо возвести число: ")));



