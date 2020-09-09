using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyTask
{
    class ZeroException
    {
        static void Main(string[] args)
        {
            Task t = new Task();
            try
            {
                t.task();
            }
            catch(ZeroInputException e)
            {
                Console.WriteLine("ZeroInputException : {0}", e.Message);
                t.task();

            }
            Console.ReadKey();

        }
    }

    public class ZeroInputException : Exception
    {
        public ZeroInputException(string message) : base(message)
        {
        }
    }
    public class Task
    {
        
       public void task()
        {
            double a, b;
            Console.WriteLine("Enter two values");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            if(a==0 || b==0)
            {
                throw (new ZeroInputException("Zero input found"));
            }
            else
            {
                Console.WriteLine("The sum of the input values is : {0}" ,(a+b));
                Console.WriteLine("The prodduct of the input values is : {0}", (a*b));
                Console.WriteLine("The difference of the input values is : {0}", (a-b));
                Console.WriteLine("The division of the input values is : {0}", (a/b));
            }
        }

    }
}
