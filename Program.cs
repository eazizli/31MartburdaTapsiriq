using System.Xml.Linq;
using TapsMetod;

internal class Program
{
    private static void Main(string[] args)
    {
        //Backend backend = new Backend("aqil", "kerimov");
        //Console.WriteLine(backend.Name + backend.Surname + backend.Age,backend.SqlExperienceYear);
      
        Fronted fronted = new Fronted("aqil");
        Console.WriteLine(fronted.Name);
      
    //    Human human = new Human();
    //    human.Name = "namiq";
    //    human.Surname = "eliyve";
    //    human.age = 12;
    //    Human human1 = new Human();
    //    human1.Name = "elcin";
    //    human1.Surname = "eliyev";
    //    human1.age = 15;
    //    Teacher Teacher = new Teacher();
    //    Teacher.Name = "anar";
    //    Teacher.Surname = "aliyev";
    //    Teacher.age = 19;
    //    Teacher.Salary = 520;
    //    Teacher.GroupNo = "bp203";
    //    Student student = new Student();
    //    student.Name = "anar";
    //    student.Surname = "aliyev";
    //    student.age = 19;
    //    student.Scolarship = 520;
    //    student.GroupNO = "bp203";
    //    Console.WriteLine(human.Name+"  "+human.Surname);
    }
    //class Human
    //{
    //    public string Name;
    //    public string Surname;
    //    public int age;
    //}
    //class Teacher :Human
    //{
    //    public int Salary;
    //    public string GroupNo;
    //}
    //class Student : Human 
    //{
    //    public int Scolarship;
    //    public string GroupNO;
    
    //}


}