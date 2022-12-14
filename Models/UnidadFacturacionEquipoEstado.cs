// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class UnidadFacturacionEquipoEstado
    {
        public UnidadFacturacionEquipoEstado()
        {
            UnidadFacturacionEquipo = new HashSet<UnidadFacturacionEquipo>();
        }

        /// <summary>
        /// Indico el estado del equipo/Medidor
        /// </summary>
        [Key]
        [Column("UF_EstadoID")]
        public int UfEstadoId { get; set; }
        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        [InverseProperty("UfEstado")]
        public virtual ICollection<UnidadFacturacionEquipo> UnidadFacturacionEquipo { get; set; }
    }
}