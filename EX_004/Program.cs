// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

void FillArray(int[] collection) //void метод, который ничего не возвращает
{                                      //Тело метода FillArray
    int lenght = collection.Length; //Определение длинны массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); //Заполнение массива рандомными элементами от 0 до 10
        index++;
    }
}

void PrintArray(int[] col)
{                                   // Тело метода PrintArray
    int count = col.Length; //Определение длинны массива
    int position = 0; //position - это индекс для этого метода
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find) //int здесь метод, который возвращает позицию (индекс)
{                                      // Тело метода Index0f
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 задано для того, чтобы в случае отсутствия такого значения в массиве выводилось не 0, а -1. -1 значит, что элемент не найден

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;       // остановка цикла при первом выполнении условия
        }
        index++;
    }
    return position;   // возврат значения
}

int[] array = new int[10]; //Определение массива из 10 элементов

FillArray(array); // Вызов метода FillArray, который заполнил массив
array[4] = 4; //Искусственно добавили в рандомный массив элементы с заданным параметром (4)
array[6] = 4;

PrintArray(array); //Вызов метожа PrintArray, который распечатал массив
Console.WriteLine();

int pos = Index0f(array, 444); //Вызов метода вывода индекса позиции элемента массива с заданным параметром (4)
Console.WriteLine(pos);
