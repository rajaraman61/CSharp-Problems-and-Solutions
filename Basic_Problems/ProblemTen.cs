namespace Basic_Problems
{
    /**
        10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
        Test Data:
        Enter first number - 5
        Enter second number - 6
        Enter third number - 7

        Expected Output:
        Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
   **/
    public class ProblemTen
    {
        public static void CalculateFormula()
        {
            Console.WriteLine("Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z. ");

            Console.WriteLine("Input the first number (x): ");
            var input_one = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the second number (y): ");
            var input_two = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the third number (z): ");
            var input_three = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Result of specified numbers {input_one}, {input_two} and {input_three}, (x+y).z is {(input_one + input_two) * input_three} and x.y + y.z is {input_one * input_two + input_two * input_three}");
        }
    }
}