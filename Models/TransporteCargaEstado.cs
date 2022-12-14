// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_TransporteCargaEstado_Descripcion")]
    public partial class TransporteCargaEstado
    {
        public TransporteCargaEstado()
        {
            TransporteCarga = new HashSet<TransporteCarga>();
        }

        /// <summary>
        /// Indica el estado en q esta Una carga (ARetirar, En viaje, Completado, Facturado etc.)
        /// </summary>
        [Key]
        [Column("EstadoCargaID")]
        public short EstadoCargaId { get; set; }
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// Indica si los registros en dicho estado quedan disponibles para ser asignados en las autorizaciones
        /// </summary>
        public bool DisponibleAutorizacion { get; set; }
        public int? Color { get; set; }
        public int? LetraColor { get; set; }

        [InverseProperty("EstadoCarga")]
        public virtual ICollection<TransporteCarga> TransporteCarga { get; set; }
    }
}