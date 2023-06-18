//Created three-dimensional array.
//



using System;
using static System.Console;

Clear();
WriteLine("Please, enter number of list");
int list = int.Parse(ReadLine());
WriteLine("Please, enter number of axis y");
int rows = int.Parse(ReadLine());
WriteLine("Please, enter number of axis x");
int columns = int.Parse(ReadLine());

WriteLine();
WriteLine();

int[,,] myArray = GetPrintArray(list,rows,columns);


int[,,] GetPrintArray(int list, int rows, int columns)
{
    int[,,] array = new int [list, rows, columns];
    for (int l = 0; l < list; l++)
    {   
        WriteLine("list" + l);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[l,i,j] = new Random().Next(100);
                Write(array[l,i,j] + "(" + l +", " + i +", " + j + ")" + "\t");
            }
            WriteLine();
        
        }

    }
    return array;
}