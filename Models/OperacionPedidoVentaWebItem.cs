// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionPedidoVentaWebItem
    {
        public OperacionPedidoVentaWebItem()
        {
            OperacionItemProductoReservado = new HashSet<OperacionItemProductoReservado>();
        }

        [Key]
        [Column("ItemPedidoID")]
        public int ItemPedidoId { get; set; }
        [Column("PedidoID")]
        public int PedidoId { get; set; }
        [Column("PresentacionID")]
        public short PresentacionId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal Cantidad { get; set; }
        [Column(TypeName = "money")]
        public decimal PrecioUnidad { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Bonificacion { get; set; }
        public short NroItem { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalItem { get; set; }
        public int? Filer { get; set; }
        [Column("ListaPrecID")]
        public short? ListaPrecId { get; set; }
        [Column("ComboItemID")]
        public int? ComboItemId { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? PorImpuesto { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column("ProductoOfertaID")]
        public int? ProductoOfertaId { get; set; }

        [ForeignKey("CodigoId")]
        [InverseProperty("OperacionPedidoVentaWebItem")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("ComboItemId")]
        [InverseProperty("OperacionPedidoVentaWebItem")]
        public virtual ProductoComboItem ComboItem { get; set; }
        [ForeignKey("ListaPrecId")]
        [InverseProperty("OperacionPedidoVentaWebItem")]
        public virtual ProductoLista ListaPrec { get; set; }
        [ForeignKey("PedidoId")]
        [InverseProperty("OperacionPedidoVentaWebItem")]
        public virtual OperacionPedidoVentaWeb Pedido { get; set; }
        [ForeignKey("PresentacionId")]
        [InverseProperty("OperacionPedidoVentaWebItem")]
        public virtual ProductoPresentacionTipo Presentacion { get; set; }
        [ForeignKey("ProductoOfertaId")]
        [InverseProperty("OperacionPedidoVentaWebItem")]
        public virtual ProductoOferta ProductoOferta { get; set; }
        [InverseProperty("ItemPedido")]
        public virtual ICollection<OperacionItemProductoReservado> OperacionItemProductoReservado { get; set; }
    }
}