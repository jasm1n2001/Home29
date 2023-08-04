namespace Person;


public class Teacher : Person
{
   int numCours = 0;

   List<string> cours = new List<string>();

   public Teacher(string name, string addres) : base(name, addres) { }
   public override string ToString()
   {
      return $"Teacher : {Name}({Addres})";
   }
   public bool AddCourse(string course)
   {
      if (course == null) return false;
      cours.Add(course);
      return true;
   }
   public bool RemoveCourse(string course)
   {
      foreach (var i in cours)
      {
         if (i == course)
         {
            cours.Remove(i);
            return true;
         }
         else return false;
      }
   
   }
}
