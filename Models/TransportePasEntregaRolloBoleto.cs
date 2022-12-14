// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ConductorId", Name = "IX_TransportePasEntregaRolloBoleto_ConductorID")]
    [Index("Fecha", Name = "IX_TransportePasEntregaRolloBoleto_Fecha")]
    public partial class TransportePasEntregaRolloBoleto
    {
        public TransportePasEntregaRolloBoleto()
        {
            TransportePasEntregaBoletoDetalle = new HashSet<TransportePasEntregaBoletoDetalle>();
        }

        [Key]
        [Column("EntregaBolID")]
        public int EntregaBolId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("ConductorID")]
        public int ConductorId { get; set; }
        [Unicode(false)]
        public string Observaciones { get; set; }

        [ForeignKey("ConductorId")]
        [InverseProperty("TransportePasEntregaRolloBoleto")]
        public virtual TransporteConductor Conductor { get; set; }
        [InverseProperty("EntregaBol")]
        public virtual ICollection<TransportePasEntregaBoletoDetalle> TransportePasEntregaBoletoDetalle { get; set; }
    }
}