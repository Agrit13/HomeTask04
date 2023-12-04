// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

using System.Dynamic;

int ReadInt(string text)
    {
        System.Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

int[] GenerateArray(int size, int leftRange, int rightRange)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
    }

void PrintArray(int[] array)
    {
        System.Console.Write($"[{string.Join(", ", array)}]");
    }


int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 0, 100);
PrintArray(myArray);
    for (int i = 0; i < (myArray.Length / 2); i++) {
(myArray[i], myArray[myArray.Length-(i+1)]) = (myArray[myArray.Length-(i+1)], myArray[i]);
    }
    System.Console.Write(" =>");
PrintArray(myArray);
