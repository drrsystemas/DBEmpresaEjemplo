// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProductoComboItemOpcion
    {
        [Column("ComboItemID")]
        public int ComboItemId { get; set; }
        /// <summary>
        /// Presentacion Producto0
        /// </summary>
        [Column("PresentacionID")]
        public short PresentacionId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        [Key]
        [Column("ComboOpcionItemID")]
        public int ComboOpcionItemId { get; set; }

        [ForeignKey("CodigoId")]
        [InverseProperty("ProductoComboItemOpcion")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("ComboItemId")]
        [InverseProperty("ProductoComboItemOpcion")]
        public virtual ProductoComboItem ComboItem { get; set; }
        [ForeignKey("PresentacionId")]
        [InverseProperty("ProductoComboItemOpcion")]
        public virtual ProductoPresentacionTipo Presentacion { get; set; }
    }
}