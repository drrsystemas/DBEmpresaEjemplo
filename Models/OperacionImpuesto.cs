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
    /// Inidico si l impuesto fue modificado (Manual)
    /// </summary>
    [Index("ImpuestoId", Name = "IX_OperacionImpuesto_ImpuestoID")]
    [Index("RegistroOperacionId", Name = "IX_OperacionImpuesto_RegistroOperacionID")]
    [Index("TipoOperacionId", Name = "IX_OperacionImpuesto_TipoOperacionID")]
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_OperacionImpuesto_TipoOperacionIDRegistroOperacionID")]
    [Index("TipoOperacionId", "ImpuestoId", Name = "OperacionImpuesto_TipoOeracionIDImpuestoID")]
    [Index("TipoOperacionId", "ImpuestoId", Name = "OperacionImpuesto_TipoOperImpuesto")]
    public partial class OperacionImpuesto
    {
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        [Column("ImpuestoID")]
        public short ImpuestoId { get; set; }
        [Column(TypeName = "money")]
        public decimal BaseImponible { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteImpuesto { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? PorcImpuesto { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        /// <summary>
        /// Indica si el impuesto por defecto esta modificado 0-No esta modificado 1-Esta modificado  2- Indica que no aplica el impuesto
        /// </summary>
        public byte EstaModificado { get; set; }

        [ForeignKey("ImpuestoId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual Impuesto Impuesto { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual OperacionPago OperacionPago { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual OperacionPedidoCompra OperacionPedidoCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual OperacionPedidoVenta OperacionPedidoVenta { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual OperacionVenta OperacionVenta { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImpuesto")]
        public virtual OrdenServicio OrdenServicio { get; set; }
    }
}