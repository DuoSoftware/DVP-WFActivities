using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP_CSharpAPI
{
    class Program
    {
        static void Main(string[] args)
        {

            DVP_Helper.@break breakx = new DVP_Helper.@break() { cause = "test", nexturl = "test", result = "result" };

            Console.WriteLine(breakx.ToString());

            Console.ReadLine();
        }
    }
}
