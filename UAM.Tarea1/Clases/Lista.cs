using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.Tarea1
{
    public class Lista : ICRUD<Reproductores>
    {
        List<Reproductores> lista = new List<Reproductores>();

        public Reproductores Buscar(int indice)
        {
            return lista[indice];
        }

        public void Eliminar(int indice)
        {
            lista.RemoveAt(indice);
        }

        public void Insertar(Reproductores Item)
        {
            lista.Add(Item);
        }

    }
}
