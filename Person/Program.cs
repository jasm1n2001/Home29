


using Person;

Student st1 = new Student("Jamomol", "Salimov");
Teacher t1 = new Teacher("Kurbon", "Kurbonov");

st1.AddCourseGrade("bj ", 5);
st1.AddCourseGrade("Jami ", 9);
st1.AddCourseGrade("l; ", 10);
Console.WriteLine(st1.GetAverageGrade());
System.Console.WriteLine(st1.ToString());


t1.AddCourse("NAb");
t1.AddCourse("29");
t1.AddCourse("SAn");
Console.WriteLine(t1.RemoveCourse("age"));
Console.WriteLine(t1.ToString());