namespace DSA.Array{
    public partial class ArrayProgram {

        private static void Peak()
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
    }
}