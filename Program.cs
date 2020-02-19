using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examschema
{
    class Program
    {

        public static Model4Container mc = new Model4Container();

        static void Main(string[] args)
        {

            Display();
            Console.ReadKey();

            /* Console.WriteLine("MODEL FIRST APPROACH ");


             int ch = 0;
             do
             {
                 Console.WriteLine("1.insert 2.display 3.exit ");
                 Console.WriteLine("enter your choice");
                 ch = int.Parse(Console.ReadLine());
                 switch (ch)
                 {
                     case 1:
                         InsertSchool();
                         InsertStudent();
                         InsertExam();
                         InsertResults();

                         break;
                     case 2:
                         ShowSchool();
                         ShowStudent();
                         break;
                     case 3:
                         return;



                 }
             } while (ch <= 2);*/




        }
        // Insert center data

        public static void InsertSchool()
        {
            Console.WriteLine("Enter Center Details:");
            Console.WriteLine("Center Id:");
            int cid = int.Parse(Console.ReadLine());

            Console.WriteLine("Center Name:");
            string cname = Console.ReadLine();

            Console.WriteLine("Address:");
            string address = Console.ReadLine();

            var centers = new List<School1>()
                {
                new School1{ Sid=cid, Sname=cname, Sloc=address}
                };

            centers.ForEach(s => mc.School1.Add(s));
            mc.SaveChanges();
            Console.WriteLine("Center added");
        }

        // Insert  exam details data

        public static void InsertExam()
        {
            Console.WriteLine("Enter Exam Details:");
            Console.WriteLine("Exam Code:");
            int ecode = int.Parse(Console.ReadLine());

            Console.WriteLine("Examination Name:");
            string ename = Console.ReadLine();

            Console.WriteLine("Examination Name:");
            string edate = Console.ReadLine();

            Console.WriteLine("Total Marks:");
            string tmarks = Console.ReadLine();

            Console.WriteLine("Passing Marks:");
            string pmarks = Console.ReadLine();

            Console.WriteLine("Duration:");
            string time = Console.ReadLine();

            var exam = new List<Exam1>()
                {
                new Exam1{
                    ExamCode=ecode,
                    ExamName=ename,
                    ExamDate=edate,
                    MaxMarks=tmarks,
                    CutOff=pmarks,
                    Duration=time
                }
                };

            exam.ForEach(s => mc.Exam1.Add(s));
            mc.SaveChanges();
            Console.WriteLine("Exam Details added");
        }

        // Insert  student details data

        public static void InsertStudent()
        {
            Console.WriteLine("Student Details:\n");
            Console.WriteLine("Seat No:");
            int seatno = int.Parse(Console.ReadLine());

            Console.WriteLine("Student Name:");
            string sname = Console.ReadLine();

            Console.WriteLine("Exam Date:");
            string edate = Console.ReadLine();

            Console.WriteLine("Exam Code:");
            int ecode = int.Parse(Console.ReadLine());

            Console.WriteLine("Center Code:");
            int ccode = int.Parse(Console.ReadLine());


            var students = new List<Student1>()
                {
                new Student1{
                    StNo=seatno,
                    StName=sname,
                    ExamDt=edate,
                    ExamCode=ecode,
                    Sid=ccode
                }
                };

            students.ForEach(s => mc.Student1.Add(s));
            mc.SaveChanges();
            Console.WriteLine("Student Details added");
        }


        // Insert  results details data

        public static void InsertResults()
        {
            Console.WriteLine("Result Details:\n");
            Console.WriteLine("Seat No:");
            int seatno = int.Parse(Console.ReadLine());

            Console.WriteLine("Marks Obtained:");
            int omarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Total Marks:");
            int tmarks = int.Parse(Console.ReadLine());

            float percent = ((float)omarks / (float)tmarks) * 100;
            string result_status = (percent >= 40 ? "Pass" : "Fail");

            var results = new List<Result1>()
                {
                new Result1{
                    StNo = seatno,
                    SecMarks = omarks,
                    MaxMarks = tmarks,
                    Percentage = percent,
                }
                };

            results.ForEach(s => mc.Result1.Add(s));
            mc.SaveChanges();
            Console.WriteLine("Result Details added");
        }

        public static void Display()
        {
            Console.WriteLine("::Student::\n");
            var students = mc.Student1;

            foreach (var s in students)
            {
                Console.WriteLine("Seat No: {0}\nStudent Name: {1}\nExam Code: {2}\nExam Name: {3}\nExam Date: {4}\nTime: {5}\nCenter Code: {6}\nCenter Name: {7}\nAddress: {8}",
                    s.StNo,
                    s.StName,
                    s.ExamCode,
                    s.Exam.ExamName,
                    s.Exam.ExamDate,
                    s.Exam.Duration,
                    s.Sid,
                    s.School.Sname,
                    s.School.Sloc

               );
                Console.WriteLine("\n\n");
            }
        }

    }
}