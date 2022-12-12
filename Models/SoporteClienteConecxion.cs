﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ClienteId", Name = "IX_SoporteClienteConecxion_ClienteID")]
    public partial class SoporteClienteConecxion
    {
        [Column("ClienteID")]
        public int ClienteId { get; set; }
        /// <summary>
        /// Indica la COnexion, Escritorio Remoto, IP y/o Teamviewer (Ver Formato), R:
        /// </summary>
        [Required]
        [Column("IP_Conexion")]
        [StringLength(100)]
        [Unicode(false)]
        public string IpConexion { get; set; }
        [Key]
        [Column("ConexionSopID")]
        public int ConexionSopId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string PaswordAcceso { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("SoporteClienteConecxion")]
        public virtual Cliente Cliente { get; set; }
    }
}