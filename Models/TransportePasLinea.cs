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
    /// Trasnporte Pasajero Lineas  (se cargan los dintintos recorridos y se indica cual es el Recorido a realizar por cada Colectivo)
    /// </summary>
    [Index("Descripcion", Name = "IX_TransportePasLinea_Descripcion")]
    public partial class TransportePasLinea
    {
        public TransportePasLinea()
        {
            TransportePasLineaRecorrido = new HashSet<TransportePasLineaRecorrido>();
        }

        [Key]
        [Column("LineaID")]
        public int LineaId { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// Se detalla datos referidos a la Linea,
        /// </summary>
        [Unicode(false)]
        public string Detalle { get; set; }
        public TimeSpan IntermitenciaVehiculos { get; set; }

        [InverseProperty("Linea")]
        public virtual ICollection<TransportePasLineaRecorrido> TransportePasLineaRecorrido { get; set; }
    }
}