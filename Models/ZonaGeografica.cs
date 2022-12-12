﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_ZonaGeografica_Descripcion")]
    [Index("Orden", Name = "IX_ZonaGeografica_Orden")]
    [Index("ZonaHierarchy", Name = "IX_ZonaGeografica_ZonaHierarchy")]
    public partial class ZonaGeografica
    {
        public ZonaGeografica()
        {
            EntidadSucursal = new HashSet<EntidadSucursal>();
            Proyecto = new HashSet<Proyecto>();
            TransporteMovimientoDestino = new HashSet<TransporteMovimientoDestino>();
        }

        /// <summary>
        /// Codigo Zona
        /// </summary>
        [Key]
        [Column("ZonaID")]
        public int ZonaId { get; set; }
        /// <summary>
        /// Descripcion de la Zona
        /// </summary>
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(12, 6)")]
        public decimal? LatitudInicio { get; set; }
        [Column(TypeName = "decimal(12, 6)")]
        public decimal? LongitudInicio { get; set; }
        [Column(TypeName = "decimal(12, 6)")]
        public decimal? LatitudFinal { get; set; }
        [Column(TypeName = "decimal(12, 6)")]
        public decimal? LongitudFinal { get; set; }
        /// <summary>
        /// Clasificacion de Zonas en Forma Jerarquica  ejem 1.2.3
        /// </summary>
        [StringLength(80)]
        [Unicode(false)]
        public string ZonaHierarchy { get; set; }
        /// <summary>
        /// Nro de Familia que se le asigna (Se comienza a emumerar  de 1 a por cada Familia) nu puede repetirse el mismo numero de familia en una misma SubFamiliaDe
        /// </summary>
        public int ZonaNro { get; set; }
        /// <summary>
        /// Idem a Familia Completo pero rellena con 0 para que quede correctamete ordenado los Registros ([dbo].[HerarchyOrder]([FamiliaCompleto]))
        /// </summary>
        public string Orden { get; set; }

        [InverseProperty("Zona")]
        public virtual ICollection<EntidadSucursal> EntidadSucursal { get; set; }
        [InverseProperty("Zona")]
        public virtual ICollection<Proyecto> Proyecto { get; set; }
        [InverseProperty("Zona")]
        public virtual ICollection<TransporteMovimientoDestino> TransporteMovimientoDestino { get; set; }
    }
}