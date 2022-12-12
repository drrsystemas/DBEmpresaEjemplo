﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Table("PermisoEmpresaNroCRTMIC")]
    [Index("PermisoEmpresaId", Name = "IX_PermisoEmpresaNroCRTMIC_PermisoEmpresaID")]
    public partial class PermisoEmpresaNroCrtmic
    {
        public PermisoEmpresaNroCrtmic()
        {
            TransporteCrt = new HashSet<TransporteCrt>();
            TransporteMic = new HashSet<TransporteMic>();
        }

        [Key]
        [Column("CRTMICID")]
        public int Crtmicid { get; set; }
        [Column("PermisoEmpresaID")]
        public int PermisoEmpresaId { get; set; }
        [Column("CRTMIC")]
        public bool Crtmic { get; set; }
        [Column("NroCRTMIC")]
        public int NroCrtmic { get; set; }
        public bool EsAnulado { get; set; }

        [ForeignKey("PermisoEmpresaId")]
        [InverseProperty("PermisoEmpresaNroCrtmic")]
        public virtual PermisoEmpresa PermisoEmpresa { get; set; }
        [InverseProperty("C2crtmic")]
        public virtual ICollection<TransporteCrt> TransporteCrt { get; set; }
        [InverseProperty("Crtmic")]
        public virtual ICollection<TransporteMic> TransporteMic { get; set; }
    }
}