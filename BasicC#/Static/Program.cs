using System;

// ReSharper disable once InvalidXmlDocComment
/// <summary>
/// Static keywork can be applied on:Classes, Variables,Methods,Properties, Operators, Events,Constructors
/// Static keywork cannot be applied on: Indexes,Destructors,Type other than classes
/// You can use the members of a static class without creating an instance of that class
/// </summary>
namespace Static
{
    class Program
    {
        static void Main()
        {
            var student = new Student
            {
                FullName = "Bill Vo"
            };
            student.StudentInfo();
            // static
            StudentStatic.FullName = "Bill Vo Static";
            StudentStatic.StudentInfo();
        }
    }

    public class Student
    {
        public string Title = "Student: ";
        public string FullName { get; set; }
        public void StudentInfo() => Console.WriteLine($"{Title} {FullName}");
        
    }

    public static class StudentStatic
    {
        public static string Title = "Student: ";
        public static string FullName { get; set; }
        public static void StudentInfo() => Console.WriteLine($"{Title} {FullName}");

    }
}