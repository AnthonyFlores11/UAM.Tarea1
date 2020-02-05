using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reproductores vhs = new VHS();
            Reproductores netflix = new Netflix();
            Reproductores dvd = new DVD();

            Lista lis = new Lista();
            lis.Insertar(vhs);
            lis.Insertar(new Netflix() { ID = 1, Nombre = "netflix" });
            lis.Insertar(new DVD ("dvd", 1));

            Console.WriteLine(lis.Buscar(0));

            //Casting encargado de validar lo que se busca en la lista para ver las propiedades
            var item = lis.Buscar(0);
            if(item is DVD)
            {
                Console.WriteLine(((DVD)item).ID);
            }
            


            Console.ReadKey();
        }
    }
}
