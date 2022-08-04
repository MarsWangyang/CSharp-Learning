class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = {4, 5, 6, 7, 8, 8, 9, 9, 10};
        string[] friends = new string[10]; // tell c# how many spaces want to be held
        friends[0] = "Jim";
        friends[1] = "Mars";
        Console.WriteLine(luckyNumbers[0]); // 4
        Console.WriteLine(luckyNumbers.Length); // 9


        int[,] array = new int[4, 2]; // create two dimension array
        int[,,] arr3 = new int[4, 2, 3]; // create an array of three dimension 4,2,3


        // Two-dimensional array.
        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // The same array with dimensions specified.
        int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // A similar array with string elements.
        string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

        // Three-dimensional array.
        int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
        // The same array with dimensions specified.
        int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[4];
        jaggedArray[2] = new int[2];
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        jaggedArray[1] = new int[] { 0, 2, 4, 6 };
        jaggedArray[2] = new int[] { 11, 22 };

        int[][] jaggedArray2 = new int[][]
        {
        new int[] { 1, 3, 5, 7, 9 },
        new int[] { 0, 2, 4, 6 },
        new int[] { 11, 22 }
        };

        Console.ReadLine();
    }
}