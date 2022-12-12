﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("CodigoId", Name = "IX_OperacionInventarioProducto_CodigoID")]
    [Index("InventarioId", Name = "IX_OperacionInventarioProducto_InventarioID")]
    [Index("ItemRecepId", Name = "IX_OperacionInventarioProducto_ItemRecepID")]
    [Index("PresentacionId", Name = "IX_OperacionInventarioProducto_PresentacionID")]
    public partial class OperacionInventarioProducto
    {
        public OperacionInventarioProducto()
        {
            OperacionInventarioProductoAdicional = new HashSet<OperacionInventarioProductoAdicional>();
            OperacionItemProductCtrlEnvase = new HashSet<OperacionItemProductCtrlEnvase>();
        }

        [Column("InventarioID")]
        public int InventarioId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal UnidadesContiene { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Cantidad { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        [Column("PresentacionID")]
        public short PresentacionId { get; set; }
        [StringLength(150)]
        public string DetalleProductoInventario { get; set; }
        [Key]
        [Column("RegInventProdID")]
        public int RegInventProdId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? StockActual { get; set; }
        /// <summary>
        /// Indico el item de la recepcion q se cargo para la correccion por diferencia Inventario (StockActual- Canidad)
        /// </summary>
        [Column("ItemRecepID")]
        public int? ItemRecepId { get; set; }
        /// <summary>
        /// indica el nro de Item del Detalle
        /// </summary>
        [StringLength(10)]
        public string NroItemDetalle { get; set; }
        [Column(TypeName = "money")]
        public decimal PrecioCosto { get; set; }

        [ForeignKey("CodigoId")]
        [InverseProperty("OperacionInventarioProducto")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("InventarioId")]
        [InverseProperty("OperacionInventarioProducto")]
        public virtual OperacionInventario Inventario { get; set; }
        [ForeignKey("ItemRecepId")]
        [InverseProperty("OperacionInventarioProducto")]
        public virtual OperacionRecepcionItem ItemRecep { get; set; }
        [ForeignKey("PresentacionId")]
        [InverseProperty("OperacionInventarioProducto")]
        public virtual ProductoPresentacionTipo Presentacion { get; set; }
        [InverseProperty("RegInventProd")]
        public virtual ICollection<OperacionInventarioProductoAdicional> OperacionInventarioProductoAdicional { get; set; }
        [InverseProperty("RegInventProd")]
        public virtual ICollection<OperacionItemProductCtrlEnvase> OperacionItemProductCtrlEnvase { get; set; }
    }
}