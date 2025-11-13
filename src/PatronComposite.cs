using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaDecoCompo
{
    public interface IComponenteDocumento
    {

        string GenerarDescripcion();
    }

    public class ElementoSimple : IComponenteDocumento
    {
        public ElementoSimple(string nombre) { }

        public string GenerarDescripcion() => string.Empty;
    }

    public class SeccionCompuesta : IComponenteDocumento
    {
        private List<IComponenteDocumento> _hijos = new List<IComponenteDocumento>();

        public SeccionCompuesta(string titulo) { }

        public void Agregar(IComponenteDocumento componente)
        {
            _hijos.Add(componente);
        }

 
        public string GenerarDescripcion()
        {
            string desc = string.Empty;
            foreach (var hijo in _hijos)
            {
                desc += hijo.GenerarDescripcion();
            }
            return desc;
        }
    }
}
