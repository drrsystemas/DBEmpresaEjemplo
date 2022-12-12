﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("CuentaId", Name = "IX_OperacionAdelanto")]
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_OperacionAdelanto_TipoOperacionIDRegistroOperacionID")]
    public partial class OperacionAdelanto
    {
        public OperacionAdelanto()
        {
            OperacionAdelantoCancelacion = new HashSet<OperacionAdelantoCancelacion>();
        }

        [Key]
        [Column("AdelantoID")]
        public int AdelantoId { get; set; }
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteAdelanto { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Detalle { get; set; }
        public bool EsDeudor { get; set; }
        [Column(TypeName = "money")]
        public decimal? SaldoAdelanto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaOpAdelanto { get; set; }
        /// <summary>
        /// Codigo Unico De cuenta
        /// </summary>
        [Column("CuentaID")]
        public int? CuentaId { get; set; }

        [ForeignKey("RegistroOperacionId,TipoOperacionId")]
        [InverseProperty("OperacionAdelanto")]
        public virtual AutorizacionCompra AutorizacionCompra { get; set; }
        [ForeignKey("CuentaId")]
        [InverseProperty("OperacionAdelanto")]
        public virtual PlanDeCuenta Cuenta { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionAdelanto")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionAdelanto")]
        public virtual OperacionPago OperacionPago { get; set; }
        [InverseProperty("Adelanto")]
        public virtual ICollection<OperacionAdelantoCancelacion> OperacionAdelantoCancelacion { get; set; }
    }
}