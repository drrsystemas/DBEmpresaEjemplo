﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ClienteId", Name = "IX_ClienteVendedor_ClienteID")]
    [Index("VendedorId", Name = "IX_ClienteVendedor_VendedorID")]
    public partial class ClienteVendedor
    {
        /// <summary>
        /// Cliente al que esta relacionado
        /// </summary>
        [Column("ClienteID")]
        public int ClienteId { get; set; }
        /// <summary>
        /// Codigo Vendedor
        /// </summary>
        [Column("VendedorID")]
        public int VendedorId { get; set; }
        /// <summary>
        /// % Comision q percibe por las ventas a este Cliente
        /// </summary>
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? Comicion { get; set; }
        /// <summary>
        /// Campo unico
        /// </summary>
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        /// <summary>
        /// Refiere a si la visita del vendedor es Semal, menual, etc
        /// </summary>
        public byte TipoVisita { get; set; }
        /// <summary>
        /// Binario q indica dias de Visita
        /// </summary>
        public int DiaVisita { get; set; }
        [Column("ProveedorID")]
        public int? ProveedorId { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("ClienteVendedor")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("ProveedorId")]
        [InverseProperty("ClienteVendedor")]
        public virtual Proveedor Proveedor { get; set; }
        [ForeignKey("VendedorId")]
        [InverseProperty("ClienteVendedor")]
        public virtual Vendedor Vendedor { get; set; }
    }
}