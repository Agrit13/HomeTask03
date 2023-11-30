//  Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//  Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

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
    for(int number = 0; number < array.Length; number++)
        {
    if  (array[number] > 20 && array[number] < 90)
            {
        count++;
            }
        }
        return count;
}

int[] myArray = GenerateArray(10, 1, 100);
PrintArray(myArray);
int count = CountDivBy7(myArray);
Console.Write($" => {count}");