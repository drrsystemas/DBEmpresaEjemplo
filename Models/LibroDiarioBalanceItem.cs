// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class LibroDiarioBalanceItem
    {
        [Key]
        [Column("BalanceItemID")]
        public int BalanceItemId { get; set; }
        [Column("BalanceID")]
        public int BalanceId { get; set; }
        /// <summary>
        /// Autoincremeta
        /// </summary>
        [Column("CuentaTotalizID")]
        public int CuentaTotalizId { get; set; }
        /// <summary>
        /// Codigo Cuenta
        /// </summary>
        [Column("CuentaID")]
        public int? CuentaId { get; set; }
        /// <summary>
        /// Desglose a utilizar para el Balance 0-No hace desglose, 1-Desglosa Pors Sucursal, 2-Desglosa por Sector,3-Desglosa por Proyecto, 4-Desglosa por entidad 
        /// </summary>
        public byte? DesgloseNivel1 { get; set; }
        /// <summary>
        /// Desglose a utilizar para el Balance 0-No hace desglose, 1-Desglosa Pors Sucursal, 2-Desglosa por Sector,3-Desglosa por Proyecto, 4-Desglosa por entidad 
        /// </summary>
        public byte? DesgloseNivel2 { get; set; }
        /// <summary>
        /// Desglose a utilizar para el Balance 0-No hace desglose, 1-Desglosa Pors Sucursal, 2-Desglosa por Sector,3-Desglosa por Proyecto, 4-Desglosa por entidad 
        /// </summary>
        public byte? DesgloseNivel3 { get; set; }
        /// <summary>
        /// Desglose a utilizar para el Balance 0-No hace desglose, 1-Desglosa Pors Sucursal, 2-Desglosa por Sector,3-Desglosa por Proyecto, 4-Desglosa por entidad 
        /// </summary>
        public byte? DesgloseNivel4 { get; set; }
        /// <summary>
        /// Almacena el ID correspondiente al tipo desglose seleccionado para DesgloseNivel1
        /// </summary>
        [Column("Desglose1ID")]
        public int? Desglose1Id { get; set; }
        /// <summary>
        /// Almacena el ID correspondiente al tipo desglose seleccionado para DesgloseNivel2
        /// </summary>
        [Column("Desglose2ID")]
        public int? Desglose2Id { get; set; }
        /// <summary>
        /// Almacena el ID correspondiente al tipo desglose seleccionado para DesgloseNivel1
        /// </summary>
        [Column("Desglose3ID")]
        public int? Desglose3Id { get; set; }
        /// <summary>
        /// Almacena el ID correspondiente al tipo desglose seleccionado para DesgloseNivel1
        /// </summary>
        [Column("Desglose4ID")]
        public int? Desglose4Id { get; set; }
        /// <summary>
        /// Indica el importe total del Item en el Balance Positivo Saldo Deudo,Negativo Saldo Haber
        /// 
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Importe { get; set; }
        public int? OrdenPresentacion { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string NotaComplementaria { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteDebe { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteHaber { get; set; }
        /// <summary>
        /// Indico el nivel Jeraquico (Anidamiento)
        /// </summary>
        public byte? NivelAnidamineto { get; set; }
        [Column(TypeName = "money")]
        public decimal? SaldoArrastre { get; set; }

        [ForeignKey("BalanceId")]
        [InverseProperty("LibroDiarioBalanceItem")]
        public virtual LibroDiarioBalance Balance { get; set; }
        [ForeignKey("CuentaId")]
        [InverseProperty("LibroDiarioBalanceItem")]
        public virtual PlanDeCuenta Cuenta { get; set; }
    }
}