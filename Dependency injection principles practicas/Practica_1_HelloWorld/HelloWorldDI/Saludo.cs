using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDI
{
    public class Saludo
    {
        private readonly IMessageWriter _writer;

        public Saludo(IMessageWriter writer)
        {
            //clausula de guardia
            if (writer == null)
                throw new ArgumentNullException("writer");
            this._writer = writer;
        }

        public void Exclaim()
        {
            this._writer.Write("Hola DI");
        }

    }
}
