﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TransporteCubiertaTipo
    {
        public TransporteCubiertaTipo()
        {
            TransporteCubierta = new HashSet<TransporteCubierta>();
            TransporteCubiertaMovimientoDetalle = new HashSet<TransporteCubiertaMovimientoDetalle>();
        }

        [Key]
        [Column("TransporteCubiertaTipoID")]
        public short TransporteCubiertaTipoId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [InverseProperty("TransporteCubiertaTipo")]
        public virtual ICollection<TransporteCubierta> TransporteCubierta { get; set; }
        [InverseProperty("TransporteCubiertaTipo")]
        public virtual ICollection<TransporteCubiertaMovimientoDetalle> TransporteCubiertaMovimientoDetalle { get; set; }
    }
}