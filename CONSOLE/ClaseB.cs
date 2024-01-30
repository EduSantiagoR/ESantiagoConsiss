using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE
{
    public class ClaseB : IInterfazA
    {
        public virtual string MetodoA()
        {
            return "Hola clase: B método: A";
        }
        public string MetodoB()
        {
            return "Hola clase: B método: B ";
        }
    }
}
