﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class PlanDeCuentaTablaIndice
    {
        public PlanDeCuentaTablaIndice()
        {
            PlanDeCuenta = new HashSet<PlanDeCuenta>();
            PlanDeCuentaTablaIndiceDetalle = new HashSet<PlanDeCuentaTablaIndiceDetalle>();
            PlanDeCuentasTotalizadora = new HashSet<PlanDeCuentasTotalizadora>();
        }

        [Key]
        [Column("TablaIndiceID")]
        public short TablaIndiceId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Unicode(false)]
        public string Detalle { get; set; }

        [InverseProperty("TablaIndice")]
        public virtual ICollection<PlanDeCuenta> PlanDeCuenta { get; set; }
        [InverseProperty("TablaIndice")]
        public virtual ICollection<PlanDeCuentaTablaIndiceDetalle> PlanDeCuentaTablaIndiceDetalle { get; set; }
        [InverseProperty("TablaIndice")]
        public virtual ICollection<PlanDeCuentasTotalizadora> PlanDeCuentasTotalizadora { get; set; }
    }
}