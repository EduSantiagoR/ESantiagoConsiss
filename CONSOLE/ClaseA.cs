using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE
{
    public class ClaseA : ClaseB, IInterfazA
    {
        public new string MetodoA()
        {
            return "Hola clase: A método: A - Termine mi prueba ";
        }
    }
}
