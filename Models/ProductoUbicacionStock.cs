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
    /// Los distintos productos q estan dentro de este deposito y su correspondiente stock
    /// </summary>
    [Index("FechaModificacion", Name = "FechaModificacionIncAll")]
    [Index("CodigoId", Name = "IX_ProductoUbicacionStock_CodigoID")]
    [Index("FechaControlStock", Name = "IX_ProductoUbicacionStock_FechaControlStock")]
    [Index("FechaModificacion", Name = "IX_ProductoUbicacionStock_FechaModificacion")]
    [Index("PresentacionId", Name = "IX_ProductoUbicacionStock_PresentacionID")]
    [Index("ProductoUbicacionId", Name = "IX_ProductoUbicacionStock_ProductoUbicacionID")]
    public partial class ProductoUbicacionStock
    {
        /// <summary>
        /// Stock En cajas
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal StockActual { get; set; }
        /// <summary>
        /// Minimo de Existencia antes de Solicitar Reposicion
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal StockMinimo { get; set; }
        /// <summary>
        /// Punto de Compra
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal StockSugerido { get; set; }
        /// <summary>
        /// (VER) Lleba el stock de una Caja Abierta
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal StockUnidades { get; set; }
        /// <summary>
        /// Fecha desde la que se realiza el control de stock de este producto en el deposito
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaControlStock { get; set; }
        /// <summary>
        /// Codigo Producto
        /// </summary>
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        /// <summary>
        /// Indica cual es El tipo de Presentacion de las unidades que contiene en caso de contener
        /// </summary>
        [Column("PresentacionID")]
        public short? PresentacionId { get; set; }
        /// <summary>
        /// Codigo Q determina la Ubicacion de un Producto en el Deposito
        /// </summary>
        [Column("ProductoUbicacionID")]
        public int? ProductoUbicacionId { get; set; }
        /// <summary>
        /// Indica que % de stock actual debe tener en base al stock sugerido (No utiliz stock Minimo)
        /// </summary>
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? PorcentajeCovertura { get; set; }
        /// <summary>
        /// Indica si esta 1- habilitado o no 0-Inhabilitado 4-Suspendido
        /// </summary>
        public byte? Estado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaModificacion { get; set; }
        public short? Orden { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInventario { get; set; }

        [ForeignKey("CodigoId")]
        [InverseProperty("ProductoUbicacionStock")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("PresentacionId")]
        [InverseProperty("ProductoUbicacionStock")]
        public virtual ProductoPresentacionTipo Presentacion { get; set; }
        [ForeignKey("ProductoUbicacionId")]
        [InverseProperty("ProductoUbicacionStock")]
        public virtual ProductoUbicacion ProductoUbicacion { get; set; }
    }
}