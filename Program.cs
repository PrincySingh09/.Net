﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Emp
    {
        public string FullName(string fname, string lname)
        {
            return fname = " " + lname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Console.WriteLine(emp.FullName("Princy", "Singh"));
            Console.WriteLine(emp.FullName(lname:"Princy",fname:"Singh"));
            Console.ReadKey();
        }
    }
}
