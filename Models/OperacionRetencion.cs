﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("RegistroPagoId", Name = "IX_OperacionRetencionRegistroPagoID")]
    [Index("IdconceptoCarga", Name = "IX_OperacionRetencion_IDConceptoCarga")]
    public partial class OperacionRetencion
    {
        public OperacionRetencion()
        {
            OperacionRetencionFacturas = new HashSet<OperacionRetencionFacturas>();
        }

        [Key]
        [Column("RetencionID")]
        public int RetencionId { get; set; }
        public int? CodRegimen { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteSujetoRetencion { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteRetener { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Concepto { get; set; }
        public int? NroComprobante { get; set; }
        [Column("IDConceptoCarga")]
        public short? IdconceptoCarga { get; set; }
        /// <summary>
        /// Nro del registro del Pago realizado
        /// </summary>
        [Column("RegistroPagoID")]
        public int? RegistroPagoId { get; set; }
        /// <summary>
        /// Tipo de comprobante a ser  utilizado para este pediodo
        /// </summary>
        [Column("ComprobanteID")]
        public short? ComprobanteId { get; set; }
        /// <summary>
        /// Nro Talonario al que pertenece la Numeracion del comprobante
        /// </summary>
        [Column("TalonarioID")]
        public short? TalonarioId { get; set; }
        [Column("ImpuestoID")]
        public short? ImpuestoId { get; set; }
        /// <summary>
        /// Indico sub categoria del Impuesto (Ver retenciones, ganancia, IVA)
        /// </summary>
        [Column("ImpDesgID")]
        public byte? ImpDesgId { get; set; }
        /// <summary>
        /// Fecha para informe (si es null tiene q tomar la fecha del Pago/Cobro)
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }
        [Column("TipoOperacionID")]
        public byte? TipoOperacionId { get; set; }
        /// <summary>
        /// EntidadSucursal a la q pertenece
        /// </summary>
        [Column("EntidadSucID")]
        public int? EntidadSucId { get; set; }
        /// <summary>
        /// null o 0- indica que aplica calculo automatico , Otro valor calculo manual
        /// </summary>
        [Column("ModifacionTipoID")]
        public byte? ModifacionTipoId { get; set; }
        [Column(TypeName = "decimal(8, 3)")]
        public decimal? PorcentajeAplicar { get; set; }
        /// <summary>
        /// Se utliza para el caso de aplicar retencion en bbase a cantidad ver C.C.G. (conv. Corresp. gremial) , retenc Yerba en liquidacion
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImporteUnidad { get; set; }

        [ForeignKey("EntidadSucId")]
        [InverseProperty("OperacionRetencion")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
        [ForeignKey("IdconceptoCarga")]
        [InverseProperty("OperacionRetencion")]
        public virtual TransporteCargaAdicionales IdconceptoCargaNavigation { get; set; }
        [ForeignKey("ImpuestoId")]
        [InverseProperty("OperacionRetencion")]
        public virtual Impuesto Impuesto { get; set; }
        [ForeignKey("RegistroPagoId")]
        [InverseProperty("OperacionRetencion")]
        public virtual OperacionDetallePago RegistroPago { get; set; }
        [InverseProperty("Retencion")]
        public virtual ICollection<OperacionRetencionFacturas> OperacionRetencionFacturas { get; set; }
    }
}