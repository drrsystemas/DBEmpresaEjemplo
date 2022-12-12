﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Detalle Items de Planilla de Produccion 
    /// </summary>
    [Index("MaquinaId", Name = "IX_ProduccionPlanillaItem_MaquinaID")]
    [Index("OperadorId", Name = "IX_ProduccionPlanillaItem_OperadorID")]
    [Index("PlanillaProduccionId", Name = "IX_ProduccionPlanillaItem_PlanillaProduccionID")]
    public partial class ProduccionItem
    {
        [Column("PlanillaProduccionID")]
        public int PlanillaProduccionId { get; set; }
        [Column("ProgramacionItemID")]
        public int ProgramacionItemId { get; set; }
        [Column("MaquinaID")]
        public int? MaquinaId { get; set; }
        [Column("OperadorID")]
        public int? OperadorId { get; set; }
        [Column("TurnoProduccionID")]
        public int? TurnoProduccionId { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? CantidadIngreso { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? CantidadProcesada { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? CantidadPendiente { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? CantidadBaja { get; set; }
        [Key]
        [Column("PlanillaProduccionItemID")]
        public int PlanillaProduccionItemId { get; set; }
        /// <summary>
        /// Indica Cuando Comienzan la Produccion de este Item
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? InicioFechaHora { get; set; }
        /// <summary>
        /// Indica Cuando terminan la Produccion de este Item
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FinalFechaHora { get; set; }

        [ForeignKey("PlanillaProduccionId")]
        [InverseProperty("ProduccionItem")]
        public virtual Produccion PlanillaProduccion { get; set; }
        [ForeignKey("ProgramacionItemId")]
        [InverseProperty("ProduccionItem")]
        public virtual ProduccionProgramacionItem ProgramacionItem { get; set; }
    }
}