// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("EmpleadoId", Name = "IX_EmpleadoVacacionesFrancos_EmpleadoID")]
    public partial class EmpleadoVacacionesFrancos
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("EmpleadoID")]
        public int EmpleadoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DiaDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DiaHasta { get; set; }
        public byte EsFranco { get; set; }
        [Column(TypeName = "decimal(10, 1)")]
        public decimal? Dias { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHora { get; set; }
        public bool? Firmado { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Observacion { get; set; }
        /// <summary>
        /// Indica si el registro de la vacación corresponde a la finalización de la misma.
        /// </summary>
        public bool Finalizado { get; set; }
        /// <summary>
        /// Para el caso de tener una sancion indico el tipo de sancion a aplicar
        /// </summary>
        [Column("SancionID")]
        public byte? SancionId { get; set; }
        /// <summary>
        /// Codio tipo Carga q puede Trasnportar
        /// </summary>
        [Column("TipoCargaID")]
        public short? TipoCargaId { get; set; }
        public int? PeriodoVacaciones { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("EmpleadoVacacionesFrancos")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("EmpleadoId")]
        [InverseProperty("EmpleadoVacacionesFrancos")]
        public virtual Empleado Empleado { get; set; }
        [ForeignKey("TipoCargaId")]
        [InverseProperty("EmpleadoVacacionesFrancos")]
        public virtual TransporteTipoCarga TipoCarga { get; set; }
    }
}