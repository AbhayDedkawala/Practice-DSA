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
        public void IntegerReverse()
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
        public void IntegerSort()
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

        public void SubArray()
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

        public void Peak()
        {
            int[] numbers = new int[] { 1, 2, 1, 2, 1 };
            int peak = 0;

            if (numbers.Length == 1) peak = 0;
            else if (numbers[0] > numbers[1]) peak = 0;
            else if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2]) peak = numbers.Length - 1;

            for (int i = 1; i < numbers.Length - 1; i++)
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    peak = i;
                    break;
                }

            Console.WriteLine(string.Format("Peak Index : {0} \nPeak Element : {1}", peak, numbers[peak]));
        }

        public void MinMaxSum()
        {
            int[] numbers = new int[] { 10, 5, -25, -7, 19, 2, -10, 23, 44 };
            int min = numbers[0], max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                else if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine("Sum of Min & Max Element is : " + ( min + max ));
        }

        public void Reverse2D()
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

        public void Transpose2D()
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

        public void Rotate2DClockWise90()
        {
            int[,] numbers = new int[4, 5] {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20} };

            int[,] rotation = new int[numbers.GetLength(1), numbers.GetLength(0)];


            for (int i = numbers.GetLength(1); i > 0; i--)
                for (int j = numbers.GetLength(0); j > 0; j--)
                    rotation.SetValue(numbers[j - 1, i - 1], i - 1, numbers.GetLength(0) - j);


            Console.WriteLine("\nAfter Rotate 2D array Clock Wise 90 degree.");

            for (int i = 0; i < rotation.GetLength(0); i++)
            {
                for (int j = 0; j < rotation.GetLength(1); j++)
                    Console.Write(rotation[i, j] + "\t");

                Console.Write("\n");
            }
        }

        public void Rotate2DClockWise180()
        {
            int[,] numbers = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15,16} };

            int[,] rotation = new int[numbers.GetLength(1), numbers.GetLength(0)];


            for (int i = numbers.GetLength(1); i > 0; i--)
                for (int j = numbers.GetLength(0); j > 0; j--)
                    rotation.SetValue(numbers[j - 1, i - 1], numbers.GetLength(0) - j, numbers.GetLength(1) - i);


            Console.WriteLine("\nAfter Rotate 2D array Clock Wise 180 degree.");

            for (int i = 0; i < rotation.GetLength(0); i++)
            {
                for (int j = 0; j < rotation.GetLength(1); j++)
                    Console.Write(rotation[i, j] + "\t");

                Console.Write("\n");
            }
        }

        public void Rotate2DClockWise270()
        {
            int[,] numbers = new int[4, 5] {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20} };

            int[,] rotation = new int[numbers.GetLength(1), numbers.GetLength(0)];


            for (int i = numbers.GetLength(1); i > 0; i--)
                for (int j = 0; j < numbers.GetLength(0); j++)
                    rotation.SetValue(numbers[j, i - 1], numbers.GetLength(1) - i, j);


            Console.WriteLine("\nAfter Rotate 2D array Clock Wise 270 degree.");

            for (int i = 0; i < rotation.GetLength(0); i++)
            {
                for (int j = 0; j < rotation.GetLength(1); j++)
                    Console.Write(rotation[i, j] + "\t");

                Console.Write("\n");
            }
        }
    }
}