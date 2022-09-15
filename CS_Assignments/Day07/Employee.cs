using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day07
{
    public class Employee
    {
        private int empid,PT;
        private static int count = 0;
        private string emp_name;
        private double basic_salary, HRA, DA, PF, total_salary, net_salary;
        public Employee(string empname,double basic_salary,int PT)
        {
            count++;
            empid = count;
            this.emp_name = empname;
            this.basic_salary = basic_salary;
            this.PT = PT;
        }
        public void GetTotalSalary()
        {
            HRA = basic_salary * 40 / 100;
            DA = basic_salary * 20 / 100;

            total_salary = (basic_salary + (HRA + DA));
        }

        public static int DisplayCount()
        {
            return count;
        }

        public void NetSalary()
        {
            PF = basic_salary * 12 / 100;
            net_salary = total_salary - PF - PT;
        }

        public string DisplaySalaryDetails()
        {
            return $"Employee Name : {emp_name} \n Basic Salary : {basic_salary} \n" +
                $" HRA : {HRA} \n DA : {DA}\n Total Salary : {total_salary} " +
                $" \n PF : {PF} \n PT : {PT} \n Net Salary : {net_salary}";
        }
    }
}
