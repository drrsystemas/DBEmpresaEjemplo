﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class DonacionInstitucion
    {
        [Key]
        [Column("RegistroDonacionID")]
        public int RegistroDonacionId { get; set; }
        /// <summary>
        /// Indica a q institucion se designa el pago (vuelto)
        /// </summary>
        [Column("InstitucionBeneficenciaID")]
        public int? InstitucionBeneficenciaId { get; set; }
        /// <summary>
        /// Importe de la Donacion
        /// </summary>
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Importe { get; set; }
        /// <summary>
        /// Nro de Cuit/ Nro Documento, Cedula etc.
        /// </summary>
        public long? NroIdentificacion { get; set; }
        /// <summary>
        /// Nombre persona o entidad q realizo la donacion
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string Donante { get; set; }
        /// <summary>
        /// Nro del registro del Pago realizado, por el cual se registro el vuelto a la entidad
        /// </summary>
        [Column("RegistroPagoID")]
        public int? RegistroPagoId { get; set; }
        /// <summary>
        /// oden de pago con la q se liquido la donacion a la institucion de Beneficicencia
        /// </summary>
        [Column("PagoID")]
        public int? PagoId { get; set; }
        public int? Filer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHora { get; set; }
        [Column("TerminalID")]
        public short? TerminalId { get; set; }
        [Column("TipoOperacionID")]
        public byte? TipoOperacionId { get; set; }

        [ForeignKey("TipoOperacionId,PagoId")]
        [InverseProperty("DonacionInstitucion")]
        public virtual OperacionPago OperacionPago { get; set; }
        [ForeignKey("RegistroPagoId")]
        [InverseProperty("DonacionInstitucion")]
        public virtual OperacionDetallePago RegistroPago { get; set; }
        [ForeignKey("TerminalId")]
        [InverseProperty("DonacionInstitucion")]
        public virtual SincronizacionTerminal Terminal { get; set; }
    }
}