// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("EntidadSucId", "ImpuestoId", "ImpDesgId", Name = "IX_EntidadSucursalImpuesto", IsUnique = true)]
    [Index("EntidadSucId", Name = "IX_EntidadSucursalImpuesto_EntidadSucID")]
    [Index("ImpuestoId", Name = "IX_EntidadSucursalImpuesto_ImpuestoID")]
    public partial class EntidadSucursalImpuesto
    {
        [Column("ImpuestoID")]
        public short ImpuestoId { get; set; }
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        [Key]
        [Column("EntidadImpuestoID")]
        public int EntidadImpuestoId { get; set; }
        /// <summary>
        /// Para el caso de Percepciones de IVA en algunos casos son disitintos importes segun proveedor
        /// </summary>
        [Column(TypeName = "decimal(8, 3)")]
        public decimal? Porcentaje { get; set; }
        /// <summary>
        /// Fecha hasta la cual se ecuentra eximido de aplicar el impuesto a fecha posterior se aplica , null aplica
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? EximidoHastaFecha { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EximidoDesdeFecha { get; set; }
        /// <summary>
        /// Indico sub categoria del Impuesto (Ver retenciones, ganancia, IVA)
        /// </summary>
        [Column("ImpDesgID")]
        public byte? ImpDesgId { get; set; }
        /// <summary>
        /// Importe  del Impuesto (Es fijo y no refiere a un calculo)
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImporteDeducir { get; set; }
        [StringLength(15)]
        public string NroRegistro { get; set; }
        public short OperacionAplica { get; set; }
        public bool? EstaExento { get; set; }

        [ForeignKey("EntidadSucId")]
        [InverseProperty("EntidadSucursalImpuesto")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
        [ForeignKey("ImpuestoId")]
        [InverseProperty("EntidadSucursalImpuesto")]
        public virtual Impuesto Impuesto { get; set; }
    }
}