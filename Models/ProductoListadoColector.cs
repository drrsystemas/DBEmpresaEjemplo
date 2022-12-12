﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProductoListadoColector
    {
        /// <summary>
        /// Presentacion Producto0
        /// </summary>
        [Column("PresentacionID")]
        public short PresentacionId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        [Column("ListaPrecID")]
        public short ListaPrecId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Cantidad { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHora { get; set; }
        [Key]
        public int Registro { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string CodigoBarra { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// Nro de Sucursal de la Empresa q realizo 
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        /// <summary>
        /// Usuario q realizo
        /// </summary>
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        /// <summary>
        /// Indico el Deposito q se esta contando
        /// </summary>
        [Column("DepositoID")]
        public int? DepositoId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Filer { get; set; }
        [Column("TipoOperacionID")]
        public byte? TipoOperacionId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? CantidadPiezas { get; set; }
    }
}