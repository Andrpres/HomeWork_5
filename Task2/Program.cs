/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


//Иинциализирует новый массив
int[] InitArray(int length){
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 20);
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

//Сумма элементов, стоящих на нечётных позициях
int Summ(int[] array){
    int indexSumm = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0){
        }
        else{
            indexSumm = indexSumm + array[i];
        }
    }
    return indexSumm;
}

int[]array = InitArray(5);
PrintArray(array);
int resultSumm = Summ(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {resultSumm}");