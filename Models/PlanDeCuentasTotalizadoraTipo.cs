﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_PlanDeCuentasTotalizadoraTipo_Descripcion")]
    public partial class PlanDeCuentasTotalizadoraTipo
    {
        public PlanDeCuentasTotalizadoraTipo()
        {
            PlanDeCuentasTotalizadora = new HashSet<PlanDeCuentasTotalizadora>();
        }

        /// <summary>
        /// Codigo Tippo de Cuenta
        /// </summary>
        [Key]
        [Column("TipoCuentaID")]
        public byte TipoCuentaId { get; set; }
        /// <summary>
        /// Ejem. Resultado , Resultado (+), resultado (-), Bienes Amortizables, Etc. --
        /// </summary>
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// Si el saldo de la Cuenta es Deudor
        /// </summary>
        public bool EsDeudor { get; set; }
        public int? Filer { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Orden { get; set; }

        [InverseProperty("TipoCuenta")]
        public virtual ICollection<PlanDeCuentasTotalizadora> PlanDeCuentasTotalizadora { get; set; }
    }
}