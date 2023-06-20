namespace Basic_Problems
{
    /**
        4. Write a C# Sharp program to print the results of the specified operations.
        Test data:

        -1 + 4 * 6
        ( 35+ 5 ) % 7
        14 + -4 * 6 / 11
        2 + 15 / 6 * 1 - 7 % 2
   **/
    public class ProblemFour
    {
        public static void ExecuteExpressions()
        {
            Console.WriteLine("4. Write a C# Sharp program to print the results of the specified operations.");
            Console.WriteLine("Test Data: ");
            Console.WriteLine($"-1 + 4 * 6 :  {-1 + 4 * 6}");
            Console.WriteLine($"( 35+ 5 ) % 7 :  {(35 + 5) % 7}");
            Console.WriteLine($"14 + -4 * 6 / 11 :  {14 + -4 * 6 / 11}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 :  {2 + 15 / 6 * 1 - 7 % 2}");
        }
    }
}