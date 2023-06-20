namespace Basic_Problems
{
    /**
        6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
        Test Data:
        Input the first number to multiply: 2
        Input the second number to multiply: 3
        Input the third number to multiply: 6
        Expected Output:
        2 x 3 x 6 = 36
   **/
    public class ProblemSeven
    {
        public static void CalculateNumbers()
        {
            Console.WriteLine("Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user. ");

            Console.WriteLine("Input the first number to calculate: ");
            var input_one = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the second number to calculate: ");
            var input_two = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"{input_one} + {input_two} : {input_one + input_two}");
            Console.WriteLine($"{input_one} - {input_two} : {input_one - input_two}");
            Console.WriteLine($"{input_one} x {input_two} : {input_one * input_two}");
            Console.WriteLine($"{input_one} / {input_two} : {input_one / input_two}");
            Console.WriteLine($"{input_one} mod {input_two} : {input_one % input_two}");
        }
    }
}