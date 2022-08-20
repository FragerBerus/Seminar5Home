// Задача 36:
// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
int Sum = 0;
int[] ArrayNumbers = new int[100];
for (int i = 0; i < 100; i++)
{
    ArrayNumbers[i] = new Random().Next(0, 99);
}
int index = 1;
while (index < 100)
{
    Sum = Sum + ArrayNumbers[index];
    index = index + 2;
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, равна {Sum}.");