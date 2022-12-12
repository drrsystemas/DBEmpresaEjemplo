﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProductoVencimiento
    {
        [Key]
        [Column("VencimientoID")]
        public int VencimientoId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        /// <summary>
        /// Indico la Fecha Vencimiento q actualmente esta aplicando
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime FechaVencimiento { get; set; }
        /// <summary>
        /// Indica Recepcion en la que se registro el Vencimiento
        /// </summary>
        [Column("ItemRecepID")]
        public int? ItemRecepId { get; set; }
        /// <summary>
        /// Fecha en que se dio por finalizado los productos con esta fecha vencimiento
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FechaBaja { get; set; }
        /// <summary>
        /// Usuario que realizo el Control de Baja de esta fecha vencimiento
        /// </summary>
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        /// <summary>
        /// N° de Sucursal q controla el vencimiento
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        /// <summary>
        /// Codigo Q determina la Ubicacion de un Producto en el Deposito
        /// </summary>
        [Column("ProductoUbicacionID")]
        public int? ProductoUbicacionId { get; set; }
        /// <summary>
        /// Nro de Deposito
        /// </summary>
        [Column("DepositoID")]
        public short? DepositoId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("ProductoVencimiento")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("CodigoId")]
        [InverseProperty("ProductoVencimiento")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("DepositoId")]
        [InverseProperty("ProductoVencimiento")]
        public virtual Deposito Deposito { get; set; }
        [ForeignKey("ItemRecepId")]
        [InverseProperty("ProductoVencimiento")]
        public virtual OperacionRecepcionItem ItemRecep { get; set; }
        [ForeignKey("ProductoUbicacionId")]
        [InverseProperty("ProductoVencimiento")]
        public virtual ProductoUbicacion ProductoUbicacion { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("ProductoVencimiento")]
        public virtual Sucursal Sucursal { get; set; }
    }
}