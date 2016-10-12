using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveStudentToDb();
            Console.WriteLine("Student saved!");
            Console.ReadLine();
        }

        public static void SaveStudentToDb()
        {
            using (var db = new StudentDbContext())
            {
                var student = new Student
                {
                    Name = "Niels Odgaard",
                    Phone = "51410927",
                    DateTime = DateTime.Now
                };
                db.Students.Add(student);              
                db.SaveChanges();

                
            }
        }
    }
}
