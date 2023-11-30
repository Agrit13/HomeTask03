// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int [] GenerateArray(int size, int leftRange, int rightRange)
{
    int [] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
}

int CountDivBy7(int[] array)
{
    int count = 0;
  foreach (int number in array) 
    if (number % 2 == 0) {
        count++;
    }
        return count;
}

int[] myArray = GenerateArray(10, 1, 100);
PrintArray(myArray);
int count = CountDivBy7(myArray);
Console.WriteLine($" => {count}");