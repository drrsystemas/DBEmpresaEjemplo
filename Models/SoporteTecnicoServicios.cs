// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class SoporteTecnicoServicios
    {
        /// <summary>
        /// Codigo a utilizar como tecnico de Soporte
        /// </summary>
        [Column("TecnicoSoporteID")]
        public int TecnicoSoporteId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        [StringLength(150)]
        public string DescripcionAdicional { get; set; }
        [Key]
        [Column("SoporteTecServID")]
        public int SoporteTecServId { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? CantidadMinima { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? PorcentajeComision { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? PrecioUnidad { get; set; }

        [ForeignKey("CodigoId")]
        [InverseProperty("SoporteTecnicoServicios")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("TecnicoSoporteId")]
        [InverseProperty("SoporteTecnicoServicios")]
        public virtual SoporteTecnico TecnicoSoporte { get; set; }
    }
}