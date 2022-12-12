﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TransporteCombustibleConsumoVehiculo
    {
        [Key]
        [Column("RegConsumoVehiculoID")]
        public int RegConsumoVehiculoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        [Column("VehiculoID")]
        public int VehiculoId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Litros { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Km { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Consumo { get; set; }
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        public byte PeriodoMes { get; set; }
        public short PeriodoAno { get; set; }
        [Column("TipoCargaID")]
        public short? TipoCargaId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("TransporteCombustibleConsumoVehiculo")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("TipoCargaId")]
        [InverseProperty("TransporteCombustibleConsumoVehiculo")]
        public virtual TransporteTipoCarga TipoCarga { get; set; }
        [ForeignKey("VehiculoId")]
        [InverseProperty("TransporteCombustibleConsumoVehiculo")]
        public virtual TransporteVehiculo Vehiculo { get; set; }
    }
}