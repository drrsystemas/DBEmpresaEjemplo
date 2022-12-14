// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("AlmaUserId", Name = "IX_TransportePasLiquidacion_AlmaUserID")]
    [Index("ComprobanteId", Name = "IX_TransportePasLiquidacion_ComprobanteID")]
    [Index("ConductorId", Name = "IX_TransportePasLiquidacion_ConductorID")]
    [Index("FechaDesde", Name = "IX_TransportePasLiquidacion_FechaDesde")]
    [Index("FechaHasta", Name = "IX_TransportePasLiquidacion_FechaHasta")]
    [Index("PlanillaNro", Name = "IX_TransportePasLiquidacion_PlanillaNro")]
    public partial class TransportePasLiquidacion
    {
        public TransportePasLiquidacion()
        {
            TransportePasLiquidacionDesglose = new HashSet<TransportePasLiquidacionDesglose>();
            TransportePasLiquidacionPlanilla = new HashSet<TransportePasLiquidacionPlanilla>();
            TransportePasRecorrido = new HashSet<TransportePasRecorrido>();
        }

        /// <summary>
        /// Nro Liquidacion 
        /// </summary>
        [Key]
        [Column("LiquidacionID")]
        public int LiquidacionId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaDesde { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaHasta { get; set; }
        [Required]
        [Unicode(false)]
        public string Observaciones { get; set; }
        [Column("ConductorID")]
        public int ConductorId { get; set; }
        public int PlanillaNro { get; set; }
        [Column(TypeName = "money")]
        public decimal? EfectivoAdicional { get; set; }
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        [Column("FechaYHora", TypeName = "datetime")]
        public DateTime FechaYhora { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        public int? NroComprobante { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("TransportePasLiquidacion")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("ConductorId")]
        [InverseProperty("TransportePasLiquidacion")]
        public virtual TransporteConductor Conductor { get; set; }
        [InverseProperty("Liquidacion")]
        public virtual ICollection<TransportePasLiquidacionDesglose> TransportePasLiquidacionDesglose { get; set; }
        [InverseProperty("Liquidacion")]
        public virtual ICollection<TransportePasLiquidacionPlanilla> TransportePasLiquidacionPlanilla { get; set; }
        [InverseProperty("Liquidacion")]
        public virtual ICollection<TransportePasRecorrido> TransportePasRecorrido { get; set; }
    }
}