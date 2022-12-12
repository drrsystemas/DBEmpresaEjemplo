using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProveedorView
    {
        public int ProveedorId { get; set; }
        public string ProveedorIdrazonSocial { get; set; }
        public string RazonSocial { get; set; }
        public string CategoriaImpuesto { get; set; }
        public byte TipoNroIdentificacion { get; set; }
        public long NroIdentificacion { get; set; }
        public bool Inhabilitado { get; set; }
        public int? ClasificacionId { get; set; }
        public string ClasifacionProveedorDescripcion { get; set; }
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
        public string SucursalDelProveedor { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
    }
}
