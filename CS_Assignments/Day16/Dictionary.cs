using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day16
{
    public class Dictionary
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(91, "IND");
            dictionary.Add(1, "USA");
            dictionary.Add(61, "AUS");
            dictionary.Add(33, "FRA");
            dictionary.Add(49, "GER");
            dictionary.Add(39, "ITA");
            foreach (KeyValuePair<int, string> val in dictionary)
            {
                Console.WriteLine($"{val.Key}   {val.Value}");
            }

            Console.WriteLine("-----------");
            dictionary.Remove(33);
            foreach (KeyValuePair<int, string> val in dictionary)
            {
                Console.WriteLine($"{val.Key}   {val.Value}");
            }

            dictionary.Clear();
            foreach (KeyValuePair<int, string> val in dictionary)
            {
                Console.WriteLine($"{val.Key}   {val.Value}");
            }


        }



    }
}
