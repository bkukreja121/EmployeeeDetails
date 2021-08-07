using System;

namespace EmployeeWageComputationProblem
{
    class Program
    {
        public int Wage_Per_Hour = 20;
        static void Main(string[] args)
        {
            int Wage_hourly = 30;
            Random random = new Random();
            int day = random.Next(0, 2);

            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION\n");

            EmployeeWageDescription employeeSalary = new EmployeeWageDescription();
            employeeSalary.Presenty();
            employeeSalary.Salary();


        }

    }

}