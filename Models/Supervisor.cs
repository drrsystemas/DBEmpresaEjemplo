﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Supervisor de Ventas (Tienen asignado el Control y supervicion de las Ventas por parte de los Vendedores)
    /// </summary>
    [Index("EntidadSucId", Name = "IX_Supervisor_EntidadSucID", IsUnique = true)]
    public partial class Supervisor
    {
        public Supervisor()
        {
            Cliente = new HashSet<Cliente>();
            OperacionItemProductoVentaComisEspec = new HashSet<OperacionItemProductoVentaComisEspec>();
            SupervisorVendedor = new HashSet<SupervisorVendedor>();
        }

        [Key]
        [Column("SupervisorID")]
        public int SupervisorId { get; set; }
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? Comision { get; set; }

        [ForeignKey("EntidadSucId")]
        [InverseProperty("Supervisor")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
        [InverseProperty("Supervisor")]
        public virtual ICollection<Cliente> Cliente { get; set; }
        [InverseProperty("Supervisor")]
        public virtual ICollection<OperacionItemProductoVentaComisEspec> OperacionItemProductoVentaComisEspec { get; set; }
        [InverseProperty("Supervisor")]
        public virtual ICollection<SupervisorVendedor> SupervisorVendedor { get; set; }
    }
}