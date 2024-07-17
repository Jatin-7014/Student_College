using StudentCollege.Models;

namespace StudentCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(101,"Jammu","22/03/2002");
            Professor professor= new Professor(1002,"Mumbai","13/09/1983",50000);
            Student student = new Student(201,"Navi-Mumbai","12/05/2000","Comps");
            ShowDetails(person);
            ShowDetails(professor);
            ShowDetails(student);
        }

        public static void ShowDetails(Person person)
        {
            Console.WriteLine($"===================={person.GetType().Name}=======================");
            Console.WriteLine(person.PrintDetails());
        }
    }
}
