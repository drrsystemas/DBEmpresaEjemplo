﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ImpresionRegistro
    {
        /// <summary>
        /// En que se registro la impresion
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        /// <summary>
        /// Terminal desde la que se dio la Orden de Impresion
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Computer { get; set; }
        /// <summary>
        /// Contador Registros
        /// </summary>
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        [Required]
        [StringLength(150)]
        public string Reporte { get; set; }
        [StringLength(250)]
        public string Detalle { get; set; }
        public byte GeneracionTipo { get; set; }
    }
}