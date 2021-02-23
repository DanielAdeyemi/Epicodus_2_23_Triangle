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
      return "valid";
    }
  }
}