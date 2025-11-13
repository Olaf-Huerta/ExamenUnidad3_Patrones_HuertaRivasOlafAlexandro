using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaDecoCompo
{
    public abstract class DocumentoDecorador : IComponenteDocumento
    {
        protected IComponenteDocumento _componenteEnvuelto; 

        public DocumentoDecorador(IComponenteDocumento componente)
        {
            _componenteEnvuelto = componente;
        }

    
        public virtual string GenerarDescripcion() => _componenteEnvuelto.GenerarDescripcion();
    }

    public class TituloDecorator : DocumentoDecorador
    {
        public TituloDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Título Principal\n";
    }

    public class PieDePaginaDecorator : DocumentoDecorador
    {
        public PieDePaginaDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Pie de Página (info contacto)\n";
    }

    public class FotoDecorator : DocumentoDecorador
    {
        public FotoDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Espacio para Foto de Perfil\n";
    }
    public class ResumenDecorator : DocumentoDecorador
    {
        public ResumenDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Sección de Resumen Profesional\n";
    }

    public class DatosFiscalesDecorator : DocumentoDecorador
    {
        public DatosFiscalesDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Encabezado\n";
    }
    public class DesgloseImpuestosDecorator : DocumentoDecorador
    {
        public DesgloseImpuestosDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Información de Impuestos\n";
    }

    public class SelloDigitalDecorator : DocumentoDecorador
    {
        public SelloDigitalDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Sello Digital\n";
    }

    public class GraficosDecorator : DocumentoDecorador
    {
        public GraficosDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Gráficos e imágenes de fondo\n";
    }
    public class DobleCaraDecorator : DocumentoDecorador
    {
        public DobleCaraDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Diseño a Doble Cara\n";
    }

    public class BordeEleganteDecorator : DocumentoDecorador
    {
        public BordeEleganteDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Borde elegante y Sello de Agua\n";
    }
    public class FirmaAutorizadaDecorator : DocumentoDecorador
    {
        public FirmaAutorizadaDecorator(IComponenteDocumento c) : base(c) { }
        public override string GenerarDescripcion() =>
            _componenteEnvuelto.GenerarDescripcion() + "- Espacio para Firma Autorizada\n";
    }
}
