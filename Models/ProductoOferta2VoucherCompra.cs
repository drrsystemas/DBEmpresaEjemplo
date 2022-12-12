﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProductoOferta2VoucherCompra
    {
        [Column("ProductoOfertaID")]
        public int ProductoOfertaId { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCierre { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal PorcBaucher { get; set; }
        [Column("CanalID")]
        public int? CanalId { get; set; }
        public short? HorasAplica { get; set; }
        public bool Inhabilitado { get; set; }
        public bool? EsMobileOferta { get; set; }
        public byte? DiaOfertah { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaUso { get; set; }
        [Column("ListaPrecIDCondicion")]
        public short? ListaPrecIdcondicion { get; set; }
        [Column("PresentacionID")]
        public short? PresentacionId { get; set; }
        [Column("TipoOfertaID")]
        public short? TipoOfertaId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string LeyendaAdicional { get; set; }

        [ForeignKey("ProductoOfertaId")]
        [InverseProperty("ProductoOferta2VoucherCompra")]
        public virtual ProductoOferta2 ProductoOferta { get; set; }
    }
}