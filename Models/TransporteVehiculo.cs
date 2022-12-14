// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_TransporteVehiculo_Descripcion")]
    [Index("EmpleadoId", Name = "IX_TransporteVehiculo_EmpleadoID")]
    [Index("MarcaVehiculoId", Name = "IX_TransporteVehiculo_MarcaVehiculoID")]
    [Index("MovilNro", Name = "IX_TransporteVehiculo_MovilNro")]
    [Index("Patente", Name = "IX_TransporteVehiculo_Patente")]
    [Index("ServicioTipoId", Name = "IX_TransporteVehiculo_ServicioTipoID")]
    [Index("TipoCargaId", Name = "IX_TransporteVehiculo_TipoCargaID")]
    [Index("TransporteId", Name = "IX_TransporteVehiculo_TransporteID")]
    public partial class TransporteVehiculo
    {
        public TransporteVehiculo()
        {
            BasculaPesaje = new HashSet<BasculaPesaje>();
            OperacionDespacho = new HashSet<OperacionDespacho>();
            OperacionTransporte = new HashSet<OperacionTransporte>();
            OrdenServicioTransporte = new HashSet<OrdenServicioTransporte>();
            SeguroPoliza = new HashSet<SeguroPoliza>();
            TransporteAutorizacionCargaCamion = new HashSet<TransporteAutorizacionCarga>();
            TransporteAutorizacionCargaChasisAcop = new HashSet<TransporteAutorizacionCarga>();
            TransporteAutorizacionCargaDetalle = new HashSet<TransporteAutorizacionCargaDetalle>();
            TransporteCargaCierrePeriodoVehiculos = new HashSet<TransporteCargaCierrePeriodoVehiculos>();
            TransporteCargaConvenioColectivoDetalle = new HashSet<TransporteCargaConvenioColectivoDetalle>();
            TransporteCargaMovimiento = new HashSet<TransporteCargaMovimiento>();
            TransporteCombustibleConsumoConductor = new HashSet<TransporteCombustibleConsumoConductor>();
            TransporteCombustibleConsumoVehiculo = new HashSet<TransporteCombustibleConsumoVehiculo>();
            TransporteCombustibleImputacion = new HashSet<TransporteCombustibleImputacion>();
            TransporteCubierta = new HashSet<TransporteCubierta>();
            TransporteMandado = new HashSet<TransporteMandado>();
            TransportePasProgramacionDiaDetalle = new HashSet<TransportePasProgramacionDiaDetalle>();
            TransportePasRecorrido = new HashSet<TransportePasRecorrido>();
            TransporteUnidadCamion = new HashSet<TransporteUnidad>();
            TransporteUnidadChasisAcop = new HashSet<TransporteUnidad>();
            TransporteVehiculoConductor = new HashSet<TransporteVehiculoConductor>();
            TransporteVehiculoDatoCompra = new HashSet<TransporteVehiculoDatoCompra>();
            TransporteVehiculoEvento = new HashSet<TransporteVehiculoEvento>();
            TransporteVehiculoFoto = new HashSet<TransporteVehiculoFoto>();
            TransporteVehiculoMantenimiento = new HashSet<TransporteVehiculoMantenimiento>();
            TransporteVehiculoTipoCarga = new HashSet<TransporteVehiculoTipoCarga>();
        }

        [Key]
        [Column("VehiculoID")]
        public int VehiculoId { get; set; }
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Patente { get; set; }
        public byte? CantidadCubierta { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? LitrosCombustible { get; set; }
        public short? ConsumoCombustible100km { get; set; }
        public int? Tara { get; set; }
        public int? AñoModelo { get; set; }
        public int? Color { get; set; }
        /// <summary>
        /// de AlmaNET TransporteVehiculoMarca
        /// </summary>
        [Column("MarcaVehiculoID")]
        public int? MarcaVehiculoId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Modelo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string NroChasis { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string NroMotor { get; set; }
        [Column("EmpleadoID")]
        public int? EmpleadoId { get; set; }
        public byte CantidadEjes { get; set; }
        /// <summary>
        /// de AlmaNET TransporteVehiculoTipo Indica el tipo de Vehiculo q es
        /// </summary>
        [Column("TipoVehiculoID")]
        public short? TipoVehiculoId { get; set; }
        public byte[] Foto { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("TransporteID")]
        public int TransporteId { get; set; }
        [Column("EstadoUsoID")]
        public short? EstadoUsoId { get; set; }
        /// <summary>
        /// Número Identificatorio del Vehículo. En los Transportes de pasajeros cada uno tiene un número
        /// </summary>
        [StringLength(25)]
        [Unicode(false)]
        public string MovilNro { get; set; }
        [Column("ServicioTipoID")]
        public short? ServicioTipoId { get; set; }
        /// <summary>
        /// Indicar si Posee Aire Acondicionado
        /// </summary>
        public bool? PoseeAireCond { get; set; }
        /// <summary>
        /// Indica el Tipo de Combustible q Utiliza el Vehiculo (Nafta,Diesel,Gas,) AlmaNET TrasnporteCombustibleTipo
        /// </summary>
        [Column("CombustibleTipoID")]
        public short? CombustibleTipoId { get; set; }
        /// <summary>
        /// Indica el Tipo de Direccion q posee el Vheiculo (ejem. Hidraulica, Mecanica,etc.) AlmaNET TrasnporteDireccionTipo
        /// </summary>
        [Column("TransDireccionTipoID")]
        public short? TransDireccionTipoId { get; set; }
        /// <summary>
        /// Indica el tipo de Combustion del Vehiculo,( Ejem. Carburado, Inyeccion, etc) (AlmaNET  TrasnporteCombustionTipo)
        /// </summary>
        [Column("CombustionTipoID")]
        public short? CombustionTipoId { get; set; }
        /// <summary>
        /// Indica el Tipo de Trasnmision del Vehiculo (Ejem Automatica, Sincronica, etc.) AlmaNET , TrasnporteTransmisionTipo
        /// </summary>
        [Column("TransmisionTipoID")]
        public short? TransmisionTipoId { get; set; }
        /// <summary>
        /// Refiere a Datos tecnicos o q hacen al Vehiculo
        /// </summary>
        [Unicode(false)]
        public string Obsevaciones { get; set; }
        /// <summary>
        /// Codio tipo Carga q puede Trasnportar
        /// </summary>
        [Column("TipoCargaID")]
        public short? TipoCargaId { get; set; }
        /// <summary>
        /// Fecha en que se establece de baja el vehículo
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FechaBaja { get; set; }
        [Column("CentroCostoID")]
        public int? CentroCostoId { get; set; }

        [ForeignKey("CentroCostoId")]
        [InverseProperty("TransporteVehiculo")]
        public virtual PlanDeCuentaCentroCosto CentroCosto { get; set; }
        [ForeignKey("EmpleadoId")]
        [InverseProperty("TransporteVehiculo")]
        public virtual Empleado Empleado { get; set; }
        [ForeignKey("EstadoUsoId")]
        [InverseProperty("TransporteVehiculo")]
        public virtual TransporteVehiculoEstadoUso EstadoUso { get; set; }
        [ForeignKey("ServicioTipoId")]
        [InverseProperty("TransporteVehiculo")]
        public virtual TransporteVehiculoServicioTipo ServicioTipo { get; set; }
        [ForeignKey("TipoCargaId")]
        [InverseProperty("TransporteVehiculo")]
        public virtual TransporteTipoCarga TipoCarga { get; set; }
        [ForeignKey("TransporteId")]
        [InverseProperty("TransporteVehiculo")]
        public virtual Transporte Transporte { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<BasculaPesaje> BasculaPesaje { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<OperacionDespacho> OperacionDespacho { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<OperacionTransporte> OperacionTransporte { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<OrdenServicioTransporte> OrdenServicioTransporte { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<SeguroPoliza> SeguroPoliza { get; set; }
        [InverseProperty("Camion")]
        public virtual ICollection<TransporteAutorizacionCarga> TransporteAutorizacionCargaCamion { get; set; }
        [InverseProperty("ChasisAcop")]
        public virtual ICollection<TransporteAutorizacionCarga> TransporteAutorizacionCargaChasisAcop { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteAutorizacionCargaDetalle> TransporteAutorizacionCargaDetalle { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteCargaCierrePeriodoVehiculos> TransporteCargaCierrePeriodoVehiculos { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteCargaConvenioColectivoDetalle> TransporteCargaConvenioColectivoDetalle { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteCargaMovimiento> TransporteCargaMovimiento { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteCombustibleConsumoConductor> TransporteCombustibleConsumoConductor { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteCombustibleConsumoVehiculo> TransporteCombustibleConsumoVehiculo { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteCombustibleImputacion> TransporteCombustibleImputacion { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteCubierta> TransporteCubierta { get; set; }
        [InverseProperty("VehiculoIdretiraNavigation")]
        public virtual ICollection<TransporteMandado> TransporteMandado { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransportePasProgramacionDiaDetalle> TransportePasProgramacionDiaDetalle { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransportePasRecorrido> TransportePasRecorrido { get; set; }
        [InverseProperty("Camion")]
        public virtual ICollection<TransporteUnidad> TransporteUnidadCamion { get; set; }
        [InverseProperty("ChasisAcop")]
        public virtual ICollection<TransporteUnidad> TransporteUnidadChasisAcop { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteVehiculoConductor> TransporteVehiculoConductor { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteVehiculoDatoCompra> TransporteVehiculoDatoCompra { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteVehiculoEvento> TransporteVehiculoEvento { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteVehiculoFoto> TransporteVehiculoFoto { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteVehiculoMantenimiento> TransporteVehiculoMantenimiento { get; set; }
        [InverseProperty("Vehiculo")]
        public virtual ICollection<TransporteVehiculoTipoCarga> TransporteVehiculoTipoCarga { get; set; }
    }
}