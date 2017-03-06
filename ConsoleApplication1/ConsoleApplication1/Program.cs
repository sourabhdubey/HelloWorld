using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
       public static void HelloWorld()
        {
            Console.WriteLine("Hello world!!!");
        }
    }
    class Program1
    {
        public static void Main()
        {

            Program p = new Program();
            Program.HelloWorld();
        }
    }
}
