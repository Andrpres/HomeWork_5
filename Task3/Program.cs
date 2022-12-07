/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//Иинциализирует новый массив
int[] InitArray(int length){
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 100);
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

//Поиск максимального числа
int NumberMax(int[] array){
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max){
            max = array[i];
        }
    }
    return max;
}

//Поиск минимального числа
int NumberMin(int[] array, int maxNumber){
    int min = maxNumber;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min){
            min = array[i];
        }
    }
    return min;
}

int[]array = InitArray(5);
PrintArray(array);
int maxNumber = NumberMax(array);
int result = maxNumber - NumberMin(array, maxNumber);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");