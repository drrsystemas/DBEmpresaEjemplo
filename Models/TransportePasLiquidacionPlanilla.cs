﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TransportePasLiquidacionPlanilla
    {
        /// <summary>
        /// ID del Registro
        /// </summary>
        [Key]
        [Column("LiquidacionPlanillaID")]
        public int LiquidacionPlanillaId { get; set; }
        /// <summary>
        /// Nro. Planilla
        /// </summary>
        public int PlanillaNro { get; set; }
        /// <summary>
        /// Cód. Conductor
        /// </summary>
        [Column("ConductorID")]
        public int ConductorId { get; set; }
        /// <summary>
        /// Indica si la Planilla impresa está con los nros. iniciales en blanco(false); o no (true)
        /// </summary>
        public bool EsVacia { get; set; }
        /// <summary>
        /// Fecha en que se entrega la Planilla
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaEntrega { get; set; }
        /// <summary>
        /// Detalle Boletos Impresos y Entregados
        /// </summary>
        public string DetalleBoletos { get; set; }
        /// <summary>
        /// Nro. Rendición asociada (CUANDO DOY EL ALTA DEL REGISTRO TRANSPORTEPASLIQUIDACION)
        /// </summary>
        [Column("LiquidacionID")]
        public int? LiquidacionId { get; set; }
        /// <summary>
        /// Observación a Realizar
        /// </summary>
        [StringLength(250)]
        public string Observacion { get; set; }
        /// <summary>
        /// Indica si la Planilla se encuentra en baja
        /// </summary>
        public bool EstaInHabilitada { get; set; }
        /// <summary>
        /// Usuario que Realiza la entrega de la planilla
        /// </summary>
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("TransportePasLiquidacionPlanilla")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("ConductorId")]
        [InverseProperty("TransportePasLiquidacionPlanilla")]
        public virtual TransporteConductor Conductor { get; set; }
        [ForeignKey("LiquidacionId")]
        [InverseProperty("TransportePasLiquidacionPlanilla")]
        public virtual TransportePasLiquidacion Liquidacion { get; set; }
    }
}