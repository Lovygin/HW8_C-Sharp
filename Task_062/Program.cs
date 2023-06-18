//Filling the two-dimensional array in a spiral/ заполнение по спирали.
//Array 4x4

using System;
using static System.Console;

Clear();
WriteLine("Please, enter number of rows");
int rows = int.Parse(ReadLine());
WriteLine("Please, enter number of columns");
int columns = int.Parse(ReadLine());
WriteLine();
WriteLine();
int[,] myArray = FillArraySpiral(rows,columns);
WriteLine();
WriteLine();

int[,] FillArraySpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int currentValue = 1;
    
    int row = 0;
    int col = 0;
    bool moveRight = true;
    bool moveDown = false;
    bool moveLeft = false;
    bool moveUp = false;

    while(currentValue <= rows * columns)
    {
        array[row, col] = currentValue;//Будет присваивание при выполнии любого из условий (ниже)
        currentValue++;

        if (moveRight)
        {
            if (col + 1 < columns && array[row, col + 1] == 0)//Проверка на предстоящую позицию столбца (col + 1) с неизменной позицией по строкам (row const)
                                                              //Выполняем присваивание до тех пор, пока выполняется условие.  
                                                              //т.е. каждый раз выходим из if(true) с новым значением col.
                                                              //новой позиции в массиве присваиваем следующее значение currentValue.
            {
                col++;
            }
            else//меняем напрвление движения
            {
                moveRight = false;
                moveDown = true;
                row++;//Спускаемся на строку ниже в той же позиции на столцах
            }
        }
        else if (moveDown)
        {
            if (row + 1 < rows && array[row + 1, col] == 0)//Проверка на предстоящую позицию строки (row + 1) с неизменной позицией по столбцу (col const)
            {
                row++;
            }
            else//дошли до нижнего края массива по последнему столбцу. Меняем направление движения.
            {
                moveDown = false;
                moveLeft = true;//идем влево по нижнему краю
                col--;
            }
        }
        else if (moveLeft)
        {
            if (col - 1 >= 0 && array[row, col - 1] == 0)
            {
                col--;
            }
            else//Дошли до 1-го столбца по последней строке. Меняем направление.
            {
                moveLeft = false;
                moveUp = true;
                row--;//Поднимаемся по строкам вверх. Присваиваем новое значение в нову. позицию массива.
            }
        }
        else if (moveUp)
        {
            if (row - 1 >= 0 && array[row - 1, col] == 0)//Доходим по левому краю до заполненной позиции [0,0]
            {
                row--;
            }
            else//меняем напрвление. Повторяем движение вправо до заполненного элемента [1,4]. и так далее
            {
                moveUp = false;
                moveRight = true;
                col++;
            }
        }
    }

    return array;
}
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Write(myArray[i,j] + "\t");
    }
    WriteLine();

}
