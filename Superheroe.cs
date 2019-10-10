using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class Superheroe
    {
        public string Nombre { get; set; }
        public string Enemigo { get; set; }
        public string Foto { get; set; }
        public bool Vengador { get; set; }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string enemigo, string foto, bool vengador)
        {
            Nombre = nombre;
            Enemigo = enemigo;
            Foto = foto;
            Vengador = vengador;
        }

        public static Superheroe GetSample()
        {
            Superheroe heroe = new Superheroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Foto = "";
            heroe.Vengador = false;

            return heroe;
        }

    }
}
