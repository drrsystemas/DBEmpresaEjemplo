﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionCobroWebItem
    {
        [Column(TypeName = "money")]
        public decimal ImportePago { get; set; }
        [Column("CobroWebID")]
        public int CobroWebId { get; set; }
        [Key]
        [Column("CtaCtePagoID")]
        public int CtaCtePagoId { get; set; }
        [Column("CtaCteRegID")]
        public int? CtaCteRegId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column("TipoOperacionID")]
        public byte? TipoOperacionId { get; set; }
        [Column("RegistroOperacionID")]
        public int? RegistroOperacionId { get; set; }
        [Column("TipoCobroID")]
        public byte TipoCobroId { get; set; }
        public bool? NuevoRegistro { get; set; }

        [ForeignKey("CobroWebId")]
        [InverseProperty("OperacionCobroWebItem")]
        public virtual OperacionCobroWeb CobroWeb { get; set; }
        [ForeignKey("CtaCteRegId")]
        [InverseProperty("OperacionCobroWebItem")]
        public virtual CuentaCorrienteRegistro CtaCteReg { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionCobroWebItem")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionCobroWebItem")]
        public virtual OperacionVenta OperacionVenta { get; set; }
    }
}