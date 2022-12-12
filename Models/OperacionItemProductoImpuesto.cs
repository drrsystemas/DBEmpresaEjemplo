﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ImpuestoId", Name = "IX_OperacionItemProductoImpuesto_ImpuestoID")]
    [Index("ItemId", Name = "IX_OperacionItemProductoImpuesto_ItemID")]
    public partial class OperacionItemProductoImpuesto
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("ImpuestoID")]
        public short ImpuestoId { get; set; }
        [Column(TypeName = "money")]
        public decimal BaseImponible { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteImpuesto { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? PorcImpuesto { get; set; }
        [Column("ItemID")]
        public int ItemId { get; set; }
        /// <summary>
        /// Indica la cantidad utilizada para el calcvulo de Impuesto ver ITC, Petrovalle
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImportUnitario { get; set; }
        /// <summary>
        /// Indica si el impuesto por defecto esta modificado 0-No esta modificado 1-Esta modificado  2- Indica que no aplica el impuesto
        /// </summary>
        public byte EstaModificado { get; set; }

        [ForeignKey("ImpuestoId")]
        [InverseProperty("OperacionItemProductoImpuesto")]
        public virtual Impuesto Impuesto { get; set; }
        [ForeignKey("ItemId")]
        [InverseProperty("OperacionItemProductoImpuesto")]
        public virtual OperacionItemProducto Item { get; set; }
    }
}