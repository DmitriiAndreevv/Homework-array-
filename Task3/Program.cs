/*Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево

[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо*/

Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = FillArray(size, 1, 10);

Console.Write("Входной массив: ");
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.Write("сдвиг влево :   ");
Console.Write("[");
Console.Write(String.Join(", ", LeftArray(array))); 
Console.Write("]");

Console.WriteLine();
Console.Write("сдвиг вправо :  ");
Console.Write("[");
Console.Write(String.Join(", ", RightArray(array))); 
Console.Write("]");


int [] FillArray(int size, int min, int max){
    int [] result = new int[size];
         
    for(int i = 0; i < result.Length;i++)
    {
         result[i] = new Random().Next(min, max + 1);    
    }
    return result;
}

int[] LeftArray(int [] array)
{
    int[] leftNumbers = new int[array.Length];
    int last = array[0];
    for (int i = 1; i <= array.Length - 1; i++)
    {
        leftNumbers[i - 1] = array[i];
    }
 
    leftNumbers[leftNumbers.Length - 1] = last;
    return leftNumbers;
}

int [] RightArray(int [] array)
{
    int [] rightNumbers = new int[array.Length];
    int first = array[array.Length - 1];

    for (int j = array.Length - 1;j > 0; j--)
    {
       
        array[j] = array[j - 1];
    }
    array[0] = first;

    rightNumbers[rightNumbers.Length - 1] = first;
    return array;
}