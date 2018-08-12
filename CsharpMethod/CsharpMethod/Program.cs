using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShowOut so = new ShowOut();

            int outVal = 20;
            //Console.WriteLine("Value Before:{0}", outVal);

            so.Show(out outVal);                                //passes variable value by reference....
            Console.WriteLine("Value After: {0}", outVal);

            ShowRef sr = new ShowRef();

            int refVal = 10;
            //Console.WriteLine("New Value Before:{0}", newoutVal);

            sr.Show(ref refVal);                             //passes variable value by reference.
            Console.WriteLine("New Value After:{0}", refVal);
        }
                
    }
}
