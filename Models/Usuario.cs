﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("EntidadSucId", Name = "IX_Usuario_EntidadSucID")]
    [Index("NombreCompleto", Name = "IX_Usuario_NombreCompleto")]
    [Index("NombreSistema", Name = "IX_Usuario_NombreSistema")]
    public partial class Usuario
    {
        public Usuario()
        {
            AutorizacionCompra = new HashSet<AutorizacionCompra>();
            BancoTarjetaHaberLiquidacion = new HashSet<BancoTarjetaHaberLiquidacion>();
            BasculaPesaje = new HashSet<BasculaPesaje>();
            BuscarConfiguracion = new HashSet<BuscarConfiguracion>();
            Chequera = new HashSet<Chequera>();
            EmpleadoVacacionesFrancos = new HashSet<EmpleadoVacacionesFrancos>();
            EventoAlmaUser = new HashSet<Evento>();
            EventoColaboradores = new HashSet<EventoColaboradores>();
            EventoRegistroAlmaUser = new HashSet<Evento>();
            FiscalInformeSemanal = new HashSet<FiscalInformeSemanal>();
            HotelHabitacionAuditoria = new HashSet<HotelHabitacionAuditoria>();
            ImpuestoFormulario = new HashSet<ImpuestoFormulario>();
            ImpuestoFormularioLiquidacion = new HashSet<ImpuestoFormularioLiquidacion>();
            LibroDiario = new HashSet<LibroDiario>();
            LibroDiarioAgrupado = new HashSet<LibroDiarioAgrupado>();
            LibroDiarioBalance = new HashSet<LibroDiarioBalance>();
            OperacionAltaModicacion = new HashSet<OperacionAltaModicacion>();
            OperacionAutorizacion = new HashSet<OperacionAutorizacion>();
            OperacionCobro = new HashSet<OperacionCobro>();
            OperacionCobroWeb = new HashSet<OperacionCobroWeb>();
            OperacionCompra = new HashSet<OperacionCompra>();
            OperacionConsignacion = new HashSet<OperacionConsignacion>();
            OperacionDespacho = new HashSet<OperacionDespacho>();
            OperacionFormaPagoPermiso = new HashSet<OperacionFormaPagoPermiso>();
            OperacionImpresionUsuario = new HashSet<OperacionImpresionUsuario>();
            OperacionInventario = new HashSet<OperacionInventario>();
            OperacionItemProductoPedidoCompraReposicion = new HashSet<OperacionItemProductoPedidoCompraReposicion>();
            OperacionLiquidoProducto = new HashSet<OperacionLiquidoProducto>();
            OperacionPago = new HashSet<OperacionPago>();
            OperacionPagoAutorizacion = new HashSet<OperacionPagoAutorizacion>();
            OperacionPedidoCompra = new HashSet<OperacionPedidoCompra>();
            OperacionPedidoVenta = new HashSet<OperacionPedidoVenta>();
            OperacionPedidoVentaWeb = new HashSet<OperacionPedidoVentaWeb>();
            OperacionRecepcion = new HashSet<OperacionRecepcion>();
            OperacionRegistroUsoTalonario = new HashSet<OperacionRegistroUsoTalonario>();
            OperacionRendicion = new HashSet<OperacionRendicion>();
            OperacionResumen = new HashSet<OperacionResumen>();
            OperacionVale = new HashSet<OperacionVale>();
            OperacionValeContra = new HashSet<OperacionValeContra>();
            OperacionVenta = new HashSet<OperacionVenta>();
            OrdenServicio = new HashSet<OrdenServicio>();
            PlanDeCuentaInventario = new HashSet<PlanDeCuentaInventario>();
            ProductoCosto = new HashSet<ProductoCosto>();
            ProductoCostoHistorico = new HashSet<ProductoCostoHistorico>();
            ProductoListaPrecio = new HashSet<ProductoListaPrecio>();
            ProductoListaSucursal = new HashSet<ProductoListaSucursal>();
            ProductoOferta = new HashSet<ProductoOferta>();
            ProductoOferta2 = new HashSet<ProductoOferta2>();
            ProductoPrecioHistorico = new HashSet<ProductoPrecioHistorico>();
            ProductoVencimiento = new HashSet<ProductoVencimiento>();
            Servis = new HashSet<Servis>();
            ServisProcesos = new HashSet<ServisProcesos>();
            TransporteAutorizacionCarga = new HashSet<TransporteAutorizacionCarga>();
            TransporteAutorizacionCargaDetalle = new HashSet<TransporteAutorizacionCargaDetalle>();
            TransporteCargaAlmaUser = new HashSet<TransporteCarga>();
            TransporteCargaAlmaUserIdanuloNavigation = new HashSet<TransporteCarga>();
            TransporteCargaCierrePeriodo = new HashSet<TransporteCargaCierrePeriodo>();
            TransporteCargaConvencionColectivo = new HashSet<TransporteCargaConvencionColectivo>();
            TransporteCargaMovimiento = new HashSet<TransporteCargaMovimiento>();
            TransporteCargaMovimientoDetalleAlmaUserIdingresaNavigation = new HashSet<TransporteCargaMovimientoDetalle>();
            TransporteCargaMovimientoDetalleAlmaUserIdsaleNavigation = new HashSet<TransporteCargaMovimientoDetalle>();
            TransporteCombustibleConsumoConductor = new HashSet<TransporteCombustibleConsumoConductor>();
            TransporteCombustibleConsumoVehiculo = new HashSet<TransporteCombustibleConsumoVehiculo>();
            TransporteCombustibleRuteo = new HashSet<TransporteCombustibleRuteo>();
            TransporteMandado = new HashSet<TransporteMandado>();
            TransportePasLiquidacion = new HashSet<TransportePasLiquidacion>();
            TransportePasLiquidacionPlanilla = new HashSet<TransportePasLiquidacionPlanilla>();
            TransporteRemitos = new HashSet<TransporteRemitos>();
            TransporteUnidad = new HashSet<TransporteUnidad>();
            TransporteViajeCelular = new HashSet<TransporteViajeCelular>();
            UsuarioAuditoria = new HashSet<UsuarioAuditoria>();
            UsuarioAutorizacionSolicitud = new HashSet<UsuarioAutorizacionSolicitud>();
        }

        [Key]
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string NombreSistema { get; set; }
        [Required]
        [StringLength(70)]
        [Unicode(false)]
        public string NombreCompleto { get; set; }
        [Column("TipoEntidadID")]
        public short? TipoEntidadId { get; set; }
        /// <summary>
        /// Nro Sucursal/Entidad
        /// </summary>
        [Column("EntidadSucID")]
        public int? EntidadSucId { get; set; }
        /// <summary>
        /// null 0 -Normal 1-indico es Proveedor (Vinculado a un Proveedor) 2-Es Cliente (Vinculado a Cliente)
        /// </summary>
        public byte? TipoUsuario { get; set; }
        /// <summary>
        /// Nro de Deposito a utilizar por Defecto para verificar stock al realizar la venta
        /// </summary>
        [Column("DepositoID")]
        public short? DepositoId { get; set; }
        /// <summary>
        /// Indica Menu q se configura por default
        /// </summary>
        public int? MenuAcceso { get; set; }
        public int? MenuPortalWeb { get; set; }
        public byte? Inhabilitado { get; set; }
        [Column("ConfigacionJSON")]
        [Unicode(false)]
        public string ConfigacionJson { get; set; }

        [ForeignKey("DepositoId")]
        [InverseProperty("Usuario")]
        public virtual Deposito Deposito { get; set; }
        [ForeignKey("EntidadSucId")]
        [InverseProperty("Usuario")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<AutorizacionCompra> AutorizacionCompra { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<BancoTarjetaHaberLiquidacion> BancoTarjetaHaberLiquidacion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<BasculaPesaje> BasculaPesaje { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<BuscarConfiguracion> BuscarConfiguracion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<Chequera> Chequera { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<EmpleadoVacacionesFrancos> EmpleadoVacacionesFrancos { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<Evento> EventoAlmaUser { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<EventoColaboradores> EventoColaboradores { get; set; }
        [InverseProperty("RegistroAlmaUser")]
        public virtual ICollection<Evento> EventoRegistroAlmaUser { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<FiscalInformeSemanal> FiscalInformeSemanal { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<HotelHabitacionAuditoria> HotelHabitacionAuditoria { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ImpuestoFormulario> ImpuestoFormulario { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ImpuestoFormularioLiquidacion> ImpuestoFormularioLiquidacion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<LibroDiario> LibroDiario { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<LibroDiarioAgrupado> LibroDiarioAgrupado { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<LibroDiarioBalance> LibroDiarioBalance { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionAltaModicacion> OperacionAltaModicacion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionAutorizacion> OperacionAutorizacion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionCobro> OperacionCobro { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionCobroWeb> OperacionCobroWeb { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionCompra> OperacionCompra { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionConsignacion> OperacionConsignacion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionDespacho> OperacionDespacho { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionFormaPagoPermiso> OperacionFormaPagoPermiso { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionImpresionUsuario> OperacionImpresionUsuario { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionInventario> OperacionInventario { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionItemProductoPedidoCompraReposicion> OperacionItemProductoPedidoCompraReposicion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionLiquidoProducto> OperacionLiquidoProducto { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionPago> OperacionPago { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionPagoAutorizacion> OperacionPagoAutorizacion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionPedidoCompra> OperacionPedidoCompra { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionPedidoVenta> OperacionPedidoVenta { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionPedidoVentaWeb> OperacionPedidoVentaWeb { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionRecepcion> OperacionRecepcion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionRegistroUsoTalonario> OperacionRegistroUsoTalonario { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionRendicion> OperacionRendicion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionResumen> OperacionResumen { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionVale> OperacionVale { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionValeContra> OperacionValeContra { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OperacionVenta> OperacionVenta { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<OrdenServicio> OrdenServicio { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<PlanDeCuentaInventario> PlanDeCuentaInventario { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoCosto> ProductoCosto { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoCostoHistorico> ProductoCostoHistorico { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoListaPrecio> ProductoListaPrecio { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoListaSucursal> ProductoListaSucursal { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoOferta> ProductoOferta { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoOferta2> ProductoOferta2 { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoPrecioHistorico> ProductoPrecioHistorico { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ProductoVencimiento> ProductoVencimiento { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<Servis> Servis { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<ServisProcesos> ServisProcesos { get; set; }
        [InverseProperty("Operador")]
        public virtual ICollection<TransporteAutorizacionCarga> TransporteAutorizacionCarga { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteAutorizacionCargaDetalle> TransporteAutorizacionCargaDetalle { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteCarga> TransporteCargaAlmaUser { get; set; }
        [InverseProperty("AlmaUserIdanuloNavigation")]
        public virtual ICollection<TransporteCarga> TransporteCargaAlmaUserIdanuloNavigation { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteCargaCierrePeriodo> TransporteCargaCierrePeriodo { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteCargaConvencionColectivo> TransporteCargaConvencionColectivo { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteCargaMovimiento> TransporteCargaMovimiento { get; set; }
        [InverseProperty("AlmaUserIdingresaNavigation")]
        public virtual ICollection<TransporteCargaMovimientoDetalle> TransporteCargaMovimientoDetalleAlmaUserIdingresaNavigation { get; set; }
        [InverseProperty("AlmaUserIdsaleNavigation")]
        public virtual ICollection<TransporteCargaMovimientoDetalle> TransporteCargaMovimientoDetalleAlmaUserIdsaleNavigation { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteCombustibleConsumoConductor> TransporteCombustibleConsumoConductor { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteCombustibleConsumoVehiculo> TransporteCombustibleConsumoVehiculo { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteCombustibleRuteo> TransporteCombustibleRuteo { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteMandado> TransporteMandado { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransportePasLiquidacion> TransportePasLiquidacion { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransportePasLiquidacionPlanilla> TransportePasLiquidacionPlanilla { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteRemitos> TransporteRemitos { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteUnidad> TransporteUnidad { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<TransporteViajeCelular> TransporteViajeCelular { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<UsuarioAuditoria> UsuarioAuditoria { get; set; }
        [InverseProperty("AlmaUser")]
        public virtual ICollection<UsuarioAutorizacionSolicitud> UsuarioAutorizacionSolicitud { get; set; }
    }
}