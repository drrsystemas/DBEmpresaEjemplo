// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("EntidadSucId", Name = "IX_EntidadSucursalImpuestoZona_EntidadSucID")]
    public partial class EntidadSucursalImpuestoZona
    {
        [Column("ZonaImpuestoID")]
        public short ZonaImpuestoId { get; set; }
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }

        [ForeignKey("EntidadSucId")]
        [InverseProperty("EntidadSucursalImpuestoZona")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
    }
}