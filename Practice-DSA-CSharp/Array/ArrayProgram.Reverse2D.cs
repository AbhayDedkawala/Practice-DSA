namespace DSA.Array{
    public partial class ArrayProgram {

        private static void Reverse2D()
        {
            int[,] numbers = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
                for (int j = 0; j < numbers.GetLength(1) / 2; j++)
                {
                    numbers[i, j] = numbers[i, j] + numbers[i, numbers.GetLength(1) - j - 1];
                    numbers[i, numbers.GetLength(1) - j - 1] = numbers[i, j] - numbers[i, numbers.GetLength(1) - j - 1];
                    numbers[i, j] = numbers[i, j] - numbers[i, numbers.GetLength(1) - j - 1];
                }

            Console.WriteLine("\nAfter array reverse.");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                    Console.Write(numbers[i, j] + "\t");

                Console.Write("\n");
            }
        }
    }
}