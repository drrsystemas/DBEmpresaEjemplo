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
    /// Refiere a los impuestos por Zona del Vendedor
    /// </summary>
    [Index("EmpresaId", "ZonaImpuestoId", Name = "IX_EmpresaImpuestoZona", IsUnique = true)]
    [Index("EmpresaId", Name = "IX_EmpresaImpuestoZona_EmpresaID")]
    public partial class EmpresaImpuestoZona
    {
        public EmpresaImpuestoZona()
        {
            TransporteOrigenDestino = new HashSet<TransporteOrigenDestino>();
        }

        [Column("EmpresaID")]
        public int EmpresaId { get; set; }
        /// <summary>
        /// Se obtiene de AlmaNET
        /// </summary>
        [Column("ZonaImpuestoID")]
        public short ZonaImpuestoId { get; set; }
        /// <summary>
        /// Utiliza el espscificado en AlmaNET.ImpuestoPorZonaComprador en caso de estar en Null
        /// </summary>
        [Column(TypeName = "decimal(8, 3)")]
        public decimal? PorcImpuesto { get; set; }
        /// <summary>
        /// N° de Sucursal
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        /// <summary>
        /// Indica si el impuesto tambien aplica para Operaciones donde no se especifico SucursalID (Null)
        /// </summary>
        public bool AplicaCasaCentral { get; set; }
        [Key]
        [Column("RegistroImpZonaID")]
        public int RegistroImpZonaId { get; set; }

        [ForeignKey("EmpresaId")]
        [InverseProperty("EmpresaImpuestoZona")]
        public virtual EmpresaDatos Empresa { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("EmpresaImpuestoZona")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("RegistroImpZona")]
        public virtual ICollection<TransporteOrigenDestino> TransporteOrigenDestino { get; set; }
    }
}