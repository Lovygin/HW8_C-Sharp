//Create two-dimensional array.
//Sort the elements in each row in descending order/ - in descending order - в порядке убывания.
                                                   //- each - каждый.

using System;
using static System.Console;

/*for (int i = 0; i < array.GetLength(0); i++)
{
    Array.Sort(array, i * array.GetLength(1), array.GetLength(1), new Comparer<int>((a, b) => {
        return b.CompareTo(a);
    }));
}*/
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
int[,] SortRowsMyArray = SortRows(myArray);

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

int[,] SortRows(int[,] arr)
{
    int[] tempRow = new int[arr.GetLength(1)];
    int count1 = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempRow[j] = arr[i,j];
        }
        count1++;
        tempRow = tempRow.OrderByDescending(i => i).ToArray();//Сортировка в порядке убывания
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = tempRow[j];
            Write(arr[i,j] + "\t");
        } WriteLine(count1 + ".");
    }
    return arr;   
    
}