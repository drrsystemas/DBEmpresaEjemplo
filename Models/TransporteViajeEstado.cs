// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_TransporteViajeEstado_Descripcion")]
    public partial class TransporteViajeEstado
    {
        public TransporteViajeEstado()
        {
            TransporteViaje = new HashSet<TransporteViaje>();
        }

        /// <summary>
        /// Codigo Estado de Viaje (Habilitado,NoHabilitado, Supendido)
        /// </summary>
        [Key]
        [Column("ViajeEstadoID")]
        public short ViajeEstadoId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        public bool EstaInHabilitado { get; set; }

        [InverseProperty("ViajeEstado")]
        public virtual ICollection<TransporteViaje> TransporteViaje { get; set; }
    }
}