using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMethod
{
    class ShowOut
    {
        public void Show(out int intVal)
        {
           int square = 5;

           intVal = square;

            intVal *= intVal;
                        
        }
    }
}
