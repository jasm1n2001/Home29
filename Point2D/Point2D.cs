namespace Point2D;

public class Point2D
{
    public int _x {get; set;}
    public int _y {get; set;}

    public Point2D()
    {

    }

    public Point2D(int x, int y)
   {
     _x = x;
      _y = y;
   }
   public override string ToString() 
   {
    return $"({_x}, {_y})";
   }
}
