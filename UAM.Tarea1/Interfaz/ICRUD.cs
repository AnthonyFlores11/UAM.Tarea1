using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.Tarea1
{
   public interface ICRUD<T>
    {
        void Insertar(T Item);
        void Eliminar(int indice);

       T Buscar(int indice);
    }
}
