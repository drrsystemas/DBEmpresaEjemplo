using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionPedidoVentaWeb
    {
        [NotMapped]
        public string Transporte_Nombre { get; set; }

        [NotMapped]
        public Int32 Transporte_Id { get; set; }
    }
}
