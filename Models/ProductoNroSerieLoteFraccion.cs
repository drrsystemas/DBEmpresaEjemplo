// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("LoteId", Name = "IX_ProductoNroSerieLoteFraccion_LoteID")]
    public partial class ProductoNroSerieLoteFraccion
    {
        public ProductoNroSerieLoteFraccion()
        {
            ProductoNroSerie = new HashSet<ProductoNroSerie>();
            ProductoPalletItem = new HashSet<ProductoPalletItem>();
            TransportePasEntregaBoletoDetalle = new HashSet<TransportePasEntregaBoletoDetalle>();
        }

        [Column("LoteID")]
        public int LoteId { get; set; }
        [Key]
        [Column("LoteFraccionID")]
        public int LoteFraccionId { get; set; }
        public int NroInicia { get; set; }
        public int NroFinal { get; set; }
        public int NroSerie { get; set; }
        [Column("EstadoID")]
        public byte EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("ProductoNroSerieLoteFraccion")]
        public virtual ProductoNroSerieEstado Estado { get; set; }
        [ForeignKey("LoteId")]
        [InverseProperty("ProductoNroSerieLoteFraccion")]
        public virtual ProductoNroSerieLote Lote { get; set; }
        [InverseProperty("LoteFraccion")]
        public virtual ICollection<ProductoNroSerie> ProductoNroSerie { get; set; }
        [InverseProperty("LoteFraccion")]
        public virtual ICollection<ProductoPalletItem> ProductoPalletItem { get; set; }
        [InverseProperty("LoteFraccion")]
        public virtual ICollection<TransportePasEntregaBoletoDetalle> TransportePasEntregaBoletoDetalle { get; set; }
    }
}