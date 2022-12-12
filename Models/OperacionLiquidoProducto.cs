﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionLiquidoProducto
    {
        public OperacionLiquidoProducto()
        {
            OperacionRecepcionItemVentaItem = new HashSet<OperacionRecepcionItemVentaItem>();
        }

        [Key]
        [Column("LiquidoProductoID")]
        public int LiquidoProductoId { get; set; }
        /// <summary>
        /// Fecha y hora de la Recepcion
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        [Column("TalonarioID")]
        public short TalonarioId { get; set; }
        public int NroComprobante { get; set; }
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHasta { get; set; }
        public int? PuntoVentaRepresentado { get; set; }
        /// <summary>
        /// Diferencia entre Precio de RecepcionItem y de Precio Venta (neto)
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImporteComision { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalCompra { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalVenta { get; set; }
        [Column("ProveedorID")]
        public int? ProveedorId { get; set; }
        /// <summary>
        /// Nro de Sucursal de la Empresa q realizo la venta
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        /// <summary>
        /// 110-Liquido Porducto
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Sector que realizo la Venta
        /// </summary>
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("TipoOperacionIDCompra")]
        public byte? TipoOperacionIdcompra { get; set; }
        /// <summary>
        /// Nro de Compra
        /// </summary>
        [Column("CompraID")]
        public int? CompraId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OperacionLiquidoProducto")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("TipoOperacionIdcompra,CompraId")]
        [InverseProperty("OperacionLiquidoProducto")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("ProveedorId")]
        [InverseProperty("OperacionLiquidoProducto")]
        public virtual Proveedor Proveedor { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OperacionLiquidoProducto")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("OperacionLiquidoProducto")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("LiquidoProducto")]
        public virtual ICollection<OperacionRecepcionItemVentaItem> OperacionRecepcionItemVentaItem { get; set; }
    }
}