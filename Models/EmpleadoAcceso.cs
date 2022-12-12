﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("EmpleadoId", Name = "IX_EmpleadoAcceso_EmpleadoID")]
    [Index("TurnoId", Name = "IX_EmpleadoAcceso_TurnoID")]
    public partial class EmpleadoAcceso
    {
        [Key]
        [Column("AccesoID")]
        public int AccesoId { get; set; }
        /// <summary>
        /// ID con que se registra el movimiento
        /// </summary>
        [Column("EmpleadoID")]
        public int EmpleadoId { get; set; }
        [Column("FechaYHoraIngreso")]
        public DateTime FechaYhoraIngreso { get; set; }
        /// <summary>
        /// 0-Normal 1-Retiro Justificado 2- Retira por Urgencia
        /// </summary>
        [Column("TipoAccesoIDIngreso")]
        public short TipoAccesoIdingreso { get; set; }
        [Column("TurnoID")]
        public short? TurnoId { get; set; }
        [StringLength(250)]
        public string Detalle { get; set; }
        [Column("FechaYHoraSalida")]
        public DateTime? FechaYhoraSalida { get; set; }
        /// <summary>
        /// 0-Normal 1-Retiro Justificado 2- Retira por Urgencia
        /// </summary>
        [Column("TipoAccesoIDSalida")]
        public short TipoAccesoIdsalida { get; set; }

        [ForeignKey("EmpleadoId")]
        [InverseProperty("EmpleadoAcceso")]
        public virtual Empleado Empleado { get; set; }
        [ForeignKey("TipoAccesoIdingreso")]
        [InverseProperty("EmpleadoAccesoTipoAccesoIdingresoNavigation")]
        public virtual AccesoTipo TipoAccesoIdingresoNavigation { get; set; }
        [ForeignKey("TipoAccesoIdsalida")]
        [InverseProperty("EmpleadoAccesoTipoAccesoIdsalidaNavigation")]
        public virtual AccesoTipo TipoAccesoIdsalidaNavigation { get; set; }
        [ForeignKey("TurnoId")]
        [InverseProperty("EmpleadoAcceso")]
        public virtual Turno Turno { get; set; }
    }
}