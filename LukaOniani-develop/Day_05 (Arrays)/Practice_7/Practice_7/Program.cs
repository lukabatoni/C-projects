Console.Write("Enter array row size: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array column size: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[row, column];
int[,] matrix2 = new int[row, column];
int sum = 0;

Console.WriteLine("Fill first matrix");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write("Enter number for index " + i + "," + j + ": ");
        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Fill second matrix");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write("Enter number for index " + i + "," + j + ": ");
        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Here is sum of two matrixes:");

for (int i = 0; i < row; i++)
{
    string showRow = "";
    for (int j = 0; j < column; j++)
    {
        sum = matrix1[i, j] + matrix2[i, j];  
        showRow += sum + ", ";
    }
    Console.WriteLine(showRow);
}