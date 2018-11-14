using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical.Clases
{
    public class GeneraCancion : IGeneraCancion
    {
        Datos obj = new Datos();

        public void Cancion1(string sonido, List<string> s)
        {
            throw new NotImplementedException();
        }

        public void Cancion1(String sonido, List<Datos> s)
        {
            int i = 0;
            int f = 0;
            int pos = 0;
            String strf = "";
            foreach (var estrof in s)
            {
                i++;
                if (estrof.Sonido == sonido)
                {
                    pos = i;
                    strf = estrof.Estrofa;
                    break;
                }
                
            }

            foreach (var cn in s)
            {
                f++;
                if (cn.Sonido != sonido && cn.Estrofa == strf && f > i)
                {

                    Console.WriteLine(cn.Sonido);
                }
                
            }

           
        }

      

        public Boolean LlenarLista(out List<Datos> sound) {

            sound = new List<Datos>();

            try {

                sound.Add(new Datos() { Sonido = "brr", Estrofa = "E1" });
                sound.Add(new Datos() { Sonido = "fiu", Estrofa = "E1" });
                sound.Add(new Datos() { Sonido = "cric-cric", Estrofa = "E1" });
                sound.Add(new Datos() { Sonido = "brrah", Estrofa = "E1" });

                sound.Add(new Datos() { Sonido = "pep", Estrofa = "E2" });
                sound.Add(new Datos() { Sonido = "birip", Estrofa = "E2" });
                sound.Add(new Datos() { Sonido = "trri-trri", Estrofa = "E2" });
                sound.Add(new Datos() { Sonido = "croac", Estrofa = "E2" });

                sound.Add(new Datos() { Sonido = "bri-bri", Estrofa = "E3" });
                sound.Add(new Datos() { Sonido = "plop", Estrofa = "E3" });
                sound.Add(new Datos() { Sonido = "cric-cric", Estrofa = "E3" });
                sound.Add(new Datos() { Sonido = "brrah", Estrofa = "E3" });

                return true;
            } catch (Exception ex) { return false; }

            
        }


    }
}
