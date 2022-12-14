// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_TransporteCargaEstadoFlete_Descripcion")]
    public partial class TransporteCargaEstadoFlete
    {
        public TransporteCargaEstadoFlete()
        {
            TransporteCarga = new HashSet<TransporteCarga>();
        }

        [Key]
        [Column("FleteEstadoID")]
        public int FleteEstadoId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [InverseProperty("FleteEstado")]
        public virtual ICollection<TransporteCarga> TransporteCarga { get; set; }
    }
}