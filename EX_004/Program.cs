// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

void FillArray(int[] collection) //void метод, который ничего не возвращает
{
    int lenght = collection.Length; //Тело метода FillArray
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; //Тело метода PrintArray
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //Определение массива из 10 элементов

FillArray(array); // Вызов метода FillArray, который заполнил массив
array[4] = 4;
array[6] = 4;

PrintArray(array); //Вызов метожа PrintArray, который распечатал массив
Console.WriteLine();

int pos = Index0f(array, 444);
Console.WriteLine(pos);