﻿using System;

namespace PrototypeDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Pranaya";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);

            //C0NTOH SALAH : 
            //Employee emp1 = new Employee();
            //emp1.Name = "Anurag";
            //emp1.Department = "IT";
            //Employee emp2 = emp1;
            //emp2.Name = "Pranaya";
            //Console.WriteLine("Emplpyee 1: ");
            //Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            //Console.WriteLine("Emplpyee 2: ");
            //Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            //Employee emp3 = new Employee();
            //emp3 = emp2;
            //emp3.Name = "test";
            //Console.WriteLine("Emplpyee 2: ");
            //Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            Console.Read();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

}
