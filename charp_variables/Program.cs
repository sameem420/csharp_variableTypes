using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charp_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining string type variable
            String name = "Sameem";
            // defining int type variable
            int age = 21;
            // defining char type variable
            char grade = 'A';
            // defining float pecision type variable
            float average = 75.4f;
            // defining double precisio type variable
            double total = 91.3333d;
            // defining var type variable. This does not have any specific data-type So we can store any type of value in it
            var testVar = "Sam";

            Console.WriteLine("My Name is : {0}", name);
            Console.WriteLine("My Age is : {0}", age);
            Console.WriteLine("My Grade is : {0}", grade);
            Console.WriteLine("My Average is : {0}", average);
            Console.WriteLine("My Total is : {0}", total);
            Console.WriteLine("My Name is : {0}", testVar);
            Console.Read();
        }
    }
}
