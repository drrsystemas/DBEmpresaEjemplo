// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("TipoOperacionId", "RendicionId", Name = "IX_OperacionRendicion", IsUnique = true)]
    public partial class OperacionRendicion
    {
        public OperacionRendicion()
        {
            EncuestaRespuesta = new HashSet<EncuestaRespuesta>();
            OperacionRendicionBilletes = new HashSet<OperacionRendicionBilletes>();
            OperacionRendicionDetalle = new HashSet<OperacionRendicionDetalle>();
            OperacionRendicionPase = new HashSet<OperacionRendicionPase>();
            OperacionValeContra = new HashSet<OperacionValeContra>();
        }

        /// <summary>
        /// Nro Rendicion de Caja
        /// </summary>
        [Key]
        [Column("RendicionID")]
        public int RendicionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRedicion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodoDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodoHasta { get; set; }
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        /// <summary>
        /// Filtrado por Talonario
        /// </summary>
        [Column("FiltroTalonarioID")]
        public short? FiltroTalonarioId { get; set; }
        /// <summary>
        /// Filtra por NrodeTicket Z
        /// </summary>
        [Column("FiltroZNro")]
        public short? FiltroZnro { get; set; }
        /// <summary>
        /// Filtra por Vendedor/Cajero
        /// </summary>
        [Column("FiltroVendedorID")]
        public int? FiltroVendedorId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string Detalle { get; set; }
        /// <summary>
        /// 0-Resumen Cerrado no permite edicion 1-Esta en Proceso (permite editar Operaciones Relacionadas)  100 null-No Vinculante
        /// </summary>
        [Column("RendicionEstadoID")]
        public byte? RendicionEstadoId { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("ProyectoID")]
        public short? ProyectoId { get; set; }
        [Column("PagoTipoOperacionID")]
        public byte? PagoTipoOperacionId { get; set; }
        /// <summary>
        /// Nro Pago en el que se realizo el pase
        /// </summary>
        [Column("PagoID")]
        public int? PagoId { get; set; }
        /// <summary>
        /// Indica que al procesar se deben buscar todos los pagos (Pases)del mismo punto de venta
        /// </summary>
        public bool? IncluyePago { get; set; }
        /// <summary>
        /// Indica q a procesar se incluyen todos los cobros del mismo putno de venta
        /// </summary>
        public bool? IncluyeCobro { get; set; }
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OperacionRendicion")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("FiltroVendedorId")]
        [InverseProperty("OperacionRendicion")]
        public virtual Vendedor FiltroVendedor { get; set; }
        [ForeignKey("PagoTipoOperacionId,PagoId")]
        [InverseProperty("OperacionRendicion")]
        public virtual OperacionPago Pago { get; set; }
        [ForeignKey("ProyectoId")]
        [InverseProperty("OperacionRendicion")]
        public virtual Proyecto Proyecto { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OperacionRendicion")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("OperacionRendicion")]
        public virtual Sucursal Sucursal { get; set; }
        public virtual OperacionAltaModicacion OperacionAltaModicacion { get; set; }
        public virtual ICollection<EncuestaRespuesta> EncuestaRespuesta { get; set; }
        [InverseProperty("Rendicion")]
        public virtual ICollection<OperacionRendicionBilletes> OperacionRendicionBilletes { get; set; }
        [InverseProperty("Rendicion")]
        public virtual ICollection<OperacionRendicionDetalle> OperacionRendicionDetalle { get; set; }
        [InverseProperty("Rendicion")]
        public virtual ICollection<OperacionRendicionPase> OperacionRendicionPase { get; set; }
        [InverseProperty("Rendicion")]
        public virtual ICollection<OperacionValeContra> OperacionValeContra { get; set; }
    }
}