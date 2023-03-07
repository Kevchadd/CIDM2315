class student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public void setGrade(double newGrade){
        studentGrade=newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
    public void PrintStudentinfo(){
    Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
    }
 
    }



class Professor{
    public string profName;
    public string classTeach;
    private double salary;
    public void SetSalary(double salary_amount){
        salary=salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
    public void PrintProfInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach} and the salary is: {salary}");
    }
   
}


class Program
    { 
        static void Main(string[] args){
        
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.PrintProfInfo();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.PrintProfInfo();  

        
        student s1= new student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.setGrade(90);
        s1.PrintStudentinfo();

        student s2 = new student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.setGrade(80);
        s2.PrintStudentinfo();

       double diff1 = (p1.GetSalary()-p2.GetSalary());
       Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is : {diff1} ");

       double diff2 = ( s1.GetGrade()+s2.GetGrade());
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {diff2} ");
        }


    }

        
    
