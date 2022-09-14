using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day06
{
    public class Student
    {
        int roll_no;
        string name, city;
        int age;
        string branch;




        public void AcceptValue()
        {
            roll_no = 27;
            name = "Amit";
            city = "Ratnagiri";
            age = 24;
            branch = "Electrical";
        }

        public string DisplayValue()

        {
           // return $"Roll No is : {roll_no} Name is :{name} City is :{city} Age is : {age} Branch :{branch}";
            return $"Roll No is : {roll_no} \n Name is :{name} \n City is :{city} \n Age is : {age} \n Branch :{branch}";

        }
    }
}
