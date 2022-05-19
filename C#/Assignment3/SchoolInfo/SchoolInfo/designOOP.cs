using System;

namespace Assignment3

{
    public class designOOP
    {

    }
    public abstract class Person
    {
        public string name{get; set;}
        public DateTime birthdate{get; set;}
        public string[] addresses{get; set;}
        public abstract int CalculateAge();
        public abstract decimal CalcalateSalary();

    }
    public class Student: Person
    {
        public string[] courses{get; set;}

        public char[] grade {get;set;}
         public override int CalculateAge()
         {
            return DateTime.Now.Year - birthdate.Year;
         }
         public override decimal CalcalateSalary()
         {
           return 0;
         }
         public float CalculateGPA()
         {
             float gpa = 0;
             return gpa;
         }


    }
    public class Instructor:Person
    {
        public string department{get; set;}
        
        public DateTime joinDate{get; set;}
        public decimal bonus;
       
        public override int CalculateAge()
         {
            return DateTime.Now.Year - birthdate.Year;
         }
         public override decimal CalcalateSalary()
         {
           return this.Yearexperience() * bonus;
         }
         public int Yearexperience()
         {
             return DateTime.Now.Year - joinDate.Year;
         }
          public decimal GetBonus()
         {
            if( this.Yearexperience() >5)
                bonus = 30;
            return bonus;
         }
    }

    struct Courses
    {
        string[] studentName;
        string courseName;
        string InstructorName;
    }

     struct Department
    {
    
        string[] Courses;
        string[] InstructorName;

        string DirectorName;
        DateTime StartTime;
        DateTime EndTime;

    }
}