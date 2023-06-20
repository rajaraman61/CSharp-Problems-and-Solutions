/**
5. Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
**/

public class ProblemFive {
    public static void swapping() {
        Console.Write("Input the First Number :");
        var input_one = Convert.ToInt16(Console.ReadLine());

        Console.Write("Input the Second Number :");
        var input_two = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("\nBefore Swapping: ");
        Console.WriteLine($"First Number: {input_one}");
        Console.WriteLine($"Second Number: {input_two}");

        Console.WriteLine("\nAfter Swapping: ");
        var temp = input_one;
        input_one = input_two;
        input_two = temp;
        Console.WriteLine($"First Number: {input_one}");
        Console.WriteLine($"Second Number: {input_two}");
    }
}