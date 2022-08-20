/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void NewRandomArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(-100, 100);
        Console.Write($"[{array[i]}] ");
    }
}


void MinMaxSub (int[] array)
{
    int min = 100;
    int max = -100;

    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"{max} is the maximal element of Your array");
    Console.WriteLine($"{min} is the minimal element of Your array");
    Console.WriteLine($"And their difference = {max - min}");
}


int[] arr = new int[15];
NewRandomArray(arr);
Console.WriteLine();
MinMaxSub(arr);


