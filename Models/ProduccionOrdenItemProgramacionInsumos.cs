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
    /// Se determina la cantidad de Insumos a utilizar por cada Itemque se programa para elaborar
    /// </summary>
    [Index("ProgramacionItemElaboracionId", "ProductoInsumoId", Name = "IX_ProduccionOrdenItemElaboracionProgramacionInsumos", IsUnique = true)]
    public partial class ProduccionOrdenItemProgramacionInsumos
    {
        /// <summary>
        /// Item de programacion del item Orden Servicio  (Un item de Orden Produccion Puede contener varios Items de Progrmacion)
        /// </summary>
        [Column("ProgramacionItemElaboracionID")]
        public int ProgramacionItemElaboracionId { get; set; }
        /// <summary>
        /// CodigoID Producto que se utilizara como insumo para este item de Progrmacion 
        /// </summary>
        [Column("ProductoInsumoID")]
        public int ProductoInsumoId { get; set; }
        /// <summary>
        /// Reserva la Cantidad
        /// </summary>
        [Column(TypeName = "decimal(12, 3)")]
        public decimal CantidadStockAsignado { get; set; }
        /// <summary>
        /// Cantidad real a Utilizar
        /// </summary>
        [Column(TypeName = "decimal(12, 3)")]
        public decimal CantidadUtilizado { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }

        [ForeignKey("ProductoInsumoId")]
        [InverseProperty("ProduccionOrdenItemProgramacionInsumos")]
        public virtual ProductoPresentacion ProductoInsumo { get; set; }
        [ForeignKey("ProgramacionItemElaboracionId")]
        [InverseProperty("ProduccionOrdenItemProgramacionInsumos")]
        public virtual ProduccionOrdenItemProgramacion ProgramacionItemElaboracion { get; set; }
    }
}