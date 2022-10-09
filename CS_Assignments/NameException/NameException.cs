using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.NameException
{
    public class NameException : Exception
    {
        public NameException(string msg) : base(msg) { }
    }
    public class User
    {
        private string name;
        public User(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Name is required");
            }
            else
            {
                this.name = name;
            }
        }
        public string Print()
        {
            return "Hello " + name;
        }
    }
    public class Hello
    {
        public static void Main(string[] args)
        {
            try
            {
                User u = new User(null);
                Console.WriteLine(u.Print());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
