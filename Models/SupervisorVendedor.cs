// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("SupervisorId", Name = "IX_SupervisorVendedor_SupervisorID")]
    [Index("VendedorId", Name = "IX_SupervisorVendedor_VendedorID")]
    public partial class SupervisorVendedor
    {
        [Column("SupervisorID")]
        public int SupervisorId { get; set; }
        [Column("VendedorID")]
        public int VendedorId { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? ComisionSupervisor { get; set; }
        public byte? TipoCalculoComision { get; set; }

        [ForeignKey("SupervisorId")]
        [InverseProperty("SupervisorVendedor")]
        public virtual Supervisor Supervisor { get; set; }
        [ForeignKey("VendedorId")]
        [InverseProperty("SupervisorVendedor")]
        public virtual Vendedor Vendedor { get; set; }
    }
}