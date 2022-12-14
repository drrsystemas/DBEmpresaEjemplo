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
    /// lleva el registro de uso de talonarios por cadaUsuario de Alma
    /// </summary>
    [Index("AlmaUserId", "TipoOperacionId", "ComprobanteId", "EmpresaId", Name = "IX_OperacionRegistroUsoComprobantes", IsUnique = true)]
    public partial class OperacionRegistroUsoComprobantes
    {
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        [Key]
        public int Registro { get; set; }
        /// <summary>
        /// Almacena el Ultimo Comprobante y talonrio Utilizado por el Usuario
        /// </summary>
        [Column("RegistroTalonarioID")]
        public int RegistroTalonarioId { get; set; }
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros) de AlmaNET.OperacionTipo
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Indico empresa en la que se utilizo el talonario
        /// </summary>
        [Column("EmpresaID")]
        public int? EmpresaId { get; set; }

        [ForeignKey("RegistroTalonarioId")]
        [InverseProperty("OperacionRegistroUsoComprobantes")]
        public virtual OperacionTalonarioNumeracion RegistroTalonario { get; set; }
    }
}