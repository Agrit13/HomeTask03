//Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
}

double max = Math.Round(array.Max(), 2);
double min = Math.Round(array.Min(), 2);

Console.Write(string.Join(" ", array));
System.Console.Write($" => {max - min}");