using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciorestaurant
{
    class Platillos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        private double _precio;
        public double Precio {

            get { return _precio; }
            set
            {
                if (value >= 50)
                {
                     _precio = value;
                }
                else
                {
                    throw new Exception("es menor de 50");
                }
            }
        }




    }
}
