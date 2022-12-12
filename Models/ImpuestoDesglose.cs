﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ImpuestoDesglose
    {
        [Key]
        [Column("ImpDesgID")]
        public byte ImpDesgId { get; set; }
        [Column("ImpuestoID")]
        public short ImpuestoId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string DenominacionAdicional { get; set; }
        public short CodigAdic { get; set; }
        [Column(TypeName = "money")]
        public decimal? MontoMinimo { get; set; }
        [Column(TypeName = "decimal(15, 3)")]
        public decimal PocentajeDeducir { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImpoteDeducir { get; set; }
        [Column(TypeName = "money")]
        public decimal? MontoAcumulado { get; set; }
        public bool? ReseteaMensualmente { get; set; }
        public bool? ReseteaAnualmente { get; set; }
        public bool SumaAlTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal? MontoMaximo { get; set; }
        [Column("CuentaID")]
        public int? CuentaId { get; set; }
        [Column("CuentaID2")]
        public int? CuentaId2 { get; set; }

        [ForeignKey("ImpuestoId")]
        [InverseProperty("ImpuestoDesglose")]
        public virtual Impuesto Impuesto { get; set; }
    }
}