namespace DSA.Array{
    public partial class ArrayProgram {

        /// <summary>
        /// Sort Integer Array <br/>
        /// Input Array : { 1, 5, 8, 2, 3 } <br/>
        /// Output Array : { 1, 2, 3, 5, 8 }
        /// </summary>
        private static void IntegerSort()
        {
            int[] numbers = new int[] { 1, 5, 0, 3, 4, 2 };

            Console.WriteLine("Before array sorting.");

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));

            for (int i = 0; i < numbers.Length; i++)
                for (int j = i; j < numbers.Length; j++)
                    if (numbers[i] > numbers[j])
                    {
                        numbers[i] += numbers[j];
                        numbers[j] = numbers[i] - numbers[j];
                        numbers[i] = numbers[i] - numbers[j];
                    }


            Console.WriteLine("\nAfter array sorting.");

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));
        }
    }
}