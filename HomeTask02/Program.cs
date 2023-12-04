// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

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

    int CountDivBy7(int[] array){
    int count = 0;
    for (int number =0; number < array.Length; number++){
        if (array[number] % 2 == 0)
        {
            count++;
        }
    }
            return count;
}

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 100, 1000);
PrintArray(myArray);
int count = CountDivBy7(myArray);
System.Console.Write($" => {count}");