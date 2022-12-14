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
    /// Permite separar las Unidades de Facturacion
    /// </summary>
    public partial class UnidadFacturacionClasificacion
    {
        public UnidadFacturacionClasificacion()
        {
            UnidadFacturacion = new HashSet<UnidadFacturacion>();
        }

        /// <summary>
        /// Calsificacion Unidades Facturacion
        /// </summary>
        [Key]
        [Column("UF_CaslificacionID")]
        public int UfCaslificacionId { get; set; }
        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        [InverseProperty("UfCaslificacion")]
        public virtual ICollection<UnidadFacturacion> UnidadFacturacion { get; set; }
    }
}