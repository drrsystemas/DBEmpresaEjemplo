﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TransporteRemitosViajes
    {
        [Key]
        [Column("RemitoViajeID")]
        public int RemitoViajeId { get; set; }
        [Column("RemitoID")]
        public int RemitoId { get; set; }
        [Column("TraspViajeID")]
        public int TraspViajeId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Cantidad { get; set; }
        [Column(TypeName = "money")]
        public decimal TarifaUnidad { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal PorcDescuento { get; set; }
        [Column(TypeName = "money")]
        public decimal Total { get; set; }
        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros) de AlmaNET.OperacionTipo
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }

        [ForeignKey("TipoOperacionId,RemitoId")]
        [InverseProperty("TransporteRemitosViajes")]
        public virtual TransporteRemitos TransporteRemitos { get; set; }
        [ForeignKey("TraspViajeId")]
        [InverseProperty("TransporteRemitosViajes")]
        public virtual TransporteViaje TraspViaje { get; set; }
    }
}