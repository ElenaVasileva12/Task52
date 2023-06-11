//  Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//двумерный массив с случайным вводом (универсальный)
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j=0;j<matrix.GetLength(1); j++)    //или columns
        {
        matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//вывод массива на экран (универсальный)
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j=0;j<matrix.GetLength(1); j++)    //или columns
        {
            Console.Write($"{matrix[i, j], 3}");  //5 это чтобы разделять числа
        }
        Console.WriteLine();
    }
}

//средне арифметическое
double[] AverageColums(int[,] matrix)
{
    double[] averageColums=new double[matrix.GetLength(1)];
    double[] sum=new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)  
    {
        for (int i=0;i<matrix.GetLength(0); i++)    
        {
        sum[j]=sum[j]+matrix[i,j];  
        }
       averageColums[j]=Math.Round((sum[j]/matrix.GetLength(0)),1);
       
    }
    return averageColums;
}

//вывод на экран double (универсальный)
void PrintArrayDouble(double[] arr, string sep = ".")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
        else Console.Write ($"{arr[i]}");
    }
}


int[,] array2d=CreateMatrixRndInt(3,4,1,10);
PrintMatrix(array2d);
Console.WriteLine();
double[] average=AverageColums(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(average, ";");