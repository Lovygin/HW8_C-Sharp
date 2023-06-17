//Created two-dimensional array.
//Find rows, then sum of all elements the smallest// - минимальная

using System;
using static System.Console;

Clear();
WriteLine("Please, enter number of rows");
int rows = int.Parse(ReadLine());
WriteLine("Please, enter number of columns");
int columns = int.Parse(ReadLine());
WriteLine();
WriteLine();
int[,] myArray = GetPrintArray(rows,columns);
WriteLine();
WriteLine();
int[] minSumRows = FindRowWithSmallestSum(myArray);

int[,] GetPrintArray(int rows, int columns)
{
    int[,] array = new int [rows,columns];
    int count = 1;
    for (int i = 0; i < rows; i++, count++)
    {   
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(100);
            Write(array[i,j] + "\t");

        } WriteLine(count + ".");
    }
    return array;
}

int[] FindRowWithSmallestSum(int[,] arr)
{
    int[] rowWithSmallestSum = new int[arr.GetLength(1)];
    int smallestSum = int.MaxValue;//Присваиваем максимальное значение int;
    int indexRowWIthMinSum = 0;//вернет первую строку в случае одинковых сум среди всех строк.
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumNumbersInRow = 0;//При смене строки пееременная с суммой обнуляется.
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumNumbersInRow += arr[i,j];
        }

        if(smallestSum > sumNumbersInRow) 
        {
            smallestSum = sumNumbersInRow; 
            indexRowWIthMinSum = i;
        }
    }
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       rowWithSmallestSum[j] = arr[indexRowWIthMinSum,j];//Перебираем строки только 1 раз. Гуд!
    }
    WriteLine("Row with smallest sum: ");
    for (int i = 0; i < rowWithSmallestSum.Length; i++)
    {
        Write(rowWithSmallestSum[i] + "\t");
    }
    WriteLine("Sum = " + smallestSum);
    WriteLine("Number of row with smallest sum: " + (indexRowWIthMinSum + 1) + ".");
    return rowWithSmallestSum;     
} 
