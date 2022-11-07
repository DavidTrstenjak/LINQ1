using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LINQ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John" } ,
				new Student() { StudentID = 2, StudentName = "Moin" } ,
				new Student() { StudentID = 3, StudentName = "Bill" } ,
				new Student() { StudentID = 4, StudentName = "Ram" } ,
				new Student() { StudentID = 5, StudentName = "Ron"  }
			};

			// upit i izvršavanje upita
			var upitQuery = from student in studentList
							where student.StudentName.Contains("n")
							select student.StudentName;

			foreach (var student in upitQuery)
            {
				Console.WriteLine(student);
            }

			Console.ReadKey();

		}
	}


	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }

		
			}
		}
	
    

