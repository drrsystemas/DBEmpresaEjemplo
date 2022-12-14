// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionItemProdPedidoCompraOperacionItemProdCompra
    {
        /// <summary>
        /// Item Unico
        /// </summary>
        [Column("ItemIDPedido")]
        public int ItemIdpedido { get; set; }
        /// <summary>
        /// Item Unico
        /// </summary>
        [Column("ItemIDCompra")]
        public int ItemIdcompra { get; set; }
        [Key]
        public int Registro { get; set; }
        /// <summary>
        /// Cantidad, Puede estar expresado hasta con 4 decimales
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal Cantidad { get; set; }

        [ForeignKey("ItemIdcompra")]
        [InverseProperty("OperacionItemProdPedidoCompraOperacionItemProdCompraItemIdcompraNavigation")]
        public virtual OperacionItemProducto ItemIdcompraNavigation { get; set; }
        [ForeignKey("ItemIdpedido")]
        [InverseProperty("OperacionItemProdPedidoCompraOperacionItemProdCompraItemIdpedidoNavigation")]
        public virtual OperacionItemProducto ItemIdpedidoNavigation { get; set; }
    }
}