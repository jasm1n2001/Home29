namespace Point2D;

public class Point3D:Point2D
{
   public int _z {get; set;}
   public Point3D()
   {
      
   }
   public Point3D(int x,int y,int z):base(x,y)
   {
     _z = z;
   }
   public override string ToString()=> $"({_x},{_y},{_z})";
}

