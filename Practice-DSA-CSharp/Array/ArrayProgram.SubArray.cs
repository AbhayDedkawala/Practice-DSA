namespace DSA.Array{
    public partial class ArrayProgram {
        
        /// <summary>
        /// Sub Array <br/>
        /// Input Array : { 1, 2, 5 } <br/>
        /// Output Array : { { 1 }, { 2 }, { 5 }, { 1, 2 }, { 2, 5 }, { 1, 2, 5 } }
        /// </summary>
        private static void SubArray()
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