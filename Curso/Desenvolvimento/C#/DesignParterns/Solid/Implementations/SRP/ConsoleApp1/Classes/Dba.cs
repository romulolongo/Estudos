using SPR.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPR.Classes
{
    public class Dba : Cargo
    {
        public Dba(ICalculoSalario calculo)
            :base(calculo)
        {

        }
    }
}
