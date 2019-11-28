using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Parallel.Invoke(
              () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void Print2()
        {
            Singleton b = Singleton.GetInstance();
            b.PrintDetail();
        }

        private static void Print1()
        {
            Singleton a = Singleton.GetInstance();
            a.PrintDetail();
        }
        private static void PrintTeacherDetails()
        {
            Eager_Loading fromTeacher = Eager_Loading.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Eager_Loading fromStudent = Eager_Loading.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
