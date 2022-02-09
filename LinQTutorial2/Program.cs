using System;
using System.Linq;

namespace LinQTutorial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Learning Linq and how it is being used Part 2**************");


            Console.WriteLine("1. ************GroupBy==> studentList.GroupBy(x => x.Branch);**************");
            var studentList = Student.GetStudents();
            var groupStudentByBranch = studentList.GroupBy(x => x.Branch);
            foreach (var group in groupStudentByBranch)
            {
                Console.WriteLine("--------");
                Console.WriteLine(group.Key);
                Console.WriteLine("--------");
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name);
                }
            }

            Console.WriteLine(
                "2. ************GroupByMultipleProperties==> studentList.GroupBy(x => new {x.Branch, x.Gender});**************");
            var groupStudentByMultipleKeys = studentList.GroupBy(x => new {x.Branch, x.Gender})
                .OrderByDescending(x=>x.Key.Branch).ThenBy(x=>x.Key.Gender);
            foreach (var group in groupStudentByMultipleKeys)
            {
                Console.WriteLine("--------");
                Console.WriteLine(group.Key);
                Console.WriteLine("--------");
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
    }
}