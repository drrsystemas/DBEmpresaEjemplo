// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("CarnetId", Name = "IX_TransportePasCarnetDetalle_CarnetID")]
    [Index("EnteCarnetId", Name = "IX_TransportePasCarnetDetalle_EnteCarnetID")]
    [Index("HoraDesde", Name = "IX_TransportePasCarnetDetalle_HoraDesde")]
    [Index("HoraHasta", Name = "IX_TransportePasCarnetDetalle_HoraHasta")]
    [Index("Ubicacion", Name = "IX_TransportePasCarnetDetalle_Ubicacion")]
    public partial class TransportePasCarnetDetalle
    {
        [Key]
        [Column("DetCarnetID")]
        public int DetCarnetId { get; set; }
        [Column("CarnetID")]
        public int CarnetId { get; set; }
        [Column("EnteCarnetID")]
        public int EnteCarnetId { get; set; }
        public int? DiasVigencia { get; set; }
        public TimeSpan? HoraDesde { get; set; }
        public TimeSpan? HoraHasta { get; set; }
        [Unicode(false)]
        public string Observacion { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Ubicacion { get; set; }
        /// <summary>
        /// 0 Mañana-1 Tarde - 2 Noche
        /// </summary>
        public byte? Turno { get; set; }

        [ForeignKey("CarnetId")]
        [InverseProperty("TransportePasCarnetDetalle")]
        public virtual TransportePasCarnet Carnet { get; set; }
        [ForeignKey("EnteCarnetId")]
        [InverseProperty("TransportePasCarnetDetalle")]
        public virtual TransporteConductorEnteCarnet EnteCarnet { get; set; }
    }
}