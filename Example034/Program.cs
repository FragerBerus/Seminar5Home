// Задача 34:
// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
int Number = 0;
int[] ArrayNumbers = new int[900];
for (int i = 0; i < 900; i++)
{
    ArrayNumbers[i] = new Random().Next(100, 999);
}
for (int i = 0; i < 900; i++)
{
    if (ArrayNumbers[i] % 2 == 0)
    {
        Number = Number + 1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве составляет {Number}.");