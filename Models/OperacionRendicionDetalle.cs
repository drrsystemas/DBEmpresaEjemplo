// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_OperacionRendicionDetalle")]
    [Index("RendicionId", Name = "IX_OperacionRendicionDetalle_RendicionID")]
    [Index("TipoOperacionId", Name = "IX_OperacionRendicionDetalle_TipoOperacionID")]
    [Index("RendicionId", Name = "RendicionIDIncRegistroOperacionIDTipoOperacionID")]
    public partial class OperacionRendicionDetalle
    {
        [Key]
        [Column("RendicionDetalleID")]
        public int RendicionDetalleId { get; set; }
        /// <summary>
        /// Nro Reparto Planilla de Carga
        /// </summary>
        [Column("RendicionID")]
        public int RendicionId { get; set; }
        /// <summary>
        /// De AlmaNet.OperacionTipo - Indica si se trata de una Venta, Compra, Pago, Cobro
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// El Nro de Venta, Compra, Pago, Cobro que Genero el detalle
        /// </summary>
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }

        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionRendicionDetalle")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionRendicionDetalle")]
        public virtual OperacionPago OperacionPago { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionRendicionDetalle")]
        public virtual OperacionValeContra OperacionValeContra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionRendicionDetalle")]
        public virtual OperacionVenta OperacionVenta { get; set; }
        [ForeignKey("RendicionId")]
        [InverseProperty("OperacionRendicionDetalle")]
        public virtual OperacionRendicion Rendicion { get; set; }
    }
}