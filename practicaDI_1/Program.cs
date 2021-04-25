using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practicaDI_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string msj;
            string typeName = "practicaDI_1.Saludo";
            if (typeName == "practicaDI_1.Despedida")
                msj = "Adios joey";
            else
                msj = "hola joey";
            Type type = Type.GetType(typeName, throwOnError: true);
            ILeer writer = (ILeer)Activator.CreateInstance(type);

            Dialogo d = new Dialogo(writer);
            Console.WriteLine(d.Dialogar(msj));
            Console.ReadLine();
        }
    }
}
