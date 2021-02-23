using System;
using System.Collections.Generic;
using WorkTriangle;

namespace UserTriangle
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter the length of one side of your triangle:");
      int side1=int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the length of the second side of your triangle:");
      int side2=int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the length of the third side of your triangle:");
      int side3=int.Parse(Console.ReadLine());
      Triangle triangle = new Triangle();
      Console.WriteLine(triangle.ValidateTriangle(side1,side2,side3));
    }
  }
}