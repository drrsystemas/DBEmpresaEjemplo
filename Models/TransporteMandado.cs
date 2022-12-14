// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TransporteMandado
    {
        [Key]
        [Column("MandadoID")]
        public int MandadoId { get; set; }
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        [Column("TalonarioID")]
        public short TalonarioId { get; set; }
        public int NroComprobante { get; set; }
        [Column("ServicioTipoID")]
        public byte ServicioTipoId { get; set; }
        [Required]
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaSolicitud { get; set; }
        public byte TipoPago { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        [Column("ClienteID")]
        public int? ClienteId { get; set; }
        [Column("EntidadSucIDRem")]
        public int? EntidadSucIdrem { get; set; }
        [Column("EntidadSucIDCons")]
        public int? EntidadSucIdcons { get; set; }
        [Column("RegistroDomicilioIDRem")]
        public int? RegistroDomicilioIdrem { get; set; }
        [Column("RegistroDomicilioIDCons")]
        public int? RegistroDomicilioIdcons { get; set; }
        [Column("RegistroTelefonoIDRem")]
        public int? RegistroTelefonoIdrem { get; set; }
        [Column("RegistroTelefonoIDCons")]
        public int? RegistroTelefonoIdcons { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraRetirar { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraRetirado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraEntregar { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraEntregado { get; set; }
        [Unicode(false)]
        public string ObservacionesRealizadas { get; set; }
        [Column("VehiculoIDRetira")]
        public int? VehiculoIdretira { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteFlete { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteContraReemolso { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteGasto { get; set; }
        [Column(TypeName = "money")]
        public decimal? ValorDeclarado { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImporteSeguro { get; set; }
        [Column(TypeName = "money")]
        public decimal? Comision { get; set; }
        [Column("ConductorID")]
        public int? ConductorId { get; set; }
        [Column("AlmaUserIDServicio")]
        public int? AlmaUserIdservicio { get; set; }
        [StringLength(10)]
        public string ProductoAlto { get; set; }
        [StringLength(10)]
        public string ProductoAncho { get; set; }
        [StringLength(10)]
        public string ProductoProfundidad { get; set; }
        [StringLength(10)]
        public string ProductoPeso { get; set; }
        [Column("PaqueteID")]
        [StringLength(10)]
        public string PaqueteId { get; set; }
        [StringLength(10)]
        public string Distancia { get; set; }
        [Column("TipoCargaID")]
        public short? TipoCargaId { get; set; }
        [Column("DatosXML", TypeName = "xml")]
        public string DatosXml { get; set; }
        [Column("EstadoProcesoID")]
        public byte? EstadoProcesoId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? CoeficienteAplicar { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("TransporteMandado")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("ClienteId")]
        [InverseProperty("TransporteMandado")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("ConductorId")]
        [InverseProperty("TransporteMandado")]
        public virtual TransporteConductor Conductor { get; set; }
        [ForeignKey("EntidadSucIdcons")]
        [InverseProperty("TransporteMandadoEntidadSucIdconsNavigation")]
        public virtual EntidadSucursal EntidadSucIdconsNavigation { get; set; }
        [ForeignKey("EntidadSucIdrem")]
        [InverseProperty("TransporteMandadoEntidadSucIdremNavigation")]
        public virtual EntidadSucursal EntidadSucIdremNavigation { get; set; }
        [ForeignKey("RegistroDomicilioIdcons")]
        [InverseProperty("TransporteMandadoRegistroDomicilioIdconsNavigation")]
        public virtual EntidadSucursalDomicilio RegistroDomicilioIdconsNavigation { get; set; }
        [ForeignKey("RegistroDomicilioIdrem")]
        [InverseProperty("TransporteMandadoRegistroDomicilioIdremNavigation")]
        public virtual EntidadSucursalDomicilio RegistroDomicilioIdremNavigation { get; set; }
        [ForeignKey("RegistroTelefonoIdcons")]
        [InverseProperty("TransporteMandadoRegistroTelefonoIdconsNavigation")]
        public virtual EntidadSucursalTelefono RegistroTelefonoIdconsNavigation { get; set; }
        [ForeignKey("RegistroTelefonoIdrem")]
        [InverseProperty("TransporteMandadoRegistroTelefonoIdremNavigation")]
        public virtual EntidadSucursalTelefono RegistroTelefonoIdremNavigation { get; set; }
        [ForeignKey("VehiculoIdretira")]
        [InverseProperty("TransporteMandado")]
        public virtual TransporteVehiculo VehiculoIdretiraNavigation { get; set; }
    }
}