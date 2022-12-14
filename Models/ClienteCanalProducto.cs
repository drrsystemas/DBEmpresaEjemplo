// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ClienteCanalProducto
    {
        [Key]
        [Column("CanalProdID")]
        public int CanalProdId { get; set; }
        /// <summary>
        /// Presentacion Producto0
        /// </summary>
        [Column("PresentacionID")]
        public short? PresentacionId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal PorcBonificacion { get; set; }
        /// <summary>
        /// 1-Se considera como Maximo a Poder Aplicar 2-Aplica Por defecto 3-Aplica siempre
        /// </summary>
        public byte TipoBonificacion { get; set; }
        [Column("ListaPrecID")]
        public short? ListaPrecId { get; set; }
        [Column("CanalID")]
        public int CanalId { get; set; }

        [ForeignKey("CanalId")]
        [InverseProperty("ClienteCanalProducto")]
        public virtual ClienteCanal Canal { get; set; }
    }
}