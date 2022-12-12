using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProductosView
    {
        public int CodigoBaseId { get; set; }
        public string Producto { get; set; }
        public string ProductoAlma { get; set; }
        public string FamiliaRubro { get; set; }
        public string Familia { get; set; }
        public string Canasta { get; set; }
        public string ProveedorPricipal { get; set; }
        public bool ControlStock { get; set; }
        public string ClasificacionProducto { get; set; }
        public short? ProductoTipoId { get; set; }
        public string Marca { get; set; }
        public string MarcaTipo { get; set; }
        public string Manufactur { get; set; }
        public DateTime FechaAlta { get; set; }
        public short? PresentacionId { get; set; }
        public int? NroEnFamilia { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioCosto { get; set; }
        public decimal? PrecioGral { get; set; }
        public string CodigoBarra { get; set; }
        public short? DiasVencimiento { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? GarantiaDias { get; set; }
        public string Caracteristica1 { get; set; }
        public string DescCaract1 { get; set; }
        public string TipoCaracteristica1 { get; set; }
        public string Caracteristica2 { get; set; }
        public string DescCaract2 { get; set; }
        public string TipoCaracteristica2 { get; set; }
        public string Caracteristica3 { get; set; }
        public string DescCaract3 { get; set; }
        public string TipoCaracteristica3 { get; set; }
        public string CodigoAlfanum { get; set; }
        public string CodigoFabrica { get; set; }
        public int CodigoId { get; set; }
        public short? DefaultPresentacionCompraId { get; set; }
        public short? DefaultPresentacionVentaId { get; set; }
        public string DescripcionCorta { get; set; }
        public bool ProdInhabil { get; set; }
        public short? ListaPrecioUtilizar { get; set; }
        public string RubroCodigo { get; set; }
        public string DescripcionFamiliaCompleto { get; set; }
        public string FamiliaCompleto { get; set; }
        public int FamiliaNro { get; set; }
        public string FamiliaOrden { get; set; }
        public byte TipoFamiliaId { get; set; }
        public int? FamiliaId { get; set; }
        public decimal? IvaPorcentaje { get; set; }
        public int? CuentaId { get; set; }
        public int? CuentaIdcosto { get; set; }
        public int? CuentaIdstock { get; set; }
    }
}
