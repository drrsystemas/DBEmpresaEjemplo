﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Utilizado para asiganar los permisos de usuo para cada talonraio
    /// </summary>
    public partial class OperacionRegistroUsoTalonario
    {
        [Key]
        public int Registro { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("RegistroTalonarioID")]
        public int RegistroTalonarioId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OperacionRegistroUsoTalonario")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("RegistroTalonarioId")]
        [InverseProperty("OperacionRegistroUsoTalonario")]
        public virtual OperacionTalonarioNumeracion RegistroTalonario { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OperacionRegistroUsoTalonario")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("OperacionRegistroUsoTalonario")]
        public virtual Sucursal Sucursal { get; set; }
    }
}