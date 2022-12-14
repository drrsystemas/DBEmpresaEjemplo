// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ClasificacionId", Name = "IX_Socios_ClasificacionID")]
    [Index("EntidadSucId", Name = "IX_Socios_EntidadSucID", IsUnique = true)]
    public partial class Socios
    {
        /// <summary>
        /// Fecha en que se dio de Alta
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Nro. Socio
        /// </summary>
        [Key]
        [Column("SocioID")]
        public int SocioId { get; set; }
        /// <summary>
        /// Sucursal a la q esta relacionada
        /// </summary>
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        /// <summary>
        /// Clasificacion asignada
        /// </summary>
        [Column("ClasificacionID")]
        public int? ClasificacionId { get; set; }
        /// <summary>
        /// Indica si esta Inhabilitado
        /// </summary>
        public bool Inhabilitado { get; set; }

        [ForeignKey("ClasificacionId")]
        [InverseProperty("Socios")]
        public virtual SociosClasificacion Clasificacion { get; set; }
        [ForeignKey("EntidadSucId")]
        [InverseProperty("Socios")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
    }
}