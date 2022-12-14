// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_ProduccionOrdenItemTipoPrioridad_Descripcion")]
    public partial class ProduccionOrdenItemTipoPrioridad
    {
        public ProduccionOrdenItemTipoPrioridad()
        {
            ProduccionOrdenItem = new HashSet<ProduccionOrdenItem>();
        }

        [Key]
        [Column("PrioridadID")]
        public byte PrioridadId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [InverseProperty("Prioridad")]
        public virtual ICollection<ProduccionOrdenItem> ProduccionOrdenItem { get; set; }
    }
}