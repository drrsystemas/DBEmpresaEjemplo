// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Table("TransporteCRTEstado")]
    [Index("Descripcion", Name = "IX_TransporteCRTEstado_Descripcion")]
    public partial class TransporteCrtestado
    {
        public TransporteCrtestado()
        {
            TransporteCrt = new HashSet<TransporteCrt>();
        }

        [Key]
        [Column("TransporteCRTEstadoID")]
        public short TransporteCrtestadoId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        public bool EstaHabilitado { get; set; }

        [InverseProperty("TransporteCrtestado")]
        public virtual ICollection<TransporteCrt> TransporteCrt { get; set; }
    }
}