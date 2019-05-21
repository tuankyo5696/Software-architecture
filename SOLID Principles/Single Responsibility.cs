namespace  SRP
{
    public class Student{
        public int student_id {get;set;}
        public string student_name{get;set;}

         public bool addStudent(Student st){
                console.log('Student added');
                return true;
         }

         public void ReportStudent(Student st){
             console.log('Generate report Student');
         }
    
    }
   
}

// fix violation

namespace  SRP
{
    public class Student{
        public int student_id {get;set;}
        public string student_name{get;set;}

         public bool addStudent(Student st){
                console.log('Student added');
                return true;
         }

    }
    public class ReportGeneration{
        public void ReportStudent(Student st){
             console.log('Generate report Student');
         }
   
    }
}



