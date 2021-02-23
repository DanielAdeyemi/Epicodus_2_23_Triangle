namespace Triangle
{
  public class Triangle
  {
    public string ValidateTriangle(int side1, int side2, int side3) 
    {
      if (side1 <= 0 || side2 <= 0 || side3 <= 0)
      {
        return "invalid";
      }
      else if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
      {
        return "invalid";
      }
      else if (side1 == side2 && side2 == side3) 
      {
        return "Equilateral Triangle";
      }
      else if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        return "Isosceles Triangle";
      }
      return "Scalene Triangle";
    }
  }
}