using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day12
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            return $"Department Details : {Id}  {Name}  {Location}";
        }
    }
}
