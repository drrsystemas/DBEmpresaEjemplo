﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_TransportePasEnteCarnetTipo_Descripcion")]
    [Index("ProductoPrecioId", Name = "IX_TransportePasEnteCarnetTipo_ProductoPrecioID")]
    public partial class TransportePasEnteCarnetTipo
    {
        public TransportePasEnteCarnetTipo()
        {
            TransportePasCarnet = new HashSet<TransportePasCarnet>();
        }

        [Key]
        [Column("EnteCarnetTIpoID")]
        public short EnteCarnetTipoId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// CodigoPrecio para un producto en Deteminada Presentacion y lista de precio
        /// </summary>
        [Column("ProductoPrecioID")]
        public int? ProductoPrecioId { get; set; }
        public byte[] Reporte { get; set; }

        [ForeignKey("ProductoPrecioId")]
        [InverseProperty("TransportePasEnteCarnetTipo")]
        public virtual ProductoListaPrecio ProductoPrecio { get; set; }
        [InverseProperty("EnteCarnetTipo")]
        public virtual ICollection<TransportePasCarnet> TransportePasCarnet { get; set; }
    }
}