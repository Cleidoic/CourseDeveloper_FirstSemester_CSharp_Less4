/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Ввод элеменетов через консоль 
(через запятую. использовать метод string.Split())
*/

// int GetNumber (string message) {
//     int result = 0;
//     bool isCorrect = false;
//     Console.WriteLine(message);
//     while (!isCorrect) {
//         isCorrect = int.TryParse(Console.ReadLine(), out result);
//         if(!isCorrect) {
//             Console.WriteLine($"Ввели не число или оно слишком большое. Введите корректное число \n");
//         }
//     }
//     return result;
// }

string GetElements(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine();
    return result;
}

string[] GetArray(string s)
{
    char[] separators = new char[] { ' ', ',', '.' };
    string[] array = s.Split(separators);
    return array;
}

void PrintArray(string[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}


PrintArray(GetArray(GetElements("Введите елементы массива через запятую и/или пробел: ")));
