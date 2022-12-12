﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Visualiso por Vehiculo los mantenimientos preventivos realizados
    /// </summary>
    [Index("RegOrdenDetSerId", Name = "IX_OrdenServicioDetalleMantenimiento_RegOrdenDetSerID")]
    public partial class OrdenServicioDetalleMantenimiento
    {
        [Key]
        [Column("RegistoID")]
        public int RegistoId { get; set; }
        [Column("RegOrdenDetSerID")]
        public int RegOrdenDetSerId { get; set; }
        /// <summary>
        /// Inidca la cantidad de Km. o x realizasos desde el servicio anterior Realizado
        /// </summary>
        public int? CantidaUtilizado { get; set; }
        /// <summary>
        /// Indica El Codigo de Servicio q corresponde al mantenimineto
        /// </summary>
        [Column("ItemMantenimientoID")]
        public int ItemMantenimientoId { get; set; }
        public int? Cada { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Tolerancia { get; set; }
        public int? Exedente { get; set; }

        [ForeignKey("ItemMantenimientoId")]
        [InverseProperty("OrdenServicioDetalleMantenimiento")]
        public virtual TransporteMantenimientoDetalle ItemMantenimiento { get; set; }
        [ForeignKey("RegOrdenDetSerId")]
        [InverseProperty("OrdenServicioDetalleMantenimiento")]
        public virtual OperacionItemProductoOrdenServicio RegOrdenDetSer { get; set; }
    }
}