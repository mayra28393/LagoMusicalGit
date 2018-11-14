using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical.Clases
{
    public class Datos
    {
        private String sonido;
        private String estrofa;

        public string Sonido
        {
            get
            {
                return sonido;
            }

            set
            {
                sonido = value;
            }
        }

        public string Estrofa
        {
            get
            {
                return estrofa;
            }

            set
            {
                estrofa = value;
            }
        }
    }
}
