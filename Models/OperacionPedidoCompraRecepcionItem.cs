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
    /// Permite indicar  a que item de Pedido de Compra Corresponde la Recepcion
    /// </summary>
    [Index("ItemPedidoId", Name = "IX_OperacionPedidoCompraRecepcionItem_ItemPedidoID")]
    [Index("ItemRecepId", Name = "IX_OperacionPedidoCompraRecepcionItem_ItemRecepID")]
    public partial class OperacionPedidoCompraRecepcionItem
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("ItemRecepID")]
        public int ItemRecepId { get; set; }
        /// <summary>
        /// ESTA MAL (No utilizar)
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal Cantidad { get; set; }
        [Column("ItemPedidoID")]
        public int ItemPedidoId { get; set; }

        [ForeignKey("ItemPedidoId")]
        [InverseProperty("OperacionPedidoCompraRecepcionItem")]
        public virtual OperacionItemProducto ItemPedido { get; set; }
        [ForeignKey("ItemRecepId")]
        [InverseProperty("OperacionPedidoCompraRecepcionItem")]
        public virtual OperacionRecepcionItem ItemRecep { get; set; }
    }
}