using System;
using System.Collections.Generic;
using WorkTriangle;

namespace UserTriangle
{
  public class Program
  {
    public static void Main()
    {
      int[] input = {0, 0, 0};
      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine($"Please enter the length side {i+1} of your triangle:");
        string sideUser = Console.ReadLine();
        if (string.IsNullOrEmpty(sideUser))
        { 
          Console.WriteLine("You should provide an input!");
          Main();
        }
        else if (!int.TryParse(sideUser, out int number))
        {
          Console.WriteLine("You need to provide a number!");
          Main();
        } 
        input[i] = int.Parse(sideUser);
      }
      Triangle triangle = new Triangle();
      Console.WriteLine(triangle.ValidateTriangle(input[0], input[1], input[2]));
    }
  }
}