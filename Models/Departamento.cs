// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("DepartamentoHierarchy", Name = "IX_Departamento_DepartamentoHierarchy")]
    [Index("Descripcion", Name = "IX_Departamento_Descripcion")]
    [Index("Orden", Name = "IX_Departamento_Orden")]
    public partial class Departamento
    {
        public Departamento()
        {
            AccesoMensaje = new HashSet<AccesoMensaje>();
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        [Column("DepartamentoID")]
        public short DepartamentoId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(80)]
        [Unicode(false)]
        public string DepartamentoHierarchy { get; set; }
        /// <summary>
        /// Nro de Familia que se le asigna (Se comienza a emumerar  de 1 a por cada Familia) nu puede repetirse el mismo numero de familia en una misma SubFamiliaDe
        /// </summary>
        public int DepartamentoNro { get; set; }
        /// <summary>
        /// Idem a Familia Completo pero rellena con 0 para que quede correctamete ordenado los Registros ([dbo].[HerarchyOrder]([FamiliaCompleto]))
        /// </summary>
        [StringLength(400)]
        public string Orden { get; set; }

        [InverseProperty("Departamento")]
        public virtual ICollection<AccesoMensaje> AccesoMensaje { get; set; }
        [InverseProperty("Departamento")]
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}