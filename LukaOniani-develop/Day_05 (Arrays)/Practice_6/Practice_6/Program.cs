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

Console.WriteLine("Here is matrix view of multidimensional array:");

for (int i = 0;i < row; i++)
{
    string showRow = "";
    for(int j = 0;j < column; j++)
    {
        showRow += matrix[i, j] + ", ";
    }
    Console.WriteLine(showRow);
}