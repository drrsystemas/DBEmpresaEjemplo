﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class RepartoDespachos
    {
        [Key]
        [Column("RegistroDespID")]
        public int RegistroDespId { get; set; }
        /// <summary>
        /// Nro De Despacho
        /// </summary>
        [Column("DespachoID")]
        public int DespachoId { get; set; }
        /// <summary>
        /// Nro Reparto Planilla de Carga
        /// </summary>
        [Column("MovID")]
        public int MovId { get; set; }
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }

        [ForeignKey("MovId")]
        [InverseProperty("RepartoDespachos")]
        public virtual TransporteCargaMovimiento Mov { get; set; }
        [ForeignKey("TipoOperacionId,DespachoId")]
        [InverseProperty("RepartoDespachos")]
        public virtual OperacionDespacho OperacionDespacho { get; set; }
    }
}