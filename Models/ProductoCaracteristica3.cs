﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_ProductoCaracteristica3_Descripcion")]
    [Index("TipoCaracteristicaId", Name = "IX_ProductoCaracteristica3_TipoCaracteristicaID")]
    public partial class ProductoCaracteristica3
    {
        public ProductoCaracteristica3()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        [Column("Caracteristica3ID")]
        public int Caracteristica3Id { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Column("TipoCaracteristicaID")]
        public short TipoCaracteristicaId { get; set; }
        public short? Orden { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Abreviatura { get; set; }

        [ForeignKey("TipoCaracteristicaId")]
        [InverseProperty("ProductoCaracteristica3")]
        public virtual ProductoCaracteristica3Tipo TipoCaracteristica { get; set; }
        [InverseProperty("Caracteristica3")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}