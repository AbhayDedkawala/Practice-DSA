namespace DSA
{
    public sealed class ArrayDSA : IDisposable
    {
        public ArrayDSA() => Console.Clear();

        public void Dispose() => Console.Read();


        /// <summary>
        /// Reverse Integer Array <br/>
        /// Input Array : { 1, 5, 8, 2, 3 } <br/>
        /// Output Array : { 3, 2, 8, 5, 1 }
        /// </summary>
        public void ArrayIntegerReverse()
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

        /// <summary>
        /// Sort Integer Array <br/>
        /// Input Array : { 1, 5, 8, 2, 3 } <br/>
        /// Output Array : { 1, 2, 3, 5, 8 }
        /// </summary>
        public void ArrayIntegerSort()
        {
            bool isAscending = false;
            int[] numbers = new int[] { 1, 5, 0, 3, 4, 2 };

            Console.WriteLine("Before array sorting.");

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));

            for (int i = 0; i < numbers.Length; i++)
                for (int j = i; j < numbers.Length; j++)
                    if ((isAscending && numbers[i] > numbers[j]) || (!isAscending && numbers[i] < numbers[j]))
                    {
                        numbers[i] += numbers[j];
                        numbers[j] = numbers[i] - numbers[j];
                        numbers[i] = numbers[i] - numbers[j];
                    }


            Console.WriteLine("\nAfter array sorting.");

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));
        }

        public void ArraySubArray()
        {
            int[] numbers = new int[] { 1, 5, 0, 2 };
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
                for (int j = 0; j < i + 1; j++, count++)
                {
                    for (int k = j; k < i + 1; k++)
                        Console.Write(numbers[k]);

                    Console.Write("\n");
                }

            Console.WriteLine("Total : " + count);
        }
    }
}