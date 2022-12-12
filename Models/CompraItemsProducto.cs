namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class CompraItemsProducto
    {
        public int CompraId { get; set; }
        public short NroItem { get; set; }
        public int ItemId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal CostoUnidad { get; set; }
        public decimal? ImporteSinImpuestos { get; set; }
        public decimal? TotalCosto { get; set; }
        public decimal? Utilidad { get; set; }
        public decimal ImporteImpuestos { get; set; }
        public decimal TotalItem { get; set; }
        public short PresentacionId { get; set; }
        public string PresentacionProducto { get; set; }
        public decimal UnidadesContiene { get; set; }
        public int CodigoId { get; set; }
        public int? Filer { get; set; }
        public decimal? CantidadPiezas { get; set; }
        public decimal? CantidadUnidaMedida { get; set; }
        public string RegOpercionIdunique { get; set; }
    }
}
