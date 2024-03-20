public class ArrayIntSort {
    
    bool isAscending = false;
    int[] numbers = new int[] { 1, 5, 0, 3, 4, 2 };
    
    Console.WriteLine("Before array sorting.");
     
    for (int i = 0; i < numbers.Length; i++)
        Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));
    
    for (int i = 0; i < numbers.Length; i++)
        for (int j = i; j < numbers.Length; j++)
            if ( ( isAscending && numbers[i] > numbers[j] ) || ( !isAscending && numbers[i] < numbers[j] ) ) {
                numbers[i] += numbers[j];
                numbers[j] = numbers[i] - numbers[j];
                numbers[i] = numbers[i] - numbers[j];
            }


    Console.WriteLine("\nAfter array sorting.");
    
    for (int i = 0; i < numbers.Length; i++)
        Console.WriteLine(string.Format("{0} -> {1}", i, numbers[i]));
}