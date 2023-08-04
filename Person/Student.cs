namespace Person;

public class Student : Person
{
   int numCours = 0;


   List<string> cours=new List<string>();
   List<int> grad=new List<int>();


   public Student(string name,string addres):base(name,addres){}
   public override string ToString()
   {
      return $"Student : {Name} {Addres} ";
   }


   public void AddCourseGrade(string course, int grade){
      cours.Add(course);
      grad.Add(grade);
   }

   public void PrintGradle()
   {
      int cnt=1;
      foreach (var i in grad)
      {
         Console.WriteLine($"{cnt} ruz: {i}");

         cnt++;
      }
   }

   public double GetAverageGrade(){
      double sum = 0;
      foreach (var i in grad)
      {
         sum += i;
      }
      return sum / (grad.Count());
   }
}
