using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Encapsulation
{
    //internal class Student : Person
    //{
    //    public string StudentId;
    //    public Student(string name, string surname, byte age, string studentid, int point) : base(name, surname, age)
    //    {
    //        StudentId = studentid;
    //        Point = point;
    //        Name = name;
    //        Surname = surname;
    //        Age = age;

    //    }
    //    private int _Point;
    //    public int Point
    //    {
    //        get { return _Point; }
    //        set
    //        {
    //            if (value > 0 && value < 100)
    //            {
    //                _Point = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Duzgun deyil");
    //            }
    //        }
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"Name:{Name},Surname:{Surname},Age:{Age},StudentId:{StudentId},Point:{_Point}");

    //    }
    //    public string GetInfo() 
    //    {
    //        return $"Name:{Name},Surname:{Surname},Age:{Age},StudentId:{StudentId},Point:{_Point}";
    //    }
    //}
}
