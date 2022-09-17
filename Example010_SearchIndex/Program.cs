// Найти индекс элемента массива, равный введенному числу - переменной find

/*Console.WriteLine("Введите элемент для поиска его индекса в массиве  ");
int find = int.Parse(Console.ReadLine());

int[] array = {1, 2, 3, 5, 7, 9, 15, 16, 16};

int n = array.Length;
int index = 0;

while (index < n)
{
    if (array[index] == find)
        {
        Console.WriteLine(index);
        break;
        }
    index++;
}
*/

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // обозначение, что в массиве 10 элементов - создай новый массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 400);
Console.WriteLine(pos);


