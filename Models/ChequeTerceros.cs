// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("IngresoRegistroPagoId", "SalidaRegistroPagoId", Name = "ChequeTerceros_IngPagIDSalidaRegPagoID")]
    [Index("FechaEmision", Name = "IX_ChequeTerceros_FechaEmision")]
    [Index("IngresoRegistroPagoId", Name = "IX_ChequeTerceros_IngresoRegistroPagoID")]
    [Index("NroCheque", Name = "IX_ChequeTerceros_NroCheque")]
    [Index("SalidaRegistroPagoId", Name = "IX_ChequeTerceros_SalidaRegistroPagoID")]
    public partial class ChequeTerceros
    {
        public ChequeTerceros()
        {
            BancoTarjetaDebe = new HashSet<BancoTarjetaDebe>();
        }

        [Key]
        [Column("ChequeID")]
        public int ChequeId { get; set; }
        public long NroCheque { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaEmision { get; set; }
        [Column(TypeName = "money")]
        public decimal Importe { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaPago { get; set; }
        /// <summary>
        /// De AlmaNET.Banco
        /// </summary>
        [Column("BancoID")]
        public int? BancoId { get; set; }
        /// <summary>
        /// De AlmaNET.BancoFilial
        /// </summary>
        [Column("BancoFilialID")]
        public int? BancoFilialId { get; set; }
        /// <summary>
        /// Nombre del Banco
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string BancoDescrip { get; set; }
        /// <summary>
        /// Nro de Cuenta
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string CuentaNro { get; set; }
        /// <summary>
        /// Que tipo entidad es  Titular de la Cuenta (Cliente/Proveedor etc.)
        /// </summary>
        [Column("TitularTipoEntidadID")]
        public byte? TitularTipoEntidadId { get; set; }
        /// <summary>
        /// Cual es el Numero q corresponde al TitularTipoEntidadID
        /// </summary>
        [Column("TitularRegistroEntidadID")]
        public int? TitularRegistroEntidadId { get; set; }
        /// <summary>
        /// Nombre/Razon Social Titular de la Cuenta
        /// </summary>
        [StringLength(150)]
        [Unicode(false)]
        public string TitularCuenta { get; set; }
        /// <summary>
        /// 0-Nada 1-Fiscal 2-Documento // Se obtiene de AlmaNet EntidadNroIdentificacionTipo
        /// </summary>
        public byte TipoNroIdentificacion { get; set; }
        /// <summary>
        /// Nro de Cuit/ Nro Documento, Cedula etc.
        /// </summary>
        public long NroIdentificacion { get; set; }
        /// <summary>
        /// Codigo Ciudad
        /// </summary>
        [Column("CiudadID")]
        public int? CiudadId { get; set; }
        /// <summary>
        /// Nombre Ciudad/Localidad
        /// </summary>
        [StringLength(50)]
        public string Ciudad { get; set; }
        /// <summary>
        /// Nombre Provincia Estado
        /// </summary>
        [StringLength(50)]
        public string Provincia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRecepcion { get; set; }
        /// <summary>
        /// Nro del registro del Pago realizado por el cual Ingreso el Cheque
        /// </summary>
        [Column("IngresoRegistroPagoID")]
        public int? IngresoRegistroPagoId { get; set; }
        /// <summary>
        /// Descripcion detalle motivo por el que ingreso el Cheque
        /// </summary>
        [StringLength(250)]
        [Unicode(false)]
        public string DetalleIngreso { get; set; }
        /// <summary>
        /// Indica si el Tenedor del Cheque es el Titular de la Cuenta (Titular CUenta== a la persona q nos entrega el Cheque)
        /// </summary>
        public bool TenedorEsTitularCta { get; set; }
        /// <summary>
        /// Quien la persona q entrega el cheque
        /// </summary>
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string TenedorCheque { get; set; }
        /// <summary>
        /// Que tipo entidad es  Tenedor (Cliente/Proveedor etc.)
        /// </summary>
        [Column("TenedorTipoEntidadID")]
        public byte? TenedorTipoEntidadId { get; set; }
        /// <summary>
        /// Cual es el Numero q corresponde al TenedorTipoEntidadID
        /// </summary>
        [Column("TenedorRegistroEntidadID")]
        public int? TenedorRegistroEntidadId { get; set; }
        /// <summary>
        /// Fecha en que se dio el cheque
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FechaReemitido { get; set; }
        /// <summary>
        /// Nro del registro del Pago realizado por el cual Salio el Cheque
        /// </summary>
        [Column("SalidaRegistroPagoID")]
        public int? SalidaRegistroPagoId { get; set; }
        /// <summary>
        /// Detalle Salida Cheque
        /// </summary>
        [StringLength(250)]
        [Unicode(false)]
        public string DetalleSalida { get; set; }
        /// <summary>
        /// Que tipo entidad q es  Beneficiario/ Persona a la que se le da el Cheque (Cliente/Proveedor etc.)
        /// </summary>
        [Column("BeneficiarioTipoEntidadID")]
        public byte? BeneficiarioTipoEntidadId { get; set; }
        /// <summary>
        /// Cual es el Numero q corresponde al BeneficiarioTipoEntidadID
        /// </summary>
        [Column("BeneficiarioRegistroEntidadID")]
        public int? BeneficiarioRegistroEntidadId { get; set; }
        /// <summary>
        /// Persona q recibe el cheque
        /// </summary>
        [StringLength(150)]
        [Unicode(false)]
        public string Beneficiario { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string NroSerie { get; set; }
        [Column("MonedaID")]
        public byte? MonedaId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Cotizacion { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteMonExt { get; set; }
        public byte[] Imagen { get; set; }
        [Column("ChequeTipoID")]
        public byte? ChequeTipoId { get; set; }

        [ForeignKey("IngresoRegistroPagoId")]
        [InverseProperty("ChequeTercerosIngresoRegistroPago")]
        public virtual OperacionDetallePago IngresoRegistroPago { get; set; }
        [ForeignKey("SalidaRegistroPagoId")]
        [InverseProperty("ChequeTercerosSalidaRegistroPago")]
        public virtual OperacionDetallePago SalidaRegistroPago { get; set; }
        [InverseProperty("Cheque")]
        public virtual ICollection<BancoTarjetaDebe> BancoTarjetaDebe { get; set; }
    }
}