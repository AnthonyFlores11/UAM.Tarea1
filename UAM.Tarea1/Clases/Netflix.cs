using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.Tarea1
{
   public  class Netflix : Reproductores
    {
        private String _nombre;
        private int _id;

        public String Nombre { get; set; }
        public int ID { get; set; }

        public Netflix()
        {

        }
        public Netflix(string nombre, int id)
        {
            _nombre = nombre;
            _id = id;
        }
        public void PLAY()
        {
            Console.WriteLine("{0} - Play", _nombre, _id);
        }


        public void STOP()
        {
            Console.WriteLine("{0} - STOP", _nombre, _id);
        }

        public void FW()
        {
            Console.WriteLine("{0} - FW", _nombre, _id);
        }

        public void RW()
        {
            Console.WriteLine("{0} - RW", _nombre, _id);
        }

    }
}

