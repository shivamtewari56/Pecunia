﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            companyEntities companyEntities = new companyEntities();

            //List<Employee> employees = 
            //    companyEntities.Employees
            //    .Where(emp => emp.Details.EmpName == "Scott")
            //    .ToList();

            var employees =
                companyEntities.sp_searchemployees("s");

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.EmpID},{item.EmpName},{item.Salary}");
            }

            Console.ReadKey();
        }
    }
}
