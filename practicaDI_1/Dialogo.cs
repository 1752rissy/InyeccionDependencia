using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDI_1
{
    public class Dialogo
    {
        private ILeer _dialogar;
        public Dialogo(ILeer dialogo)
        {
            _dialogar = dialogo;
        }

        public string Dialogar(string mes)
        {
           return  _dialogar.Leer(mes);
        }
    }
}
