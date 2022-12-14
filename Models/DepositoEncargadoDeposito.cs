// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Indico cuales son los encargados para cada Deposito
    /// </summary>
    public partial class DepositoEncargadoDeposito
    {
        [Key]
        public int Registro { get; set; }
        [Column("EncargDepositoID")]
        public int EncargDepositoId { get; set; }
        /// <summary>
        /// Nro de Deposito
        /// </summary>
        [Column("DepositoID")]
        public short DepositoId { get; set; }
        public short? StockTipo { get; set; }

        [ForeignKey("DepositoId")]
        [InverseProperty("DepositoEncargadoDeposito")]
        public virtual Deposito Deposito { get; set; }
        [ForeignKey("EncargDepositoId")]
        [InverseProperty("DepositoEncargadoDeposito")]
        public virtual DepositoEncargado EncargDeposito { get; set; }
    }
}