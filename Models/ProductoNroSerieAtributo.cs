﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_ProductoNroSerieAtributo_Descripcion")]
    public partial class ProductoNroSerieAtributo
    {
        public ProductoNroSerieAtributo()
        {
            ProductoNroSerie = new HashSet<ProductoNroSerie>();
        }

        [Key]
        [Column("AtributoID")]
        public int AtributoId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [InverseProperty("Atributo")]
        public virtual ICollection<ProductoNroSerie> ProductoNroSerie { get; set; }
    }
}