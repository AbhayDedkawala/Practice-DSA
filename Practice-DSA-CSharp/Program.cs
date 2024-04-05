// See https://aka.ms/new-console-template for more information

namespace DSA
{
    public class Program
    {
        public static void Main(string[] args)
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
                Console.WriteLine("5. Reverse 2D Array");
                Console.WriteLine("6. Transpose 2D Array");
                Console.WriteLine("7. Rotate 2D Array Clock wise 90 degree");
                Console.WriteLine("8. Rotate 2D Array Clock wise 180 degree");
                Console.WriteLine("9. Rotate 2D Array Clock wise 270 degree");
                Console.WriteLine("=====================================================================");

                string? program = Console.ReadLine();

                if (!string.IsNullOrEmpty(program))
                    ProgramPerform(program);
            }
        }

        public static void ProgramPerform(string program)
        {
            switch (program)
            {
                case "1":
                    using (ArrayDSA array = new ArrayDSA())
                        array.IntegerSort();

                    break;

                case "2":
                    using (ArrayDSA array = new ArrayDSA())
                        array.IntegerReverse();

                    break;

                case "3":
                    using (ArrayDSA array = new ArrayDSA())
                        array.SubArray();

                    break;

                case "4":
                    using (ArrayDSA array = new ArrayDSA())
                        array.Peak();

                    break;

                case "5":
                    using (ArrayDSA array = new ArrayDSA())
                        array.Reverse2D();

                    break;

                case "6":
                    using (ArrayDSA array = new ArrayDSA())
                        array.Transpose2D();

                    break;

                case "7":
                    using (ArrayDSA array = new ArrayDSA())
                        array.Rotate2DClockWise90();

                    break;

                case "8":
                    using (ArrayDSA array = new ArrayDSA())
                        array.Rotate2DClockWise180();

                    break;

                case "9":
                    using (ArrayDSA array = new ArrayDSA())
                        array.Rotate2DClockWise270();

                    break;

                case "0":
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}