namespace Basic_Problems
{
    /**
        Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
        Test Data:
        Input the first number to multiply: 2
        Input the second number to multiply: 3
        Input the third number to multiply: 6
        Expected Output:
        2 x 3 x 6 = 36
   **/
    public class ProblemSix
    {
        public static void MultiplyNumbers()
        {
            Console.WriteLine("Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user. ");

            Console.WriteLine("Input the first number to multiply: ");
            var input_one = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply: ");
            var input_two = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the third number to multiply: ");
            var input_three = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"{input_one} x {input_two} x  {input_three}: {input_one * input_two * input_three}");
        }
    }
}