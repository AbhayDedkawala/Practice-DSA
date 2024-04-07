namespace DSA.Array{
    public partial class ArrayProgram {

        private static void MinMaxSum()
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

            Console.WriteLine("Sum of Min & Max Element is : " + (min + max));
        }
    }
}