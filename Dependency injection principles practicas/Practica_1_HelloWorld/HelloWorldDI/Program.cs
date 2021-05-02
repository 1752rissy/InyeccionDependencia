using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter cw = new ConsoleWrite();
            Saludo saludo = new Saludo(cw);
            saludo.Exclaim();
            Console.ReadLine();
        }
    }
}
