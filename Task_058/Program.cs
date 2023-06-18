
using System;
using static System.Console;

Clear();
WriteLine("Please, enter numbers of rows and columns for 1st and 2nd arrays");
WriteLine("Condition: The number of columns in the first array must be equal to the number of rows in the second array");
//mast be equal - должно быть равно
WriteLine();
WriteLine("Please, enter number of rows for 1st array");
int rows1 = int.Parse(ReadLine());
WriteLine("Please, enter number of columns for 1st array");
int columns1 = int.Parse(ReadLine());

WriteLine("Please, enter number of rows for 2nd array");
int rows2 = int.Parse(ReadLine());
WriteLine("Please, enter number of columns for 2nd array");
int columns2 = int.Parse(ReadLine());
WriteLine();
WriteLine();
int[,] firstArray = GetPrintArray(rows1,columns1);
WriteLine();
int[,] secondArray = GetPrintArray(rows2,columns2);
WriteLine();
WriteLine();
int[,] multiplyArrays = MultiplyMatrices(firstArray, secondArray);


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

int[,] MultiplyMatrices(int[,] arrA, int[,] arrB)
{
    if(arrA.GetLength(1) != arrB.GetLength(0))
    {
        throw new ArgumentException("Input condition not met");// not met - не выполнено (условие ввода)
        WriteLine("Condition: The number of columns in the first array must be equal to the number of rows in the second array");
    }
    int[,] result = new int[arrA.GetLength(0), arrB.GetLength(1)];
    int count = 1; 

    for (int i = 0; i < arrA.GetLength(0); i++, count++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrA.GetLength(1); k++)
            {
                result[i,j] += arrA[i,k] * arrB[k,j];
                
            }
            Write(result[i,j] + "\t");
        }
        WriteLine(count + ".");

    }
    return result;
}