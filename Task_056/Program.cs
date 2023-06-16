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
int[] minSumRows = FindSmallestRow(myArray);

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

/*int[] FindSmallestRow(int[,] arr)
{
    int[] smallestRow = new int[arr.GetLength(1)];
    int sum = 0; int minIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            smallestRow[j] = arr[i,j];
        }
        int smallestRow = smallestRow.Sum();//sum of all elements in array.
        if(sum < smallestRow) sum = smallestRow; minIndex = i;
    }
    return smallestRow[minIndex];  
    
}*/ 
