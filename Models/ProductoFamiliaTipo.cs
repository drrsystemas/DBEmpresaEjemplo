﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Especifica el Rubro Comercial al q Pertenece (Mercado,Tienda,Ferreteria,etc)
    /// </summary>
    [Index("Descripcion", Name = "IX_ProductoFamiliaTipo_Descripcion")]
    public partial class ProductoFamiliaTipo
    {
        public ProductoFamiliaTipo()
        {
            ProductoFamilia = new HashSet<ProductoFamilia>();
        }

        [Key]
        [Column("TipoFamiliaID")]
        public byte TipoFamiliaId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column("ProductoSectorID")]
        public short? ProductoSectorId { get; set; }

        [ForeignKey("ProductoSectorId")]
        [InverseProperty("ProductoFamiliaTipo")]
        public virtual ProductoFamiliaTipoSector ProductoSector { get; set; }
        [InverseProperty("TipoFamilia")]
        public virtual ICollection<ProductoFamilia> ProductoFamilia { get; set; }
    }
}