using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMethod
{
    class ShowRef
    {
        public void Show(ref int intVal)
        {
            intVal += 20;
        }
    }
}
