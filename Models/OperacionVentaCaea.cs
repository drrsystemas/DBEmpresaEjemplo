﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Table("OperacionVentaCAEA")]
    [Index("Caea", Name = "IX_OperacionVentaCAEA_CAEA")]
    [Index("SectorId", Name = "IX_OperacionVentaCAEA_SectorID")]
    public partial class OperacionVentaCaea
    {
        public OperacionVentaCaea()
        {
            OperacionVenta = new HashSet<OperacionVenta>();
        }

        [Key]
        [Column("CAEA_ID")]
        public int CaeaId { get; set; }
        [Required]
        [Column("CAEA")]
        [StringLength(50)]
        [Unicode(false)]
        public string Caea { get; set; }
        [Column("CAEAFechaVto", TypeName = "datetime")]
        public DateTime CaeafechaVto { get; set; }
        [Column("CAEAFechaSol", TypeName = "datetime")]
        public DateTime CaeafechaSol { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("ComprobanteID")]
        public short? ComprobanteId { get; set; }
        [Column("TalonarioID")]
        public short? TalonarioId { get; set; }
        [Column("CAEADesde")]
        public int? Caeadesde { get; set; }
        [Column("CAEAHasta")]
        public int? Caeahasta { get; set; }
        [Column("CAEAFechaDesde", TypeName = "datetime")]
        public DateTime? CaeafechaDesde { get; set; }
        [Column("CAEAFechaHasta", TypeName = "datetime")]
        public DateTime? CaeafechaHasta { get; set; }
        public byte? Quincena { get; set; }
        public int? Periodo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Informado { get; set; }

        [ForeignKey("SectorId")]
        [InverseProperty("OperacionVentaCaea")]
        public virtual Sector Sector { get; set; }
        [InverseProperty("Caea")]
        public virtual ICollection<OperacionVenta> OperacionVenta { get; set; }
    }
}