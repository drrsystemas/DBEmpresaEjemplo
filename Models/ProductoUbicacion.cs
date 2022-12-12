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
    /// Permite Determinar las zonas /Ubicaciones de un Deposito
    /// </summary>
    [Index("DescripcionUbicacion", Name = "IX_ProductoUbicacion_DescripcionUbicacion")]
    [Index("EncargadoReposicionId", Name = "IX_ProductoUbicacion_EncargadoReposicionID")]
    public partial class ProductoUbicacion
    {
        public ProductoUbicacion()
        {
            Deposito = new HashSet<Deposito>();
            DepositoMovimientoItem = new HashSet<DepositoMovimientoItem>();
            ProductoUbicacionStock = new HashSet<ProductoUbicacionStock>();
            ProductoVencimiento = new HashSet<ProductoVencimiento>();
            Sucursal = new HashSet<Sucursal>();
        }

        /// <summary>
        /// Codigo Q determina la Ubicacion de un Producto en el Deposito
        /// </summary>
        [Key]
        [Column("ProductoUbicacionID")]
        public int ProductoUbicacionId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string DescripcionUbicacion { get; set; }
        /// <summary>
        /// Nro de Ubicacion que se le asigna (Se comienza a emumerar  de 1 a por cada Ubicacion) nu puede repetirse el mismo numero de Ubicacion en una misma SubUbicacionDe
        /// </summary>
        public int? UbicacionNro { get; set; }
        /// <summary>
        /// Nro de Familia que se le asigna (Se comienza a emumerar  de 1 a por cada Familia) nu puede repetirse el mismo numero de familia en una misma SubFamiliaDe
        /// </summary>
        [StringLength(250)]
        [Unicode(false)]
        public string UbicacionCompleto { get; set; }
        /// <summary>
        /// Idem a Familia Completo pero rellena con 0 para que quede correctamete ordenado los Registros ([dbo].[HerarchyOrder]([FamiliaCompleto]))
        /// </summary>
        [StringLength(500)]
        public string Orden { get; set; }
        /// <summary>
        /// Indica quien el la persona encargada de la reposicion de esta Ubicacion (Agrupacion informe Reposicion)
        /// </summary>
        [Column("EncargadoReposicionID")]
        public int? EncargadoReposicionId { get; set; }
        public bool? Inhabilitado { get; set; }
        /// <summary>
        /// Trae la ruta completa de la ubicacion completa
        /// </summary>
        [StringLength(1500)]
        [Unicode(false)]
        public string DescripcionRutaCompleta { get; set; }

        [InverseProperty("ProductoUbicacion")]
        public virtual ICollection<Deposito> Deposito { get; set; }
        [InverseProperty("ProductoUbicacion")]
        public virtual ICollection<DepositoMovimientoItem> DepositoMovimientoItem { get; set; }
        [InverseProperty("ProductoUbicacion")]
        public virtual ICollection<ProductoUbicacionStock> ProductoUbicacionStock { get; set; }
        [InverseProperty("ProductoUbicacion")]
        public virtual ICollection<ProductoVencimiento> ProductoVencimiento { get; set; }
        [InverseProperty("ProductoUbicacion")]
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}