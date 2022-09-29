using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Date d1 = new Date();
            //Console.WriteLine("enter the date");
            //int d = Convert.ToInt32(Console.ReadLine());
            //string m = Console.ReadLine();
            //int y = Convert.ToInt32(Console.ReadLine());
            //d1.AddValues(d, m, y);
            //Console.WriteLine(d1.GetValues());
            //Date d2 = new Date();
            //d2.AddValues(10, "may", 2022);
            //Console.WriteLine(d2.GetValues());



            //Student s1=new Student();

            //Console.WriteLine("enter the rollno and name");
            // int  r=Convert.ToInt32(Console.ReadLine());
            //string n=Console.ReadLine();
            //Console.WriteLine("enter 3 subject mark");
            //int m1=Convert.ToInt32(Console.ReadLine()); 
            //int m2=Convert.ToInt32(Console.ReadLine()); 
            //int m3=Convert.ToInt32(Console.ReadLine());

            //s1.GetValues(r, n);
            //s1.Caluculate(m1, m2, m3 );

            //    Console.WriteLine(s1.ShowValues());




            //Employee e1 = new Employee();
            //Console.WriteLine("enter the id ");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the name");
            //string n = Console.ReadLine();
            //Console.WriteLine("enter the salary");
            //int s = Convert.ToInt32(Console.ReadLine());
            //e1.GetValues(d, n, s);
            //Console.WriteLine(e1.ShowValues());




           Course c1 = new Course();
            Console.WriteLine("enter the id ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the coursw name");
            string n = Console.ReadLine();
            Console.WriteLine("enter the fee");
            int s = Convert.ToInt32(Console.ReadLine());
            c1.GetValues(c, n, s);
            Console.WriteLine(c1.ShowValues());
            Course c2 = new Course();
            c2.GetValues(2,"c++",7000);
            Console.WriteLine(c2.ShowValues());
            Course c3=new Course();
            c3.GetValues(3, "java", 90000);
            Console.WriteLine(c3.ShowValues()); 

        }
    }
}
