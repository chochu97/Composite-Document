using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeConsole
{
    public abstract class Componente
    {
        string _nombre;

        public Componente(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre { get { return _nombre; } }
        public abstract void AgregarHijo(Componente comp);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerTamaño { get; }


    }
}
