// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Table("ProductoOferta2PromoXCantidad")]
    public partial class ProductoOferta2PromoXcantidad
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
        [Column("PresentacionIDGratis")]
        public short? PresentacionIdgratis { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? CantidadPaga { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal CantidadGratis { get; set; }
        [Column("CodigoIDGratis")]
        public int? CodigoIdgratis { get; set; }
        public short? HorasAplica { get; set; }
        [Column("CanalID")]
        public int? CanalId { get; set; }
        public bool Inhabilitado { get; set; }
        public bool? EsMobileOferta { get; set; }
        public byte? DiaOferta { get; set; }
        [Column("ListaPrecIDCondicion")]
        public short? ListaPrecIdcondicion { get; set; }
        [Column("PresentacionID")]
        public short? PresentacionId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string LeyendaAdicional { get; set; }
        [Column("TipoOfertaID")]
        public short? TipoOfertaId { get; set; }

        [ForeignKey("ProductoOfertaId")]
        [InverseProperty("ProductoOferta2PromoXcantidad")]
        public virtual ProductoOferta2 ProductoOferta { get; set; }
    }
}