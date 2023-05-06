using System;

namespace Practice_Aggregation_and_Containment
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J102", will);
            prog124.AddStudent("Ana", "Mendes", 100, 100);
            Console.WriteLine(will);
            //Console.WriteLine(Instructor);
            Console.WriteLine(prog124);
        }
    }
}