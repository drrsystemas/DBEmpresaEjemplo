﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class UnidadFacturacionPeriodoVentas
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("PeriodoID")]
        public int PeriodoId { get; set; }
        /// <summary>
        /// Nro Imputacion de la Venta
        /// </summary>
        [Column("VentaID")]
        public int VentaId { get; set; }
        /// <summary>
        /// Indica la COnexion O Mensualidad
        /// </summary>
        [Column("UnidadFactID")]
        public int? UnidadFactId { get; set; }

        [ForeignKey("PeriodoId")]
        [InverseProperty("UnidadFacturacionPeriodoVentas")]
        public virtual UnidadFacturacionPeriodo Periodo { get; set; }
        [ForeignKey("UnidadFactId")]
        [InverseProperty("UnidadFacturacionPeriodoVentas")]
        public virtual UnidadFacturacion UnidadFact { get; set; }
        public virtual OperacionVenta Venta { get; set; }
    }
}