﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_ProductoPresentacionTipo_Descripcion")]
    [Index("Orden", Name = "IX_ProductoPresentacionTipo_Orden")]
    [Index("TipoPresentacionHierarchy", Name = "IX_ProductoPresentacionTipo_TipoPresentacionHierarchy")]
    public partial class ProductoPresentacionTipo
    {
        public ProductoPresentacionTipo()
        {
            DepositoMovimientoItem = new HashSet<DepositoMovimientoItem>();
            OperacionDespachoItem = new HashSet<OperacionDespachoItem>();
            OperacionInventarioProducto = new HashSet<OperacionInventarioProducto>();
            OperacionItemProducto = new HashSet<OperacionItemProducto>();
            OperacionItemProductoPedidoCompraReposicion = new HashSet<OperacionItemProductoPedidoCompraReposicion>();
            OperacionItemProductoReservado = new HashSet<OperacionItemProductoReservado>();
            OperacionPedidoVentaWebItem = new HashSet<OperacionPedidoVentaWebItem>();
            OperacionRecepcionItem = new HashSet<OperacionRecepcionItem>();
            ProductoBase = new HashSet<ProductoBase>();
            ProductoComboItem = new HashSet<ProductoComboItem>();
            ProductoComboItemOpcion = new HashSet<ProductoComboItemOpcion>();
            ProductoOfertaPresentacion = new HashSet<ProductoOferta>();
            ProductoOfertaPresentacionIdgratisNavigation = new HashSet<ProductoOferta>();
            ProductoPresentacion = new HashSet<ProductoPresentacion>();
            ProductoProveedorInventarioItems = new HashSet<ProductoProveedorInventarioItems>();
            ProductoUbicacionStock = new HashSet<ProductoUbicacionStock>();
            RepartoVentaDirecta = new HashSet<RepartoVentaDirecta>();
        }

        [Key]
        [Column("PresentacionID")]
        public short PresentacionId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// Las presentaciones posibles para Productos - Gerarquico 0- Indica que es Pricipal /Raiz
        /// Indica si este Tipo de Presentacion Contiene a Otros, Ejem. Las cajas contienen Botellas, Pero las botellas  no contienen a otros tipo de Presentacion
        /// </summary>
        [Column("PresentacionIDPadre")]
        public short PresentacionIdpadre { get; set; }
        /// <summary>
        /// Indica la Presentacion ruta completa ejem 1.1.2.1
        /// </summary>
        [StringLength(150)]
        [Unicode(false)]
        public string TipoPresentacionHierarchy { get; set; }
        /// <summary>
        /// Permite establecer el orden para presentar los registros
        /// </summary>
        [StringLength(200)]
        public string Orden { get; set; }
        /// <summary>
        /// En caso de q la utilidad este asignada por marcar, familia puedo indicar si para esta presentacion se tiene q realizar un ajuste
        /// </summary>
        [Column(TypeName = "decimal(9, 5)")]
        public decimal? AjusteUtilidad { get; set; }

        [InverseProperty("Presentacion")]
        public virtual ICollection<DepositoMovimientoItem> DepositoMovimientoItem { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<OperacionDespachoItem> OperacionDespachoItem { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<OperacionInventarioProducto> OperacionInventarioProducto { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<OperacionItemProducto> OperacionItemProducto { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<OperacionItemProductoPedidoCompraReposicion> OperacionItemProductoPedidoCompraReposicion { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<OperacionItemProductoReservado> OperacionItemProductoReservado { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<OperacionPedidoVentaWebItem> OperacionPedidoVentaWebItem { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<OperacionRecepcionItem> OperacionRecepcionItem { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<ProductoBase> ProductoBase { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<ProductoComboItem> ProductoComboItem { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<ProductoComboItemOpcion> ProductoComboItemOpcion { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<ProductoOferta> ProductoOfertaPresentacion { get; set; }
        [InverseProperty("PresentacionIdgratisNavigation")]
        public virtual ICollection<ProductoOferta> ProductoOfertaPresentacionIdgratisNavigation { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<ProductoPresentacion> ProductoPresentacion { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<ProductoProveedorInventarioItems> ProductoProveedorInventarioItems { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<ProductoUbicacionStock> ProductoUbicacionStock { get; set; }
        [InverseProperty("Presentacion")]
        public virtual ICollection<RepartoVentaDirecta> RepartoVentaDirecta { get; set; }
    }
}