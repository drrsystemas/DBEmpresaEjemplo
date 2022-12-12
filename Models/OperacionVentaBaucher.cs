﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("TipoOperacionId", "VentaId", Name = "IX_OperacionVentaBaucher")]
    public partial class OperacionVentaBaucher
    {
        public OperacionVentaBaucher()
        {
            OperacionItemProductoVentaBaucher = new HashSet<OperacionItemProductoVentaBaucher>();
            OperacionVentaBaucherCancelacion = new HashSet<OperacionVentaBaucherCancelacion>();
        }

        [Key]
        [Column("BaucherID")]
        public int BaucherId { get; set; }
        [Column("VentaID")]
        public int VentaId { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteBaucher { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaVto { get; set; }
        public bool Cancelado { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaUtilizacion { get; set; }
        [Column("TerminalID")]
        public short? TerminalId { get; set; }
        [Column("BaucherIDLocal")]
        public int? BaucherIdlocal { get; set; }
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        [Column("ProductoOfertaID")]
        public int? ProductoOfertaId { get; set; }

        [ForeignKey("TipoOperacionId,VentaId")]
        [InverseProperty("OperacionVentaBaucher")]
        public virtual OperacionVenta OperacionVenta { get; set; }
        [ForeignKey("ProductoOfertaId")]
        [InverseProperty("OperacionVentaBaucher")]
        public virtual ProductoOferta ProductoOferta { get; set; }
        [InverseProperty("Baucher")]
        public virtual ICollection<OperacionItemProductoVentaBaucher> OperacionItemProductoVentaBaucher { get; set; }
        [InverseProperty("Baucher")]
        public virtual ICollection<OperacionVentaBaucherCancelacion> OperacionVentaBaucherCancelacion { get; set; }
    }
}