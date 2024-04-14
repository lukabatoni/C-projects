////TASK1
//void ShowPairs(int number, int[] array)
//{
//    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//    {
//        if (array[i] + array[j] == number)
//        {
//            Console.Write(array[i] + " ");
//            Console.WriteLine(array[j]);
//        }
//    }
//}

//int[] arr = { 1, 2, 4, 7, 9 };
//ShowPairs(6, arr);
//Console.ReadKey();

//TASK 2
//int FindElement(int[] arr)
//{
//    int size = arr.Length;
//    int sumArr = 0;
//    int sumReal = 1;
//    for (int i = 2; i <= size + 1; i++)
//    {
//        sumArr += arr[i - 2];
//        sumReal += i;
//    }
//    return sumReal - sumArr;
//}

//int[] arr = { 4, 1, 3, 5 };
//Console.WriteLine(FindElement(arr));
//Console.ReadKey();


//TASK 3 version 1
//string Con(int number)
//{
//    string res = "";
//    string final = "";
//    while (number >= 1)
//    {
//        int rem = number % 2;
//        res += rem;
//        number = number / 2;
//    }

//    char[] arr = res.ToCharArray();
//    for (int i = arr.Length-1; i >= 0; i--)
//    {
//        final += arr[i];
//    }
//    return final;
//}
//Console.WriteLine(Con(8));
//Console.ReadKey();


//Console.WriteLine(res);
//}

//IntoBin(8);




//void WorkOnFile()
//{
//    string input = "";
//    Console.WriteLine("To turn off program type \"exit\" otherwise enter the directory path");
//    Console.WriteLine("Enter directory: ");
//    input = Console.ReadLine();

//    if (input == "exit")
//        return;
//    if (Directory.Exists(input) == false)
//    {
//        Console.WriteLine("The directory " + input + "does not exist!");
//    }

//    Console.WriteLine(Directory.GetFiles(input));
//    WorkOnFile(input);

//}


int counter = 1;
void WorkOnFile(string input)
{

    Console.WriteLine("To turn off program type \"exit\" otherwise enter the directory path");
    Console.WriteLine("Enter directory: ");
    input = Convert.ToString(Console.Read());

    if (input == "exit")
    {
        counter = Directory.GetDirectories(input).Length;
    }


    foreach (string file in Directory.GetFiles(input))
    {
        Console.WriteLine(file);
    }

    string[] dir = Directory.GetDirectories(input);


    foreach (string folder in dir)
    {
        if (counter == dir.Length)
        {
            break;
        }
        counter++;
        WorkOnFile(folder);
    }
}


WorkOnFile("C:\\Users\\lukaa\\Desktop\\New folder (2)\\Midterm\\New folder");
//Console.ReadKey();

//Console.ReadKey();