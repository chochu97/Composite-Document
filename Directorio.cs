using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeConsole
{
    public class Directorio : Componente
    {
        private List<Componente> _hijos;

        public Directorio(string nombre) : base(nombre)
        {
            _hijos = new List<Componente>();
        }

        public override int ObtenerTamaño
        {
            get
            {
                int t = 0;

                foreach( var item in _hijos)
                {
                    t += item.ObtenerTamaño;
                }

                return t;
            }
        }

        public override void AgregarHijo(Componente comp)
        {
            _hijos.Add(comp);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _hijos.ToArray();
        }
    }
}
