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
    /// Almace todos los codigo de Barra Utilizados para la Venta de Este Producto (En ocaciones se crea un solo Producto generico y en el se ingresan todos los codigos de barra de los distintos productos relacionados) ejem.  Jugo Marca XX (utiliza los codigo de barra del Productos Jugo Marca XX Naranja,Jugo Marca XX Pomelo, Jugo Marca XX Limon, ya que todos tienen la misma caracterica y Precio) el control de Stok se realiza unicamente sobre el producto generico
    /// </summary>
    [Index("CodigoBarra", Name = "IX_ProductoCodigoBarra_CodigoBarra")]
    [Index("ProductoPresentacionId", Name = "IX_ProductoCodigoBarra_ProductoPresentacionID")]
    public partial class ProductoCodigoBarra
    {
        [Column("ProductoPresentacionID")]
        public int ProductoPresentacionId { get; set; }
        public bool CrearCodigoBarra { get; set; }
        /// <summary>
        /// El Codigo de Barra es Unico y no se debe Repetir
        /// </summary>
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string CodigoBarra { get; set; }
        /// <summary>
        /// Obtengo el listado de los distintos tipos de Codigo de Barra de AlmaNET.TipoCodigoBarra
        /// </summary>
        [Column("TipoCodigoBarraID")]
        public short TipoCodigoBarraId { get; set; }
        /// <summary>
        /// Registro CodigoBarra (un mismo Producto se puede vender con Distintos Codigos de Barra)
        /// </summary>
        [Key]
        public int RegistroCodigo { get; set; }
        [StringLength(50)]
        public string DescripcionAdicional { get; set; }

        [ForeignKey("ProductoPresentacionId")]
        [InverseProperty("ProductoCodigoBarra")]
        public virtual ProductoPresentacion ProductoPresentacion { get; set; }
    }
}