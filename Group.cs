using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Group
    {
        public string GroupNo;
        int _studentLimit;
        private Student[] Students = { };

        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

        public int  StudentLimit
            
        {
            get
            {
                return _studentLimit;
            }
            set
            {if(value>5 && value < 18)
                {
                    _studentLimit = value;
                }
            else
                {
                    Console.WriteLine("Sayi duzgun daxil edin");
                }

            }


        }
        public bool CheckGroupNo(string groupNo)
        {for(int i = 0;i < groupNo.Length; i++)
            {if(groupNo.Length == 5)
                {if(char.IsUpper(groupNo[0])&&char.IsUpper(groupNo[1]))
                    {if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                        {
                            return true;
                        }
                        
                    }
                }

            }
            return false;

        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public Student  GetStudent(int ID)
        {
            Student foundStudent = null;
            foreach (var  student in Students )
            {if (student.ID== ID)
                {
                    foundStudent = student;
                    return foundStudent;
                    
                }
                
            }
            return foundStudent;

        }
        public void GetAllStudents()
        {foreach (var student in Students)
            {
                student.StudentInfo();
            }

        }
        


    }
}
