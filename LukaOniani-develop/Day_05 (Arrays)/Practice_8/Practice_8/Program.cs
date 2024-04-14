int[][] jaggedMatrix = new int[8][];
string row;

Console.WriteLine("initial Jagged matrix: ");
for (int i = 0; i < 8; i++)
{
    row = "";
    for (int j = 0; j < 8; j++)
    {
        jaggedMatrix[i] = new int[8];
        if (j <= i)
        {
            jaggedMatrix[i][j] = 0;

        }
        else
        {
            jaggedMatrix[i][j] = 1;
        }
        row += jaggedMatrix[i][j] + " ";
    }
    
    Console.WriteLine(row);
}
Console.WriteLine();
Console.WriteLine("Changed Jagged matrix:");

int counter = 7;

for (int i = 0; i < 8; i++)
{
    row = "";
    for (int j = 0; j < 8 ; j++)
    {
        if(j <= counter)
        {
            jaggedMatrix[i][j] = 0;
        }
        else
        {
            jaggedMatrix[i][j] = 1;
        }
        row += jaggedMatrix[i][j] + " ";
    }
    Console.WriteLine(row);
    counter--;
}


int[,] matrix = new int[8, 8];

Console.WriteLine();
Console.WriteLine("Initial matrix:");
for (int i = 0; i < 8; i++)
{
    row = "";
    for (int j = 0; j < 8; j++)
    {
        if (j <= i)
        {
            matrix[i, j] = 0;
        }
        else
        {
            matrix[i, j] = 1;
        }
        row += matrix[i, j] + " ";
    }
    Console.WriteLine(row);
}
Console.WriteLine();
Console.WriteLine("Changed matrix:");

 counter = 7;

for (int i = 0; i < 8; i++)
{
    row = "";
    for (int j = 0; j < 8; j++)
    {
        if (j <= counter)
        {
            matrix[i, j] = 0;
        }
        else
        {
            matrix[i, j] = 1;
        }
        row += matrix[i, j] + " ";
    }
    Console.WriteLine(row);
    counter--;
}