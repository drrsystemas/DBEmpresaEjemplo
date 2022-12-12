using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ClientesView
    {
        public int ClienteId { get; set; }
        public string ClienteIdrazonSocial { get; set; }
        public string RazonSocial { get; set; }
        public string CategoriaImpuesto { get; set; }
        public byte TipoNroIdentificacion { get; set; }
        public long NroIdentificacion { get; set; }
        public int? CanalId { get; set; }
        public string CanalDescripcion { get; set; }
        public bool Inhabilitado { get; set; }
        public int? ClasificacionId { get; set; }
        public string ClasifacionClienteDescripcion { get; set; }
        public int EntidadId { get; set; }
        public int? RutaId { get; set; }
        public string RutaEntidadSucursalDescripcion { get; set; }
        public int? ComercioId { get; set; }
        public string ComercioEmpresa { get; set; }
        public int? EntidadClasificacionId { get; set; }
        public string EntidadClasificacionDescripcion { get; set; }
        public short? TipoEmpresaId { get; set; }
        public int? PrincipalCodigoActividadId { get; set; }
        public DateTime FechaAlta { get; set; }
        public int? ZonaId { get; set; }
        public string ZonaDescripcion { get; set; }
        public string Domicilio { get; set; }
        public int? CiudadId { get; set; }
        public string VendedorDelCliente { get; set; }
        public string SucursalDelCliete { get; set; }
        public string FormaPagoVenta { get; set; }
    }
}
