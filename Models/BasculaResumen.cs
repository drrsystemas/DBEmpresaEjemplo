// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class BasculaResumen
    {
        public BasculaResumen()
        {
            BasculaPesaje = new HashSet<BasculaPesaje>();
        }

        [Key]
        [Column("ResumenBasculaID")]
        public int ResumenBasculaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaCierre { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaHasta { get; set; }
        [Column("BalanzaID")]
        public short? BalanzaId { get; set; }

        [ForeignKey("BalanzaId")]
        [InverseProperty("BasculaResumen")]
        public virtual BasculaBalanza Balanza { get; set; }
        [InverseProperty("ResumenBascula")]
        public virtual ICollection<BasculaPesaje> BasculaPesaje { get; set; }
    }
}