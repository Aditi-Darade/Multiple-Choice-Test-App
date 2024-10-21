using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  
    
        public interface ITestPaper
        {
            string SubjectName { get; set; } //property
            string TestPaperName { get; set; }
            List<IQuestion> Questions { get; set; }
        }
        public interface IQuestion
        {
            string QuestionText { get; set; }
            List<IOption> Options { get; set; }
            char CorrectAnswerLetter { get; set; }
            char OptionSelectedByStudent { get; set; }
            int MarksSecured { get; set; }
        }
        public interface IOption
        {
            char OptionLetter { get; set; }
            string OptionText { get; set; }
        }
        public interface IStudent
        {
            int RollNo { get; set; }
            string StudentName { get; set; }
            List<ITestPaper> TestPapers { get; set; }
        }
        //-----------------------------------------------------------------------------------------
        
        public class TestPaper : ITestPaper
        {
            private string subjectName;
            private string testPaperName;
            private List<IQuestion> questions;

            public string SubjectName
            {
                set { subjectName = value;}
                get { return subjectName;}
            }
            /*
            public void GetSubjectNameFromUser()
            {
                Console.WriteLine("Enter Subject Name: ");
                SubjectName = Console.ReadLine();
                Console.WriteLine(subjectName);
            }
            */
            public string TestPaperName
            {
                set { testPaperName = value; }
                get { return testPaperName; }
            }
            public List<IQuestion> Questions
            {
                set { questions = value; }
                get { return questions; }
            }
             
        }
        
        public class Question : IQuestion
        {
            private string questionText;
            private List<IOption> options;
            private char correctAnswerLetter;
            private char optionSelectedByStudent;
            private int marksSecured = 0;
            public string QuestionText
            {
                set { questionText = value; }
                get { return questionText; }
            }

            public List<IOption> Options
            {
                set { options = value; }
                get { return options; }

            }
            public char CorrectAnswerLetter
            {
                set { correctAnswerLetter = value; }
                get { return correctAnswerLetter; }
            }

            public char OptionSelectedByStudent
            {
                set { optionSelectedByStudent = value; }
                get { return optionSelectedByStudent; }
            }
            public int MarksSecured
            {
                set { marksSecured = value; }
                get { return marksSecured; }
            }
        }
       
        public class Option : IOption
        {
            private char optionLetter;
            private string optionText;
            public char OptionLetter
            {
                set { optionLetter = value; }
                get { return optionLetter; }
            }
            public string OptionText
            {
                set { optionText = value; }
                get { return optionText; }
            }

        }
        
       public class Student : IStudent
       {
            private int rollNo;
            private string studentName;
            private List<ITestPaper> testPapers;

            public int RollNo
            {
                set { rollNo = value; }
                get { return rollNo; }
            }
            public string StudentName
            {
                set { studentName = value; }
                get { return studentName; }
            }
            public List<ITestPaper> TestPapers
            {
                set { testPapers = value; }
                get { return testPapers; }
            }
        }
       
   
}
