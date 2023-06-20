namespace Basic_Problems
{
    /**
        8. Write a C# Sharp program that prints the multiplication table of a number as input.
        Test Data:
        Enter the number: 5
        Expected Output:
        5 * 0 = 0
        5 * 1 = 5
        5 * 2 = 10
        5 * 3 = 15
        ....
        5 * 10 = 50
   **/
    public class ProblemEight
    {
        public static void MultiplyNumbersByGivenNumber()
        {
            Console.WriteLine("Write a C# Sharp program that prints the multiplication table of a number as input. ");

            Console.WriteLine("Input the number to multiply: ");
            var input_one = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"{input_one} x {i} : {input_one * i}");
            }
        }
    }
}