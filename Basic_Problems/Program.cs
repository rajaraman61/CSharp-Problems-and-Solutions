using System;
using System.Collections.Generic;
using Basic_Problems;

namespace BasicProblems
{
    class Program
  {
    private static readonly Dictionary<int, Action> problemMap = new Dictionary<int, Action>();

    static void Main(string[] args)
    {
      RegisterMethods();

      Console.WriteLine("Enter a problem index to execute: ");
      int problemIndex = Convert.ToInt32(Console.ReadLine());

      if (problemMap.ContainsKey(problemIndex))
      {
        if (problemMap.TryGetValue(problemIndex, out var method))
        {
          method.Invoke();
        }
        else
        {
          Console.WriteLine("No method found for the input: " + problemIndex);
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a valid problem index.");
      }
    }

    public static void RegisterMethods()
    {
      // Register your methods here
      problemMap.Add(1, ProblemOne.PrintName);
      problemMap.Add(2, () => ProblemTwo.SumOfTwoNumbers(4, 5));
      problemMap.Add(3, () => ProblemThree.DivideOfTwoNumbers(5, 2));
      problemMap.Add(4, ProblemFour.ExecuteExpressions);
      problemMap.Add(5, ProblemFive.Swapping);
      problemMap.Add(6, ProblemSix.MultiplyNumbers);
      problemMap.Add(7, ProblemSeven.CalculateNumbers);
      problemMap.Add(8, ProblemEight.MultiplyNumbersByGivenNumber);
      problemMap.Add(9, ProblemNine.FindAverageOfGivenNumbers);
      problemMap.Add(10, ProblemTen.CalculateFormula);
      // Add more mappings as needed
    }
  }
}
