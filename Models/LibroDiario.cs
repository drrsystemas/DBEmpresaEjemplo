﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_LibroDiario", IsUnique = true)]
    [Index("RendRepNro", Name = "IX_LibroDiario_1")]
    [Index("BalanceId", Name = "IX_LibroDiario_BalanceID")]
    [Index("EstaModificado", Name = "IX_LibroDiario_EstaModificado")]
    [Index("Fecha", Name = "IX_LibroDiario_Fecha")]
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_LibroDiario_MovimientoRegistro", IsUnique = true)]
    [Index("NroDiario", Name = "IX_LibroDiario_NroDiario")]
    [Index("RegistroOperacionId", Name = "IX_LibroDiario_RegistroOperacionID")]
    [Index("TipoOperacionId", Name = "IX_LibroDiario_TipoOperacionID")]
    public partial class LibroDiario
    {
        public LibroDiario()
        {
            LibroDiarioBalanceAperturaDiario = new HashSet<LibroDiarioBalance>();
            LibroDiarioBalanceCierreDiario = new HashSet<LibroDiarioBalance>();
            LibroDiarioBalanceRefundDiario = new HashSet<LibroDiarioBalance>();
            LibroDiarioItem = new HashSet<LibroDiarioItem>();
            PlanDeCuentaInventarioAsiento = new HashSet<PlanDeCuentaInventarioAsiento>();
        }

        [Key]
        [Column("DiarioID")]
        public int DiarioId { get; set; }
        public int? NroDiario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        [Column("TipoOperacionID")]
        public byte? TipoOperacionId { get; set; }
        [Column("RegistroOperacionID")]
        public int? RegistroOperacionId { get; set; }
        /// <summary>
        /// null o 0- Vinculado con el comprobante, 1- Respeta los cambios realizados
        /// </summary>
        public byte? EstaModificado { get; set; }
        [Column("BalanceID")]
        public int? BalanceId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaImputacion { get; set; }
        /// <summary>
        /// Indica la fecha y hora de la ultima ves q se proceso, En caso de esta fecha sea mayor a la del balance vinculado, marca el balance como pendiente de Procesar)
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Procesado { get; set; }
        [Column("DiarioAgrupID")]
        public int? DiarioAgrupId { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("ProyectoID")]
        public short? ProyectoId { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("ResumenID")]
        public int? ResumenId { get; set; }
        public int? RendRepNro { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("LibroDiario")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("BalanceId")]
        [InverseProperty("LibroDiario")]
        public virtual LibroDiarioBalance Balance { get; set; }
        [ForeignKey("DiarioAgrupId")]
        [InverseProperty("LibroDiario")]
        public virtual LibroDiarioAgrupado DiarioAgrup { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("LibroDiario")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("LibroDiario")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("LibroDiario")]
        public virtual OperacionPago OperacionPago { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("LibroDiario")]
        public virtual OperacionVenta OperacionVenta { get; set; }
        [ForeignKey("ProyectoId")]
        [InverseProperty("LibroDiario")]
        public virtual Proyecto Proyecto { get; set; }
        [ForeignKey("ResumenId")]
        [InverseProperty("LibroDiario")]
        public virtual OperacionResumen Resumen { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("LibroDiario")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("LibroDiario")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("AperturaDiario")]
        public virtual ICollection<LibroDiarioBalance> LibroDiarioBalanceAperturaDiario { get; set; }
        [InverseProperty("CierreDiario")]
        public virtual ICollection<LibroDiarioBalance> LibroDiarioBalanceCierreDiario { get; set; }
        [InverseProperty("RefundDiario")]
        public virtual ICollection<LibroDiarioBalance> LibroDiarioBalanceRefundDiario { get; set; }
        [InverseProperty("Diario")]
        public virtual ICollection<LibroDiarioItem> LibroDiarioItem { get; set; }
        [InverseProperty("Diario")]
        public virtual ICollection<PlanDeCuentaInventarioAsiento> PlanDeCuentaInventarioAsiento { get; set; }
    }
}