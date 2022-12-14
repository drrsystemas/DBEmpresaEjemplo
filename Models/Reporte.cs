// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Contiene todos los reportes moudificados por el Usuario
    /// </summary>
    [Index("Descripcion", Name = "IX_Reporte_Descripcion")]
    [Index("ReportName", Name = "IX_Reporte_ReportName")]
    public partial class Reporte
    {
        /// <summary>
        /// Codigo Reporte
        /// </summary>
        [Key]
        [Column("ReportID")]
        public int ReportId { get; set; }
        /// <summary>
        /// Nombre unico del Reporte
        /// </summary>
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string ReportName { get; set; }
        /// <summary>
        /// Descripcion utilizada para identificar el Reporte
        /// </summary>
        [StringLength(250)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// Indica si es utilizado por todos los Usuarios del Sistema
        /// </summary>
        public bool UsoRestringido { get; set; }
        /// <summary>
        /// Contiene el archivo en Stream del reporte Modificado
        /// </summary>
        public byte[] ReporteModificado { get; set; }
        /// <summary>
        /// Indica q se utiliza el Reporte Predeterminado, Ver Menu..
        /// </summary>
        public bool UsarDefault { get; set; }
    }
}