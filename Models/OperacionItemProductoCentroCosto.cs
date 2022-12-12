﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionItemProductoCentroCosto
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        /// <summary>
        /// Indica a que refiere mi centro de Costo (Viene de AlmaNET==&gt; CentroCostoTipo)
        /// </summary>
        [Column("TipoCentroCostoID")]
        public short? TipoCentroCostoId { get; set; }
        /// <summary>
        /// Indico el Codigo Vehiculo, o de Proyecto etc.
        /// </summary>
        [Column("CentroCostoID")]
        public int? CentroCostoId { get; set; }
        /// <summary>
        /// Item Unico del detalle
        /// </summary>
        [Column("ItemID")]
        public int ItemId { get; set; }
        [Column(TypeName = "money")]
        public decimal Importe { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? Cantidad { get; set; }

        [ForeignKey("CentroCostoId")]
        [InverseProperty("OperacionItemProductoCentroCosto")]
        public virtual PlanDeCuentaCentroCosto CentroCosto { get; set; }
        [ForeignKey("ItemId")]
        [InverseProperty("OperacionItemProductoCentroCosto")]
        public virtual OperacionItemProducto Item { get; set; }
    }
}