/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

// скопировала свой же код из задачи 34))

int[] arr = new int [15];
Random rand = new Random();
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100,1000);
    Console.Write($"{arr[i]}, ");

    if (arr[i] % 2 != 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine();
Console.WriteLine($"The sum of elements on odd positions = {sum}");