﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ClienteId", Name = "IX_TransporteViaje_ClienteID")]
    [Index("Descripcion", Name = "IX_TransporteViaje_Descripcion")]
    [Index("EntidadSucIddestino", Name = "IX_TransporteViaje_EntidadSucIDDestino")]
    [Index("EntidadSucIdorigen", Name = "IX_TransporteViaje_EntidadSucIDOrigen")]
    [Index("ProductoPrecioId", Name = "IX_TransporteViaje_ProductoPrecioID")]
    [Index("ViajeDestinoId", Name = "IX_TransporteViaje_ViajeDestinoID")]
    [Index("ViajeEstadoId", Name = "IX_TransporteViaje_ViajeEstadoID")]
    [Index("ViajeOrigenId", Name = "IX_TransporteViaje_ViajeOrigenID")]
    public partial class TransporteViaje
    {
        public TransporteViaje()
        {
            TransporteAutorizacionCargaDetalle = new HashSet<TransporteAutorizacionCargaDetalle>();
            TransporteCarga = new HashSet<TransporteCarga>();
            TransporteRemitosViajes = new HashSet<TransporteRemitosViajes>();
            TransporteViajeAdicionales = new HashSet<TransporteViajeAdicionales>();
        }

        /// <summary>
        /// Codigo Viaje, q especifica Lugar Origen, Lugar Destino, Distancia a recorrer, Producto Transporta, Cliente Origen, Cliente Destino
        /// </summary>
        [Key]
        [Column("TraspViajeID")]
        public int TraspViajeId { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Column("ViajeOrigenID")]
        public int ViajeOrigenId { get; set; }
        [Column("ViajeDestinoID")]
        public int ViajeDestinoId { get; set; }
        /// <summary>
        /// Cantidad de Kilomentros q representa el recorrido
        /// </summary>
        [Column(TypeName = "decimal(13, 2)")]
        public decimal KmRecorrido { get; set; }
        /// <summary>
        /// Tiempo estimado del Recorrido expresado en Minutos
        /// </summary>
        public int DuracionMinutos { get; set; }
        /// <summary>
        /// Codigo Estado de Viaje (Habilitado,NoHabilitado, Supendido)
        /// </summary>
        [Column("ViajeEstadoID")]
        public short ViajeEstadoId { get; set; }
        [Column(TypeName = "money")]
        public decimal TarifaUnidad { get; set; }
        /// <summary>
        /// CodigoPrecio para un producto en Deteminada Presentacion y lista de precio
        /// </summary>
        [Column("ProductoPrecioID")]
        public int ProductoPrecioId { get; set; }
        [Column("EntidadSucIDDestino")]
        public int? EntidadSucIddestino { get; set; }
        [Column("EntidadSucIDOrigen")]
        public int? EntidadSucIdorigen { get; set; }
        [Column("ClienteID")]
        public int? ClienteId { get; set; }
        /// <summary>
        /// Se aplica cuando una Carga posee varios viajes dentro de una misma zona
        /// </summary>
        [Column(TypeName = "money")]
        public decimal TarifaFot { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? PorcDescuento { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? PorSeguro { get; set; }
        [Column("DepositoIDSale")]
        public short? DepositoIdsale { get; set; }
        /// <summary>
        /// Sector que realizo la Venta
        /// </summary>
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("TransporteViaje")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("DepositoIdsale")]
        [InverseProperty("TransporteViaje")]
        public virtual Deposito DepositoIdsaleNavigation { get; set; }
        [ForeignKey("EntidadSucIddestino")]
        [InverseProperty("TransporteViajeEntidadSucIddestinoNavigation")]
        public virtual EntidadSucursal EntidadSucIddestinoNavigation { get; set; }
        [ForeignKey("EntidadSucIdorigen")]
        [InverseProperty("TransporteViajeEntidadSucIdorigenNavigation")]
        public virtual EntidadSucursal EntidadSucIdorigenNavigation { get; set; }
        [ForeignKey("ProductoPrecioId")]
        [InverseProperty("TransporteViaje")]
        public virtual ProductoListaPrecio ProductoPrecio { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("TransporteViaje")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("TransporteViaje")]
        public virtual Sucursal Sucursal { get; set; }
        [ForeignKey("ViajeDestinoId")]
        [InverseProperty("TransporteViajeViajeDestino")]
        public virtual TransporteOrigenDestino ViajeDestino { get; set; }
        [ForeignKey("ViajeEstadoId")]
        [InverseProperty("TransporteViaje")]
        public virtual TransporteViajeEstado ViajeEstado { get; set; }
        [ForeignKey("ViajeOrigenId")]
        [InverseProperty("TransporteViajeViajeOrigen")]
        public virtual TransporteOrigenDestino ViajeOrigen { get; set; }
        [InverseProperty("TraspViaje")]
        public virtual ICollection<TransporteAutorizacionCargaDetalle> TransporteAutorizacionCargaDetalle { get; set; }
        [InverseProperty("TraspViaje")]
        public virtual ICollection<TransporteCarga> TransporteCarga { get; set; }
        [InverseProperty("TraspViaje")]
        public virtual ICollection<TransporteRemitosViajes> TransporteRemitosViajes { get; set; }
        [InverseProperty("TraspViaje")]
        public virtual ICollection<TransporteViajeAdicionales> TransporteViajeAdicionales { get; set; }
    }
}