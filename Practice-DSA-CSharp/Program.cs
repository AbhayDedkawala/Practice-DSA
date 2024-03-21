// See https://aka.ms/new-console-template for more information

namespace DSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Console.Clear();

                Console.WriteLine("=====================================================================");
                Console.WriteLine("Select Options : ");
                Console.WriteLine("=====================================================================");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Array Sort");
                Console.WriteLine("2. Array Reverse");
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
                        array.ArrayIntegerSort();

                    break;

                case "2":
                    using (ArrayDSA array = new ArrayDSA())
                        array.ArrayIntegerReverse();

                    break;

                case "0":
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}