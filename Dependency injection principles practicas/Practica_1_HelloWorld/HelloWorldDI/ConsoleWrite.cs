using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDI
{
    public class ConsoleWrite : IMessageWriter
    {
        public void Write(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
