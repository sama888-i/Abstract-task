namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users("asd", "sda@example.com", "Sm1234578");
          

            
            Student student1 = new Student("dfh shh", 85);
            Student student2 = new Student("kjak huis", 90);
            student1.StudentInfo();
            student2.StudentInfo();

            
            Group group = new Group("BP215", 12);
            group.AddStudent(student1);
            group.AddStudent(student2);

            foreach (var student in group.GetAllStudents())
            {
                student.StudentInfo();
            }
            

            Student foundStudent = group.GetStudent(1);
            if (foundStudent != null)
            {
                Console.WriteLine($"Student: {foundStudent.FullName }");
            }


        }
    }
}
