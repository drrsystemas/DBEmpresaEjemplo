// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Permite indicar relaciones entre Operaciones, Ejem. Ventas, Notas de Credito , Venta Pedido, etc
    /// </summary>
    [Index("TipoOperacionId", Name = "IX_OperacionRelacionOperacion")]
    [Index("TipoOperacionId", "TipoOperacionRelacId", "OperacionRelacId", Name = "IX_OperacionRelacionOperacion2")]
    [Index("EsDelServidor", Name = "IX_OperacionRelacionOperacion_1")]
    [Index("TerminalId", Name = "IX_OperacionRelacionOperacion_2")]
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_OperacionRelacionOperacion_3")]
    [Index("TipoOperacionId", "TipoOperacionRelacId", Name = "OperacionRelacionOperacionTipoOperNroRealc")]
    public partial class OperacionRelacionOperacion
    {
        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros) de AlmaNET.OperacionTipo
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Nro Operacion Principal
        /// </summary>
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        [Column("TipoOperacionRelacID")]
        public byte TipoOperacionRelacId { get; set; }
        [Column("OperacionRelacID")]
        public int OperacionRelacId { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        /// <summary>
        /// Detalle adicional
        /// </summary>
        [StringLength(150)]
        [Unicode(false)]
        public string Detalle { get; set; }
        public bool? EsDelServidor { get; set; }
        [Column("TerminalID")]
        public short? TerminalId { get; set; }
        [Column("OperacionRelacIDTeminal")]
        public int? OperacionRelacIdteminal { get; set; }

        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionRelacionOperacionOperacionCobro")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionRelacId,OperacionRelacId")]
        [InverseProperty("OperacionRelacionOperacionOperacionCobroNavigation")]
        public virtual OperacionCobro OperacionCobroNavigation { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionRelacionOperacionOperacionCompra")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("TipoOperacionRelacId,OperacionRelacId")]
        [InverseProperty("OperacionRelacionOperacionOperacionCompraNavigation")]
        public virtual OperacionCompra OperacionCompraNavigation { get; set; }
        public virtual OperacionInventario OperacionInventario { get; set; }
        [ForeignKey("TipoOperacionRelacId,OperacionRelacId")]
        [InverseProperty("OperacionRelacionOperacion")]
        public virtual OperacionPedidoVenta OperacionPedidoVenta { get; set; }
        [ForeignKey("TipoOperacionRelacId,OperacionRelacId")]
        [InverseProperty("OperacionRelacionOperacion")]
        public virtual OperacionRecepcion OperacionRecepcion { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionRelacionOperacionOperacionVenta")]
        public virtual OperacionVenta OperacionVenta { get; set; }
        [ForeignKey("TipoOperacionRelacId,OperacionRelacId")]
        [InverseProperty("OperacionRelacionOperacionOperacionVentaNavigation")]
        public virtual OperacionVenta OperacionVentaNavigation { get; set; }
    }
}