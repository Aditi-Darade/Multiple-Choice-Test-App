Create a C# app that helps teachers to create tests with MCQ (Multiple Choice Questions) and then students can answer those questions and also the system find outs marks secured of the student.



Process flow:

Step 1: First, system should accept two test papers; each test paper contains 10 MCQ.

Each question has four options; one question has only one correct answer (correct option).



Step 2: System should allow one student to attempt both the test papers. While student answers each question, it should display the question text with list of options.

Example:

    What is the capital of U.S.A.

    A) New York

    B) Washington D.C.

    C) London

    D) New Delhi



It should accept student's choice. Eg:  B



Step 3: System should automatically compare the correct answer with student's choice; find out marks secured of each question.

It should display all questions respective correct answer, student's choice, marks secured and finally total marks secured for test paper.



Overall, one student should answer two test papers.



Code instructions:

Create TestPaper, Question, Option, Student classes. Each class should implement respective interface. The interface should define the properties needed.



class TestPaper: Represents a test with a set of questions.

class Question: Represents a single question with a set of options and also stores the student's choice along with marks secured by the student.

class Option: Represents an option of a question. The option letter should be auto-generated as "A", "B" etc.

class Student: Represents a student along with the test papers attempted by him.



interface ITestPaper
string SubjectName { get; set; }

string TestPaperName { get; set; }

List<IQuestion> Questions { get; set; }

interface IQuestion
string QuestionText { get; set; }

List<IOption> Options { get; set; }

char CorrectAnswerLetter { get; set; }

char OptionSelectedByStudent { get; set; }

int MarksSecured { get; set; }

interface IOption
char OptionLetter { get; set; }

string OptionText { get; set; }

interface IStudent
int RollNo { get; set; }

string StudentName { get; set; }

List<ITestPaper> TestPapers { get; set; }





class TestPaper : ITestPaper
string SubjectName

string TestPaperName

List<IQuestion> Questions



class Question : IQuestion
string QuestionText

List<IOption> Options

char CorrectAnswerLetter

char OptionSelectedByStudent

int MarksSecured

class Option : IOption
char OptionLetter

string OptionText



class Student : IStudent
int RollNo

string StudentName

List<ITestPaper> TestPapers

