// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProductoComboActivacion
    {
        [Key]
        [Column("ComboActivacionID")]
        public int ComboActivacionId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PeriodoDesde { get; set; }
        [Column("ComboID")]
        public int ComboId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PeriodoHasta { get; set; }
        public int? StockDisponible { get; set; }
        /// <summary>
        /// Indica la cantidad vendida durante el periodo
        /// </summary>
        public int? CantidadVenta { get; set; }

        [ForeignKey("ComboId")]
        [InverseProperty("ProductoComboActivacion")]
        public virtual ProductoCombo Combo { get; set; }
    }
}