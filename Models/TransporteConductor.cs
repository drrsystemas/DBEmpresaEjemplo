﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("CarnetNro", Name = "IX_TransporteConductor_CarnetNro")]
    [Index("EmpleadoId", Name = "IX_TransporteConductor_EmpleadoID")]
    [Index("EnteCarnetIdCond", Name = "IX_TransporteConductor_EnteCarnetID_Cond")]
    [Index("EnteCarnetIdLib", Name = "IX_TransporteConductor_EnteCarnetID_Lib")]
    [Index("TransporteId", Name = "IX_TransporteConductor_TransporteID")]
    public partial class TransporteConductor
    {
        public TransporteConductor()
        {
            BasculaPesaje = new HashSet<BasculaPesaje>();
            OperacionDespacho = new HashSet<OperacionDespacho>();
            OperacionTransporte = new HashSet<OperacionTransporte>();
            OrdenServicioTransporte = new HashSet<OrdenServicioTransporte>();
            TransporteAutorizacionCarga = new HashSet<TransporteAutorizacionCarga>();
            TransporteAutorizacionCargaDetalle = new HashSet<TransporteAutorizacionCargaDetalle>();
            TransporteCargaConvencionColectivo = new HashSet<TransporteCargaConvencionColectivo>();
            TransporteCargaMovimiento = new HashSet<TransporteCargaMovimiento>();
            TransporteCombustibleConsumoConductor = new HashSet<TransporteCombustibleConsumoConductor>();
            TransporteCombustibleImputacion = new HashSet<TransporteCombustibleImputacion>();
            TransporteMandado = new HashSet<TransporteMandado>();
            TransporteMic = new HashSet<TransporteMic>();
            TransportePasEntregaRolloBoleto = new HashSet<TransportePasEntregaRolloBoleto>();
            TransportePasLiquidacion = new HashSet<TransportePasLiquidacion>();
            TransportePasLiquidacionPlanilla = new HashSet<TransportePasLiquidacionPlanilla>();
            TransportePasProgramacionDiaDetalle = new HashSet<TransportePasProgramacionDiaDetalle>();
            TransporteUnidad = new HashSet<TransporteUnidad>();
            TransporteVehiculoConductor = new HashSet<TransporteVehiculoConductor>();
        }

        [Column("EmpleadoID")]
        public int EmpleadoId { get; set; }
        public int CantidadViajes { get; set; }
        /// <summary>
        /// Nro de Conductor/Chofer
        /// </summary>
        [Key]
        [Column("ConductorID")]
        public int ConductorId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string CarnetNro { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? Comision1 { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? Comision2 { get; set; }
        /// <summary>
        /// Nro de la Libreta de Sanidad.
        /// </summary>
        [StringLength(30)]
        [Unicode(false)]
        public string LibretaSanidadNro { get; set; }
        /// <summary>
        /// Ente Otorgador del Carnet de Conducir
        /// </summary>
        [Column("EnteCarnetID_Cond")]
        public int? EnteCarnetIdCond { get; set; }
        /// <summary>
        /// Ente otorgador de la Libreta de Sanidad
        /// </summary>
        [Column("EnteCarnetID_Lib")]
        public int? EnteCarnetIdLib { get; set; }
        [Column("TransporteID")]
        public int? TransporteId { get; set; }

        [ForeignKey("EmpleadoId")]
        [InverseProperty("TransporteConductor")]
        public virtual Empleado Empleado { get; set; }
        [ForeignKey("EnteCarnetIdCond")]
        [InverseProperty("TransporteConductorEnteCarnetIdCondNavigation")]
        public virtual TransporteConductorEnteCarnet EnteCarnetIdCondNavigation { get; set; }
        [ForeignKey("EnteCarnetIdLib")]
        [InverseProperty("TransporteConductorEnteCarnetIdLibNavigation")]
        public virtual TransporteConductorEnteCarnet EnteCarnetIdLibNavigation { get; set; }
        [ForeignKey("TransporteId")]
        [InverseProperty("TransporteConductor")]
        public virtual Transporte Transporte { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<BasculaPesaje> BasculaPesaje { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<OperacionDespacho> OperacionDespacho { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<OperacionTransporte> OperacionTransporte { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<OrdenServicioTransporte> OrdenServicioTransporte { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteAutorizacionCarga> TransporteAutorizacionCarga { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteAutorizacionCargaDetalle> TransporteAutorizacionCargaDetalle { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteCargaConvencionColectivo> TransporteCargaConvencionColectivo { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteCargaMovimiento> TransporteCargaMovimiento { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteCombustibleConsumoConductor> TransporteCombustibleConsumoConductor { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteCombustibleImputacion> TransporteCombustibleImputacion { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteMandado> TransporteMandado { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteMic> TransporteMic { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransportePasEntregaRolloBoleto> TransportePasEntregaRolloBoleto { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransportePasLiquidacion> TransportePasLiquidacion { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransportePasLiquidacionPlanilla> TransportePasLiquidacionPlanilla { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransportePasProgramacionDiaDetalle> TransportePasProgramacionDiaDetalle { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteUnidad> TransporteUnidad { get; set; }
        [InverseProperty("Conductor")]
        public virtual ICollection<TransporteVehiculoConductor> TransporteVehiculoConductor { get; set; }
    }
}