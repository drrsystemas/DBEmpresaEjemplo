﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TransporteVehiculoTipoCarga
    {
        [Key]
        [Column("VehiculoTipoCargaID")]
        public int VehiculoTipoCargaId { get; set; }
        [Column("VehiculoID")]
        public int VehiculoId { get; set; }
        [Column("TipoCargaID")]
        public short TipoCargaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }

        [ForeignKey("TipoCargaId")]
        [InverseProperty("TransporteVehiculoTipoCarga")]
        public virtual TransporteTipoCarga TipoCarga { get; set; }
        [ForeignKey("VehiculoId")]
        [InverseProperty("TransporteVehiculoTipoCarga")]
        public virtual TransporteVehiculo Vehiculo { get; set; }
    }
}