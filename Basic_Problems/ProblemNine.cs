namespace Basic_Problems
{
    /**
        9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
        Test Data:
        Enter the First number: 10
        Enter the Second number: 15
        Enter the third number: 20
        Enter the four number: 30

        Expected Output:
        The average of 10 , 15 , 20 , 30 is: 18
   **/
    public class ProblemNine
    {
        public static void FindAverageOfGivenNumbers()
        {
            Console.WriteLine("9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. ");

            Console.WriteLine("Input the first number: ");
            var input_one = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            var input_two = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the third number: ");
            var input_three = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the fourth number: ");
            var input_four = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"{input_one} + {input_two} + {input_three} + {input_four} = {(input_one + input_two + input_three + input_four) / 4}");
        }
    }
}