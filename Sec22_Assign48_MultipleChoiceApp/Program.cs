using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sec22_Assign48_MultipleChoiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateTestPaper();
            CreateTestPaper();
            createStudent();
            studentExam();
            studentExam();

            Console.ReadKey();
        }
        static int c = 1;
        static int d = 1;
        static ITestPaper testPaper = new TestPaper();
        static ITestPaper CreateTestPaper()
        {
            //ITestPaper testPaper = new TestPaper();
            //int c = 1;
            Console.WriteLine("Enter details for Paper " + c + ": ");
            c++;
            Console.Write("Enter Subject Name: ");
            testPaper.SubjectName = Console.ReadLine();
            Console.Write("Enter Test Paper Name: ");
            testPaper.TestPaperName = Console.ReadLine();
            Console.Write("\n");

            testPaper.Questions = new List<IQuestion>(); // 2
            int a = 1;
            for (int i = 0; i<10; i++)
            {
                Console.Write("Enter Question " + a + ": ");
                a++; 
                IQuestion userQuestion = new Question();  // 1    
                userQuestion.QuestionText = Console.ReadLine();
                userQuestion.Options = new List<IOption>(); //b

                char X = 'A';               
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Enter Option " + X + ": ");
                    X++;
                    IOption userOption = new Option(); //a
                    userOption.OptionText = Console.ReadLine();
                    userQuestion.Options.Add(userOption); // a to b
                }
                //UserQuestion.CorrectAnswerLetter = (char)Console.Read();
                Console.Write("Enter Correct Answer Letter: ");
                userQuestion.CorrectAnswerLetter = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine("\n");
                testPaper.Questions.Add(userQuestion); //1 to 2
            }
            Console.WriteLine("-------------------------------------------------");

            return testPaper;
        }

        static ITestPaper createStudent()
        {
            IStudent student = new Student();
            Console.Write("Enter your Roll Number: ");
            student.RollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Name: ");
            student.StudentName = Console.ReadLine();
            Console.WriteLine("\n");
            return testPaper;
        }

            
        static ITestPaper studentExam()
        {

            int b = 1;
            int totalMarks = 0;
            foreach (var question in testPaper.Questions)  //
            {
                Console.Write("Question " + b + ": ");
                b++;
                Console.WriteLine(question.QuestionText);
                char y = 'A';
                foreach (var option in question.Options)
                {
                    Console.Write("Enter Option " + y + ": ");
                    Console.WriteLine(option.OptionText);
                    y++;
                }
                Console.Write("\n");
                Console.Write("Enter Correct Answer Letter: ");
                char userAns = char.ToUpper(Console.ReadKey().KeyChar);
                Console.Write("\n");
                if (userAns == question.CorrectAnswerLetter)
                {
                    question.MarksSecured++;
                    totalMarks = totalMarks + question.MarksSecured;
                }
            }
            Console.WriteLine("Total Marks Secured for Paper " + d + ": " + totalMarks);
            d = d + 1;
            Console.WriteLine("\n");

            return testPaper;


        }
    }
}
