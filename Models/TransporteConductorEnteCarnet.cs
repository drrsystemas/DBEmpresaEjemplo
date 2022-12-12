﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_TransporteConductorEnteCarnet_Descripcion")]
    public partial class TransporteConductorEnteCarnet
    {
        public TransporteConductorEnteCarnet()
        {
            TransporteConductorEnteCarnetIdCondNavigation = new HashSet<TransporteConductor>();
            TransporteConductorEnteCarnetIdLibNavigation = new HashSet<TransporteConductor>();
            TransportePasCarnetDetalle = new HashSet<TransportePasCarnetDetalle>();
        }

        [Key]
        [Column("EnteCarnetID")]
        public int EnteCarnetId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Unicode(false)]
        public string Detalle { get; set; }
        [StringLength(10)]
        public string Ubicacion { get; set; }

        [InverseProperty("EnteCarnetIdCondNavigation")]
        public virtual ICollection<TransporteConductor> TransporteConductorEnteCarnetIdCondNavigation { get; set; }
        [InverseProperty("EnteCarnetIdLibNavigation")]
        public virtual ICollection<TransporteConductor> TransporteConductorEnteCarnetIdLibNavigation { get; set; }
        [InverseProperty("EnteCarnet")]
        public virtual ICollection<TransportePasCarnetDetalle> TransportePasCarnetDetalle { get; set; }
    }
}