// //Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

int[] array = new int[8];

void PrintArray(int[] array)
{
    int i = 0;
    while (i < 8)
    {
        Console.Write($"Введите элемент массива с индексом {i}:  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    Console.Write("[");
    foreach (int elem in array)
    {
        Console.Write("{0}", $"{elem}, ");//Так и не разобрался, как убрать последнюю запятую.
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

PrintArray(array);




