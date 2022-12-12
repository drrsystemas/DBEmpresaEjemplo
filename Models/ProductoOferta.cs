﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("FabricanteId", "MarcaId", "CodigoId", "PresentacionId", "SucursalId", "SectorId", "TipoOfertaId", Name = "IX_ProductoOferta", IsUnique = true)]
    [Index("AlmaUserId", Name = "IX_ProductoOfertaAlmaUserID")]
    [Index("FabricanteId", Name = "IX_ProductoOfertaFabricanteID")]
    [Index("MarcaId", Name = "IX_ProductoOfertaMarcaID")]
    [Index("PresentacionId", Name = "IX_ProductoOfertaPresentacionID")]
    [Index("SectorId", Name = "IX_ProductoOfertaSectorID")]
    [Index("SucursalId", Name = "IX_ProductoOfertaSucursalID")]
    [Index("TipoOfertaId", Name = "IX_ProductoOfertaTipoOfertaID")]
    [Index("CodigoId", Name = "IX_ProductoOferta_CodigoID")]
    [Index("LeyendaAdicional", Name = "IX_ProductoOferta_LeyendaAdicional")]
    public partial class ProductoOferta
    {
        public ProductoOferta()
        {
            OperacionItemProductoVenta = new HashSet<OperacionItemProductoVenta>();
            OperacionItemProductoVentaBaucher = new HashSet<OperacionItemProductoVentaBaucher>();
            OperacionPedidoVentaWebItem = new HashSet<OperacionPedidoVentaWebItem>();
            OperacionVentaBaucher = new HashSet<OperacionVentaBaucher>();
        }

        [Key]
        [Column("ProductoOfertaID")]
        public int ProductoOfertaId { get; set; }
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string LeyendaAdicional { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCierre { get; set; }
        /// <summary>
        /// 0-Normal 1-Promocion x Cantidad  2- 1x2 (Paga 1 Lleva 2) 3-2x3 (Paga 2 lleva 3) 4-3x4 (Paga 3 lleva 4) 5-4x5 (Paga 4 lleva 5) 10-Acompaña otro Producto Gratis
        /// </summary>
        [Column("TipoOfertaID")]
        public short? TipoOfertaId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? CantidadMinima { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? PorcBaucher { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("PresentacionID")]
        public short? PresentacionId { get; set; }
        [Column("CodigoID")]
        public int? CodigoId { get; set; }
        [Column("ListaPrecID")]
        public short? ListaPrecId { get; set; }
        [Column("PresentacionIDGratis")]
        public short? PresentacionIdgratis { get; set; }
        [Column("CodigoIDGratis")]
        public int? CodigoIdgratis { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? CantidadPaga { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? CantidadGratis { get; set; }
        public bool Inhabilitado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaModificacion { get; set; }
        [Column("MarcaID")]
        public int? MarcaId { get; set; }
        [Column("FabricanteID")]
        public int? FabricanteId { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteCompraMarca { get; set; }
        public byte? DiaOferta { get; set; }
        public bool? EsDescuentoLimite { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        [Column("ListaPrecIDCondicion")]
        public short? ListaPrecIdcondicion { get; set; }
        [Column("ListaPrecIDAplicar")]
        public short? ListaPrecIdaplicar { get; set; }
        [Column("SucursalIDExpto")]
        public int? SucursalIdexpto { get; set; }
        [Column("SectorIDExpto")]
        public int? SectorIdexpto { get; set; }
        public short? HorasAplica { get; set; }
        [Column("CanalID")]
        public int? CanalId { get; set; }
        public bool? EsMobileOferta { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("ProductoOferta")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("CanalId")]
        [InverseProperty("ProductoOferta")]
        public virtual ClienteCanal Canal { get; set; }
        [ForeignKey("CodigoId")]
        [InverseProperty("ProductoOfertaCodigo")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("CodigoIdgratis")]
        [InverseProperty("ProductoOfertaCodigoIdgratisNavigation")]
        public virtual Producto CodigoIdgratisNavigation { get; set; }
        [ForeignKey("FabricanteId")]
        [InverseProperty("ProductoOferta")]
        public virtual ProductoMarcaManufactur Fabricante { get; set; }
        [ForeignKey("ListaPrecId")]
        [InverseProperty("ProductoOferta")]
        public virtual ProductoLista ListaPrec { get; set; }
        [ForeignKey("MarcaId")]
        [InverseProperty("ProductoOferta")]
        public virtual ProductoMarca Marca { get; set; }
        [ForeignKey("PresentacionId")]
        [InverseProperty("ProductoOfertaPresentacion")]
        public virtual ProductoPresentacionTipo Presentacion { get; set; }
        [ForeignKey("PresentacionIdgratis")]
        [InverseProperty("ProductoOfertaPresentacionIdgratisNavigation")]
        public virtual ProductoPresentacionTipo PresentacionIdgratisNavigation { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("ProductoOferta")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("ProductoOferta")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("ProductoOferta")]
        public virtual ICollection<OperacionItemProductoVenta> OperacionItemProductoVenta { get; set; }
        [InverseProperty("ProductoOferta")]
        public virtual ICollection<OperacionItemProductoVentaBaucher> OperacionItemProductoVentaBaucher { get; set; }
        [InverseProperty("ProductoOferta")]
        public virtual ICollection<OperacionPedidoVentaWebItem> OperacionPedidoVentaWebItem { get; set; }
        [InverseProperty("ProductoOferta")]
        public virtual ICollection<OperacionVentaBaucher> OperacionVentaBaucher { get; set; }
    }
}