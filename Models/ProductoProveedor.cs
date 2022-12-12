﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ProveedorId", "CodigoId", Name = "IX_ProductoProveedor", IsUnique = true)]
    [Index("ProveedorId", Name = "IX_ProductoProveedor_1")]
    [Index("ProveedorId", "CodigoProveedor", Name = "IX_ProductoProveedor_2")]
    [Index("CodigoId", "ProveedorId", Name = "IX_ProductoProveedor_3")]
    [Index("ItemId", Name = "IX_ProductoProveedor_ItemID")]
    public partial class ProductoProveedor
    {
        [Column("ProveedorID")]
        public int ProveedorId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        /// <summary>
        /// Es el codigo con el que me factura el Proveedor
        /// </summary>
        [StringLength(20)]
        [Unicode(false)]
        public string CodigoProveedor { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column(TypeName = "money")]
        public decimal? PrecioCompra { get; set; }
        [Column(TypeName = "money")]
        public decimal? PrecioCosto { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? CoeficienteCosto { get; set; }
        /// <summary>
        /// Indica la Fecha de la Ultima compra realizado a ese proveedor
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FechaUltimaCompra { get; set; }
        /// <summary>
        /// Indica la Ultima compra realizada 
        /// </summary>
        [Column("CompraID")]
        public int? CompraId { get; set; }
        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros)
        /// </summary>
        [Column("TipoOperacionID")]
        public byte? TipoOperacionId { get; set; }
        /// <summary>
        /// Indica datos prar poder realizar la compra de este producto al proveedor (Compra minima etc. Costo Adic. Flete )
        /// </summary>
        [StringLength(250)]
        [Unicode(false)]
        public string Detalle { get; set; }
        public bool? EsOferta { get; set; }
        /// <summary>
        /// Indico la cantidad q posee de Stock el Proveedor
        /// </summary>
        public short? StockProveed { get; set; }
        /// <summary>
        /// Item Unico del detalle de la Compra o Pedido q actualizo Costo
        /// </summary>
        [Column("ItemID")]
        public int? ItemId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? Bonificacion1 { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? Bonificacion2 { get; set; }
        public short? OrdenReresentada { get; set; }

        [ForeignKey("CodigoId")]
        [InverseProperty("ProductoProveedor")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("ItemId")]
        [InverseProperty("ProductoProveedor")]
        public virtual OperacionItemProducto Item { get; set; }
        [ForeignKey("TipoOperacionId,CompraId")]
        [InverseProperty("ProductoProveedor")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("TipoOperacionId,CompraId")]
        [InverseProperty("ProductoProveedor")]
        public virtual OperacionPedidoCompra OperacionPedidoCompra { get; set; }
        [ForeignKey("ProveedorId")]
        [InverseProperty("ProductoProveedor")]
        public virtual Proveedor Proveedor { get; set; }
    }
}