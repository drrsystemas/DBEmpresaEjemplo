﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("CtaCteRegId", Name = "IX_CuentaCorrienteCancelacion_CtaCteRegID")]
    [Index("RegistroOperacionId", Name = "IX_CuentaCorrienteCancelacion_RegistroOperacionID")]
    [Index("TipoOperacionId", Name = "IX_CuentaCorrienteCancelacion_TipoOperacionID")]
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_CuentaCorrienteCancelacion_TipoOperacionID_RegistroOperacionID")]
    public partial class CuentaCorrienteCancelacion
    {
        /// <summary>
        /// Importe que se Paga/Ingresa
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImportePago { get; set; }
        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros) de AlmaNET.OperacionTipo
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Nro Registro de la Operacion que Realiza la cancelacion
        /// </summary>
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        /// <summary>
        /// Registro UNICO
        /// </summary>
        [Key]
        [Column("CtaCtePagoID")]
        public int CtaCtePagoId { get; set; }
        /// <summary>
        /// Registro de Cuenta Corriente q se paga
        /// </summary>
        [Column("CtaCteRegID")]
        public int CtaCteRegId { get; set; }
        /// <summary>
        /// Permite ingresar alguna referencia subre la cancelacion de esta deuda
        /// </summary>
        [StringLength(150)]
        [Unicode(false)]
        public string Detalle { get; set; }

        [ForeignKey("CtaCteRegId")]
        [InverseProperty("CuentaCorrienteCancelacion")]
        public virtual CuentaCorrienteRegistro CtaCteReg { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("CuentaCorrienteCancelacion")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("CuentaCorrienteCancelacion")]
        public virtual OperacionPago OperacionPago { get; set; }
    }
}