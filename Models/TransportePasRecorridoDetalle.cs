﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("EntregaBoletoId", Name = "IX_TransportePasRecorridoDetalle_EntregaBoletoID")]
    [Index("LiquidacionRecId", Name = "IX_TransportePasRecorridoDetalle_LiquidacionRecID")]
    public partial class TransportePasRecorridoDetalle
    {
        [Key]
        [Column("DetRecorridoID")]
        public int DetRecorridoId { get; set; }
        [Column("EntregaBoletoID")]
        public int EntregaBoletoId { get; set; }
        public int NroSerieInicio { get; set; }
        public int NroSerieFinal { get; set; }
        [Column("LiquidacionRecID")]
        public int LiquidacionRecId { get; set; }
        [Column(TypeName = "money")]
        public decimal PrecioBoleto { get; set; }
        public int? CantBoleto { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalItem { get; set; }
        public bool UltimoBoleto { get; set; }

        [ForeignKey("EntregaBoletoId")]
        [InverseProperty("TransportePasRecorridoDetalle")]
        public virtual TransportePasEntregaBoletoDetalle EntregaBoleto { get; set; }
        [ForeignKey("LiquidacionRecId")]
        [InverseProperty("TransportePasRecorridoDetalle")]
        public virtual TransportePasRecorrido LiquidacionRec { get; set; }
    }
}