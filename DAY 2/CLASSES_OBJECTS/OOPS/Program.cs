using System;

namespace OOPS;

class student
{
    private int rollNo;
    private string name;
    private int mark;

    public int Mark{
        get { return mark; }
        set { mark = value; }
        }
    public int RollNo
    {
        get { return rollNo; }
        set { rollNo=value; }
    }
    public string Name
    {
        get { return name; }
        set {   name=value; }
    }

    public void printdetails()
    {
        Console.WriteLine( $"Roll no:{RollNo}, Name:{Name}, Marks:{Mark}");

    }


    class program
    {
        static void Main()
        {
            student s1 = new student();
            student s2 = new student();

            s2.RollNo = 21;
            s2.Name = "Rutuja";
            s2.Mark = 35;

            s1.RollNo = 1;
            s1.Name = "Alok";
            s1.Mark = 99;

            s1.printdetails();
            s2.printdetails();

            Console.ReadLine();
        }
    }
}



