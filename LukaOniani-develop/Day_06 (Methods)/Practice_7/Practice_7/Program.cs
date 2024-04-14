using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix1 = CreateArr();
        int[,] matrix2 = CreateArr();
        int[,] sumMatrix = AddMatrixes(matrix1, matrix2);
        PrintMatrix(sumMatrix);
    }


    static int[,] CreateArr()
    {
        Console.Write("Enter array row size: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter array column size: ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("Enter number for index " + i + "," + j + ": ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return matrix;
    }

    static int[,] AddMatrixes(int[,] matrix1, int[,] matrix2)
    {
        int row = matrix1.GetLength(0);
        int column = matrix1.GetLength(1);
        int[,] newMatrix = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return newMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            string showRow = "";
            for (int j = 0; j < column; j++)
            {
                showRow += matrix[i, j] + ", ";
            }
            Console.WriteLine(showRow);
        }
    }
}
