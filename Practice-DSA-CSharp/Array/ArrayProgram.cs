namespace DSA.Array
{
    public partial class ArrayProgram
    {
        public static void Program()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("=====================================================================");
                Console.WriteLine("Select Options : ");
                Console.WriteLine("=====================================================================");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Array Sort");
                Console.WriteLine("2. Array Reverse");
                Console.WriteLine("3. Sub Array");
                Console.WriteLine("4. Peak Array");
                Console.WriteLine("5. Min & Max sum");
                Console.WriteLine("6. Reverse 2D Array");
                Console.WriteLine("7. Transpose 2D Array");
                Console.WriteLine("8. Rotate 2D Array Clock wise 90 degree");
                Console.WriteLine("9. Rotate 2D Array Clock wise 180 degree");
                Console.WriteLine("10. Rotate 2D Array Clock wise 270 degree");
                Console.WriteLine("=====================================================================");

                string? program = Console.ReadLine();
                Console.Clear();

                if (!string.IsNullOrEmpty(program))
                    ProgramPerform(program);

                Console.Read();
            }
        }

        private static void ProgramPerform(string program)
        {
            switch (program)
            {
                case "1":
                    IntegerSort();
                    break;

                case "2":
                    IntegerReverse();
                    break;

                case "3":
                    SubArray();
                    break;

                case "4":
                    Peak();
                    break;

                case "5":
                    MinMaxSum();
                    break;

                case "6":
                    Reverse2D();
                    break;

                case "7":
                    Transpose2D();
                    break;

                case "8":
                    Rotate2DClockWise90();
                    break;

                case "9":
                    Rotate2DClockWise180();
                    break;

                case "10":
                    Rotate2DClockWise270();
                    break;

                case "0":
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}