namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class PlanCuentasView
    {
        public int CuentaId { get; set; }
        public string CuentaDescripcion { get; set; }
        public int CuentaTotalizId { get; set; }
        public string CuentaTotalizadora { get; set; }
        public byte TipoCuentaId { get; set; }
        public string CuentaTotalizTipo { get; set; }
        public string Orden { get; set; }
        public string CuentaTotalizadoraHierarchy { get; set; }
        public bool? EsImporteFijo { get; set; }
        public int? CentroCostoId { get; set; }
        public string CentroCostoDescripcion { get; set; }
        public bool? EsObligatorio { get; set; }
        public short? ClasificacionId { get; set; }
        public string CodigoAlfanumerico { get; set; }
        public string ClasificacionCuenta { get; set; }
        public long? CuentaOrdenI { get; set; }
        public long? CuentaTotalOrdenId { get; set; }
    }
}
