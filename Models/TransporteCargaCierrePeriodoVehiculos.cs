// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TransporteCargaCierrePeriodoVehiculos
    {
        public TransporteCargaCierrePeriodoVehiculos()
        {
            TransporteCargaCierrePeriodoDetalle = new HashSet<TransporteCargaCierrePeriodoDetalle>();
        }

        [Key]
        [Column("CierreVehiculoID")]
        public int CierreVehiculoId { get; set; }
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("VehiculoID")]
        public int VehiculoId { get; set; }
        public int? KmRecorridos { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? LitrosCombustible { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? HorasTaller { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalCubiertas { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalDespachos { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalOrdenServicio { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalFacturacion { get; set; }

        [ForeignKey("RegistroId")]
        [InverseProperty("TransporteCargaCierrePeriodoVehiculos")]
        public virtual TransporteCargaCierrePeriodo Registro { get; set; }
        [ForeignKey("VehiculoId")]
        [InverseProperty("TransporteCargaCierrePeriodoVehiculos")]
        public virtual TransporteVehiculo Vehiculo { get; set; }
        [InverseProperty("CierreVehiculo")]
        public virtual ICollection<TransporteCargaCierrePeriodoDetalle> TransporteCargaCierrePeriodoDetalle { get; set; }
    }
}