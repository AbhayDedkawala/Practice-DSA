namespace DSA.Array{
    public partial class ArrayProgram {
        
        /// <summary>
        /// Reverse Integer Array <br/>
        /// Input Array : { 1, 5, 8, 2, 3 } <br/>
        /// Output Array : { 3, 2, 8, 5, 1 }
        /// </summary>
        private static void IntegerReverse()
        {
            int[] numbers = new int[] { 1, 5, 0, 3, 4, 2 };

            Console.WriteLine("Before array reverse.");

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                numbers[i] += numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = numbers[i] - numbers[numbers.Length - i - 1];
                numbers[i] = numbers[i] - numbers[numbers.Length - i - 1];
            }

            Console.WriteLine("\nAfter array reverse.");

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));
        }        
    }
}