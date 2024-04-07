namespace DSA.Array{
    public partial class ArrayProgram {

        private static void Transpose2D()
        {
            int[,] numbers = new int[4, 5] {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20} };

            int[,] rotation = new int[numbers.GetLength(1), numbers.GetLength(0)];

            for (int i = 0; i < numbers.GetLength(0); i++)
                for (int j = 0; j < numbers.GetLength(1); j++)
                    rotation.SetValue(numbers[i, j], j, i);


            Console.WriteLine("\nTranspose 2D array.");

            for (int i = 0; i < rotation.GetLength(0); i++)
            {
                for (int j = 0; j < rotation.GetLength(1); j++)
                    Console.Write(rotation[i, j] + "\t");

                Console.Write("\n");
            }
        }
    }
}