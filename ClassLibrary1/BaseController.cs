using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }

    public class Student:Person
    {
        public int StudentId { get; set; }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName} {StudentId}";
        }

    }

    public abstract class Person2
    {
        public abstract string GetYourName();
    }

    public class ElementaryStudent:Person2
    {
        public override string GetYourName()
        {
            return "ElementaryStudent";
        }
    }
    public class HighSchoolStudent : Person2
    {
        public override string GetYourName()
        {
            return "HighSchoolStudent";
        }
    }
}
