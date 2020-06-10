using System;
using System.Collections.Generic;

namespace HowTo
{
    public class Program
    {
        ResearchProject project = new ResearchProject("Dokumentation für die Generische Validierung komplexer Planungsalgorithmen", new Person("Prof. Dr. rer. pol. Torsten Munkelt",18));
        
        static void Main(string[] args)
        {
            Console.WriteLine("Example how to use it");
        }

        public bool countToTen()
        {
            HowToUseIt useIt = new HowToUseIt();

            for (int i = 0; i < 10; i++)
            {
                useIt.addOne();
            }

            if (useIt.getNumber().Equals(10)) { return true; } else { return false; };
        }

        public bool singleObjectTest()
        {
            Console.WriteLine(project.amountStudents());
            return true;
        }

        public void addStudentsToProject()
        {
            project.Students.Add(new Person("Luisa", 13));
            project.Students.Add(new Person("Anh", 14));
            project.Students.Add(new Person("Jonas", 15));
            project.Students.Add(new Person("Lennert", 16));
        }
    }

    public class HowToUseIt
    {
        public int number = 0;

        public void addOne()
        {
            Console.Write("Changed number from " + number);
            number++;
            Console.WriteLine(" to " + number);
        }

        public int getNumber()
        {
            return number;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void hasBirthday()
        {
            Age++;
        }
    }

    public class ResearchProject
    {
        public string ProjectName { get; set; }
        public Person Responsible { get; set; }
        public List<Person> Students { get; }

        public ResearchProject(string name, Person responsible)
        {
            ProjectName = name;
            Responsible = responsible;
            Students = new List<Person>();
        }

        public int amountStudents()
        {
            return Students.Count;
        }
    }


}
