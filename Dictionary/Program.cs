using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("3", "Vikas");
            names.Add("1", "Upadhyay");
            names.Add("2", "Kumar");

            foreach(KeyValuePair<string, string>kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
                Console.ReadLine();
            }

        }
    }
}
