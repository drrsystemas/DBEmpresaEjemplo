﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ComprobanteId", Name = "IX_OperacionPedidoCompra_ComprobanteID")]
    [Index("DepositoId", Name = "IX_OperacionPedidoCompra_DepositoID")]
    [Index("NroComprobante", Name = "IX_OperacionPedidoCompra_NroComprobante")]
    [Index("ProveedorId", Name = "IX_OperacionPedidoCompra_ProveedorID")]
    [Index("SectorId", Name = "IX_OperacionPedidoCompra_SectorID")]
    [Index("TalonarioId", Name = "IX_OperacionPedidoCompra_TalonarioID")]
    [Index("TransporteId", Name = "IX_OperacionPedidoCompra_TransporteID")]
    public partial class OperacionPedidoCompra
    {
        public OperacionPedidoCompra()
        {
            OperacionArchivo = new HashSet<OperacionArchivo>();
            OperacionDescuento = new HashSet<OperacionDescuento>();
            OperacionDetallePago = new HashSet<OperacionDetallePago>();
            OperacionImpuesto = new HashSet<OperacionImpuesto>();
            OperacionItemProducto = new HashSet<OperacionItemProducto>();
            OperacionLeyenda = new HashSet<OperacionLeyenda>();
            OperacionTransporte = new HashSet<OperacionTransporte>();
            ProductoProveedor = new HashSet<ProductoProveedor>();
        }

        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros)
        /// </summary>
        [Key]
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Nro de Pedido Compra
        /// </summary>
        [Key]
        [Column("PedidoCompraID")]
        public int PedidoCompraId { get; set; }
        /// <summary>
        /// Codigo Proveedor
        /// </summary>
        [Column("ProveedorID")]
        public int? ProveedorId { get; set; }
        /// <summary>
        /// Fecha de la Factura
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaComprobante { get; set; }
        /// <summary>
        /// Categoria de Impuesto al q pertenece el proveedor
        /// </summary>
        [Column("CategoriaImpuestoID")]
        public byte CategoriaImpuestoId { get; set; }
        /// <summary>
        /// Tipo de comprobante a ser  utilizado para este pediodo
        /// </summary>
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        /// <summary>
        /// Nro de comprobante / Se repite por ComprobnateID y Nro de talonario
        /// </summary>
        public int NroComprobante { get; set; }
        /// <summary>
        /// Total Importes Sugeto a impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteRegistraImpuesto { get; set; }
        /// <summary>
        /// Total Importes que NO  esta sugeto a Impuesto
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteNoRegistraImpuesto { get; set; }
        /// <summary>
        /// Total Desuento Realizado
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteDescuento { get; set; }
        /// <summary>
        /// Total Importe Impuestos Suma de la Tabla OperacionImpuesto
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteImpuestos { get; set; }
        /// <summary>
        /// ImporteRegistraImpuesto+ImporteNoRegistraImpuesto
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }
        /// <summary>
        /// Importe Total PEDIDO Compra
        /// </summary>
        [Column(TypeName = "money")]
        public decimal TotalPedidoCompra { get; set; }
        /// <summary>
        /// Indica si el pago es deglosado (Tiene + de 1 forma de Pago)
        /// </summary>
        public bool EsPagoDetallar { get; set; }
        /// <summary>
        /// Importe total de bonificaciones realizadas en los distintos itemes de esta  Compra
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImpBonificacion { get; set; }
        /// <summary>
        /// Tipo Detalle que se viusliza por defecto en esta Compra
        /// </summary>
        public byte TipoDetalle { get; set; }
        /// <summary>
        /// Indica si se trata de Factura, Remito,Ticket
        /// </summary>
        [Column("FRT")]
        public byte Frt { get; set; }
        /// <summary>
        /// Sector en que se asento esta Compra
        /// </summary>
        [Column("SectorID")]
        public short? SectorId { get; set; }
        /// <summary>
        /// Fecha Imputacion Contable
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaImputacion { get; set; }
        /// <summary>
        /// Indica si Generaq Asiento
        /// </summary>
        public bool GeneraAsiento { get; set; }
        /// <summary>
        /// Transporte en que se eviara la compra
        /// </summary>
        [Column("TransporteID")]
        public int? TransporteId { get; set; }
        /// <summary>
        /// Nro de Sucursal de la Empresa en que se realizo la compra
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        /// <summary>
        /// Fecha Vencimiento o de Pago de la Factura de Comp[ra
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FechaEntrega { get; set; }
        /// <summary>
        /// Nro Talonario al que pertenece la Numeracion del comprobante
        /// </summary>
        [Column("TalonarioID")]
        public short TalonarioId { get; set; }
        /// <summary>
        /// Utilizado para almacenar Informacion de Sincronizacion
        /// </summary>
        public int? Filer { get; set; }
        /// <summary>
        /// Indico para que deposito se Hace la Reposicion o Pedidor
        /// </summary>
        [Column("DepositoID")]
        public short? DepositoId { get; set; }
        /// <summary>
        /// Indico a que Deposito voy a Realizar el Pedido (esto resulta util para el caso de reposicion, para un depsoito ver el stock q tiene el depsoito al que se va a Pedir)
        /// </summary>
        [Column("PedirDepositoID")]
        public short? PedirDepositoId { get; set; }
        public bool EsReposicion { get; set; }
        /// <summary>
        /// Codigo Proyecto
        /// </summary>
        [Column("ProyectoID")]
        public short? ProyectoId { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        /// <summary>
        /// Se indica cualquier detalle y/u observacion sobre esta operacion
        /// </summary>
        [Unicode(false)]
        public string Detalle { get; set; }
        /// <summary>
        /// 0-No tiene 10- Pendiente Facturacion 20-Facturado
        /// </summary>
        public byte? EstadoPedido { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OperacionPedidoCompra")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("DepositoId")]
        [InverseProperty("OperacionPedidoCompraDeposito")]
        public virtual Deposito Deposito { get; set; }
        [ForeignKey("PedirDepositoId")]
        [InverseProperty("OperacionPedidoCompraPedirDeposito")]
        public virtual Deposito PedirDeposito { get; set; }
        [ForeignKey("ProveedorId")]
        [InverseProperty("OperacionPedidoCompra")]
        public virtual Proveedor Proveedor { get; set; }
        [ForeignKey("ProyectoId")]
        [InverseProperty("OperacionPedidoCompra")]
        public virtual Proyecto Proyecto { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OperacionPedidoCompra")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("OperacionPedidoCompra")]
        public virtual Sucursal Sucursal { get; set; }
        [ForeignKey("TransporteId")]
        [InverseProperty("OperacionPedidoCompra")]
        public virtual Transporte Transporte { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual OperacionAltaModicacion OperacionAltaModicacion { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<OperacionArchivo> OperacionArchivo { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<OperacionDescuento> OperacionDescuento { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<OperacionDetallePago> OperacionDetallePago { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<OperacionImpuesto> OperacionImpuesto { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<OperacionItemProducto> OperacionItemProducto { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<OperacionLeyenda> OperacionLeyenda { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<OperacionTransporte> OperacionTransporte { get; set; }
        [InverseProperty("OperacionPedidoCompra")]
        public virtual ICollection<ProductoProveedor> ProductoProveedor { get; set; }
    }
}