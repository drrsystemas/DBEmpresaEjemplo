﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("AutorizDetalleId", Name = "IX_TransporteAutorizacionRemito_AutorizDetalleID")]
    [Index("CargaId", Name = "IX_TransporteAutorizacionRemito_CargaID")]
    [Index("ItemId", Name = "IX_TransporteAutorizacionRemito_ItemID")]
    [Index("RegistroId", Name = "IX_TransporteAutorizacionRemito_RegistroID")]
    public partial class TransporteAutorizacionRemito
    {
        [Column("ItemID")]
        public int ItemId { get; set; }
        [Key]
        [Column("TrasnpRemitoID")]
        public int TrasnpRemitoId { get; set; }
        [Column("CargaID")]
        public int? CargaId { get; set; }
        [Column("AutorizDetalleID")]
        public int? AutorizDetalleId { get; set; }
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Comision { get; set; }
        public bool IncluirConcepto { get; set; }
        [Column("RegistroID")]
        public int? RegistroId { get; set; }

        [ForeignKey("AutorizDetalleId")]
        [InverseProperty("TransporteAutorizacionRemito")]
        public virtual TransporteAutorizacionCargaDetalle AutorizDetalle { get; set; }
        [ForeignKey("ItemId")]
        [InverseProperty("TransporteAutorizacionRemito")]
        public virtual OperacionItemProducto Item { get; set; }
        [ForeignKey("RegistroId")]
        [InverseProperty("TransporteAutorizacionRemito")]
        public virtual TransporteAutorizacionCargaDetalleTransporteCarga Registro { get; set; }
        [ForeignKey("TipoOperacionId,CargaId")]
        [InverseProperty("TransporteAutorizacionRemito")]
        public virtual TransporteCarga TransporteCarga { get; set; }
    }
}