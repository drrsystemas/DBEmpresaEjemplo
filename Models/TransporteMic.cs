﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Table("TransporteMIC")]
    [Index("AduanaId", Name = "IX_TransporteMIC_AduanaID")]
    [Index("AutoizacionCargaId", Name = "IX_TransporteMIC_AutoizacionCargaID")]
    [Index("Crtmicid", Name = "IX_TransporteMIC_CRTMICID")]
    [Index("ConductorId", Name = "IX_TransporteMIC_ConductorID")]
    [Index("SucursalId", Name = "IX_TransporteMIC_SucursalID")]
    public partial class TransporteMic
    {
        public TransporteMic()
        {
            TransporteMiccrt = new HashSet<TransporteMiccrt>();
        }

        [Key]
        [Column("MIC_ID")]
        public int MicId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }
        [Column("PaisID")]
        public short? PaisId { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("M6FechaMIC", TypeName = "datetime")]
        public DateTime M6fechaMic { get; set; }
        [Column("CRTMICID")]
        public int Crtmicid { get; set; }
        [Column("AutoizacionCargaID")]
        public int? AutoizacionCargaId { get; set; }
        [Column("M1Porteador")]
        [StringLength(300)]
        [Unicode(false)]
        public string M1porteador { get; set; }
        [Column("M2RolContribuyente")]
        public long? M2rolContribuyente { get; set; }
        [Column("M3TransitoAduanero")]
        public bool M3transitoAduanero { get; set; }
        [Column("M7AduanaOrigen")]
        [StringLength(150)]
        [Unicode(false)]
        public string M7aduanaOrigen { get; set; }
        [Column("M8Destino")]
        [StringLength(150)]
        [Unicode(false)]
        public string M8destino { get; set; }
        [Column("M9PropietarioCamionOr")]
        [StringLength(300)]
        [Unicode(false)]
        public string M9propietarioCamionOr { get; set; }
        [Column("M10RolContribuyente")]
        public long? M10rolContribuyente { get; set; }
        [Column("M11PlacaCamion")]
        [StringLength(30)]
        [Unicode(false)]
        public string M11placaCamion { get; set; }
        [Column("M12MarcaVehiculo")]
        [StringLength(150)]
        [Unicode(false)]
        public string M12marcaVehiculo { get; set; }
        [Column("M13Capacidad")]
        [StringLength(30)]
        [Unicode(false)]
        public string M13capacidad { get; set; }
        [Column("M14AñoModelo")]
        public int? M14añoModelo { get; set; }
        [Column("M15PlacaSemi")]
        [StringLength(30)]
        [Unicode(false)]
        public string M15placaSemi { get; set; }
        [Column("M15EsSemi")]
        public bool? M15esSemi { get; set; }
        [Column("M16PropietarioCamionSus")]
        [StringLength(300)]
        [Unicode(false)]
        public string M16propietarioCamionSus { get; set; }
        [Column("M17RolContribuyente")]
        public long? M17rolContribuyente { get; set; }
        [Column("M18PlacaCamion")]
        [StringLength(30)]
        [Unicode(false)]
        public string M18placaCamion { get; set; }
        [Column("M19MarcaVehiculo")]
        [StringLength(150)]
        [Unicode(false)]
        public string M19marcaVehiculo { get; set; }
        [Column("M20Capacidad")]
        [StringLength(30)]
        [Unicode(false)]
        public string M20capacidad { get; set; }
        [Column("M21AñoModelo")]
        public int? M21añoModelo { get; set; }
        [Column("M22PlacaSemi")]
        [StringLength(30)]
        [Unicode(false)]
        public string M22placaSemi { get; set; }
        [Column("M22EsSemi")]
        public bool? M22esSemi { get; set; }
        [Column("ConductorID")]
        public int? ConductorId { get; set; }
        [Column("AduanaID")]
        public int? AduanaId { get; set; }
        [Column("M7CodigoAduana")]
        [StringLength(30)]
        [Unicode(false)]
        public string M7codigoAduana { get; set; }
        [Column("M8CodPaisDestino")]
        public short? M8codPaisDestino { get; set; }
        [Column("M39FirmaPorteador")]
        [StringLength(150)]
        [Unicode(false)]
        public string M39firmaPorteador { get; set; }
        [Column("M40NroDTA")]
        [Unicode(false)]
        public string M40nroDta { get; set; }

        [ForeignKey("AduanaId")]
        [InverseProperty("TransporteMic")]
        public virtual TransporteAduana Aduana { get; set; }
        [ForeignKey("AutoizacionCargaId")]
        [InverseProperty("TransporteMic")]
        public virtual TransporteAutorizacionCarga AutoizacionCarga { get; set; }
        [ForeignKey("ConductorId")]
        [InverseProperty("TransporteMic")]
        public virtual TransporteConductor Conductor { get; set; }
        [ForeignKey("Crtmicid")]
        [InverseProperty("TransporteMic")]
        public virtual PermisoEmpresaNroCrtmic Crtmic { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("TransporteMic")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("Mic")]
        public virtual ICollection<TransporteMiccrt> TransporteMiccrt { get; set; }
    }
}