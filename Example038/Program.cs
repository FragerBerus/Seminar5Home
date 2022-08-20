// Задача 38:
// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
float zero = 0;
float Difference = 0;
float[] ArrayNumbers = new float[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Введите элемент {i} массива из 10 элементов: ");
    string input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine($"ВЫ НИЧЕГО НЕ ВВЕЛИ!!! Значение {i} элемента массива, будет равно {zero}.");
    }
    else
    {
        ArrayNumbers[i] = Convert.ToSingle(input);
    }
}
float min = ArrayNumbers[0];
float max = ArrayNumbers[0];
for (int i = 0; i < 10; i++)
{
    if (min > ArrayNumbers[i])
    {
        min = ArrayNumbers[i];
    }
    else
    {
        if (max < ArrayNumbers[i])
        {
            max = ArrayNumbers[i];
        }
    }
}
Difference = max - min;
Console.WriteLine($"Во введенном массиве минимальный элемент {min}, максимальный {max}.");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Difference}.");