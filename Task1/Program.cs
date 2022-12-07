/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//Иинциализирует новый массив
int[] InitArray(int length){
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }

    return array;
}

//Печатает массив на экран
void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Подсчитываем кол-во четных чисел в массиве
int Count(int[] array){
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0){
            counter++;
        }
    }
    return counter;
}

int[]array = InitArray(4);
PrintArray(array);
int resultCounter = Count(array);

Console.WriteLine($"Колличество четных чисел в массиве: {resultCounter}");