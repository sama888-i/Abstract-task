using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Student
    {
        private int _id;
        public string FullName;
        public double Point;
        public int ID { get; set; }
        public Student(string fullName,double point)
        {
            ++_id;
            ID = _id;
            FullName = fullName;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"ID:{ID},FullName:{FullName},Point:{Point}");

        }



    }
}
