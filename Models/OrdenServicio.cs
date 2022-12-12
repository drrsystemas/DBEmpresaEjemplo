﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("OrdenSerId", Name = "IX_OrdenServicio", IsUnique = true)]
    [Index("ClienteId", Name = "IX_OrdenServicio_ClienteID")]
    [Index("OsclasifId", Name = "IX_OrdenServicio_OSClasifID")]
    [Index("SectorId", Name = "IX_OrdenServicio_SectorID")]
    [Index("SucursalId", Name = "IX_OrdenServicio_SucursalID")]
    public partial class OrdenServicio
    {
        public OrdenServicio()
        {
            OperacionArchivo = new HashSet<OperacionArchivo>();
            OperacionComision = new HashSet<OperacionComision>();
            OperacionImpuesto = new HashSet<OperacionImpuesto>();
            OperacionItemProducto = new HashSet<OperacionItemProducto>();
            OrdenServicioEquipo = new HashSet<OrdenServicioEquipo>();
            OrdenServicioEstado = new HashSet<OrdenServicioEstado>();
            OrdenServicioHabitacion = new HashSet<OrdenServicioHabitacion>();
        }

        /// <summary>
        /// Nro ID Orden de Servicio
        /// </summary>
        [Key]
        [Column("OrdenSerID")]
        public int OrdenSerId { get; set; }
        /// <summary>
        /// Cliente al q se le real;iza la orden de servicio
        /// </summary>
        [Column("ClienteID")]
        public int? ClienteId { get; set; }
        /// <summary>
        /// Fecha Alta Oreden de Servicio
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Detalle de la Orden de Servicio segun solicitud realizada por el Cliente / Tambien util;izado para la explicacion del Inconveniente Tecnico
        /// </summary>
        [Unicode(false)]
        public string DetalleCliente { get; set; }
        /// <summary>
        /// Veredicto del tecnico sobvre el trabajo realizado
        /// </summary>
        [Unicode(false)]
        public string DetalleTecnico { get; set; }
        /// <summary>
        /// Tipo de comprobante utilizado para la Orden de Servicio
        /// </summary>
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        /// <summary>
        /// Nro Talonario al que pertenece la Numeracion del comprobante
        /// </summary>
        [Column("TalonarioID")]
        public short TalonarioId { get; set; }
        /// <summary>
        /// Nro de comprobante / Se repite por ComprobnateID y Nro de Punto de Venta
        /// </summary>
        public int NroComprobante { get; set; }
        /// <summary>
        /// Total Importes Sugeto a impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteRegistraImpuesto { get; set; }
        /// <summary>
        /// Total Importes que no registra Impuesto
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteNoRegistraImpuesto { get; set; }
        /// <summary>
        /// Total Desuento Realizado
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteDescuento { get; set; }
        /// <summary>
        /// Total Importe Impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteImpuestos { get; set; }
        /// <summary>
        /// ImporteRegistraImpuesto+ImporteNoRegistraImpuesto
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }
        /// <summary>
        /// ((ImporteRegistraImpuesto+ImporteNoRegistraImpuesto)-ImporteDescuento)+ImporteImpuestos+
        /// </summary>
        [Column(TypeName = "money")]
        public decimal TotalOrdenServicio { get; set; }
        /// <summary>
        /// Importe total de bonificaciones realizadas en los distintos itemes de esta Orden Servicio
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImpBonificacion { get; set; }
        /// <summary>
        /// Sector que realizo la Orden servicio
        /// </summary>
        [Column("SectorID")]
        public short? SectorId { get; set; }
        /// <summary>
        /// Nro de Sucursal de la Empresa q realizo
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        /// <summary>
        /// ID q indica el Codigo de Estado ACTUAL de la Orden de Servicio (Presupuesto, Presupuesto Aprobado, En Proceso, Facturado, Pendiente Entrega, Entregado, Cancelado Etc.)
        /// </summary>
        [Column("RegEstadoID")]
        public int RegEstadoId { get; set; }
        /// <summary>
        /// Indica la Clasificascion para la Orden de Servicio
        /// </summary>
        [Column("OSClasifID")]
        public short? OsclasifId { get; set; }
        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros) de AlmaNET.OperacionTipo
        /// </summary>
        [Key]
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Categoria de impuesto al que pertenece la entidad a la que se realizo la Venta
        /// </summary>
        [Column("CategoriaImpuestoID")]
        public byte CategoriaImpuestoId { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        /// <summary>
        /// Supervisor Técnico Orden Servicio
        /// </summary>
        [Column("OSTecnicoID")]
        public int? OstecnicoId { get; set; }
        [Column("ProyectoID")]
        public short? ProyectoId { get; set; }
        /// <summary>
        /// Nro de Deposito
        /// </summary>
        [Column("DepositoID")]
        public short? DepositoId { get; set; }
        /// <summary>
        /// Fecha Alta Oreden de Servicio
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Fechaimputacion { get; set; }
        /// <summary>
        /// Se indica cualquier detalle y/u observacion sobre esta operacion
        /// </summary>
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column("TipoOrdenServicioID")]
        public byte? TipoOrdenServicioId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OrdenServicio")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("ClienteId")]
        [InverseProperty("OrdenServicio")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("DepositoId")]
        [InverseProperty("OrdenServicio")]
        public virtual Deposito Deposito { get; set; }
        [ForeignKey("OsclasifId")]
        [InverseProperty("OrdenServicio")]
        public virtual OrdenServicioClasificacion Osclasif { get; set; }
        [ForeignKey("OstecnicoId")]
        [InverseProperty("OrdenServicio")]
        public virtual OrdenServicioTecnico Ostecnico { get; set; }
        [ForeignKey("ProyectoId")]
        [InverseProperty("OrdenServicio")]
        public virtual Proyecto Proyecto { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OrdenServicio")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("OrdenServicio")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual OperacionAltaModicacion OperacionAltaModicacion { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual OrdenServicioTransporte OrdenServicioTransporte { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual ICollection<OperacionArchivo> OperacionArchivo { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual ICollection<OperacionComision> OperacionComision { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual ICollection<OperacionImpuesto> OperacionImpuesto { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual ICollection<OperacionItemProducto> OperacionItemProducto { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual ICollection<OrdenServicioEquipo> OrdenServicioEquipo { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual ICollection<OrdenServicioEstado> OrdenServicioEstado { get; set; }
        [InverseProperty("OrdenServicio")]
        public virtual ICollection<OrdenServicioHabitacion> OrdenServicioHabitacion { get; set; }
    }
}