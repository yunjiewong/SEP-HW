using System;

namespace Assignment3

{
    public class designOOP
    {

    }
    public abstract class Person:IPersonService
    {
        public string name{get; set;}
        public DateTime birthdate{get; set;}
        public string[] addresses{get; set;}
        public abstract int CalculateAge();
        public abstract decimal CalcalateSalary();

    }
    interface IPersonService{
        
    }
    interface ICourseService{
       
    }
    interface IInstructorService{

    }
    interface IStudentService: IPersonService{

        
    }
    interface IDepartmentService:IPersonService{
        

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

    struct Courses: ICourseService
    {
        string[] studentName{set; get;}
        string courseName{set; get;}
        string InstructorName{set; get;}
    }

     struct Department:IDepartmentService
    {
    
        string[] Courses{set; get;}

        string DirectorName{set; get;}
        DateTime StartTime{set; get;}
        DateTime EndTime{set; get;}

    }
}