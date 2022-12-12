﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class BuscarConfiguracion
    {
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string DatoBuscar { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Campo { get; set; }
        /// <summary>
        /// 0-Completa 1-Primeras Letras 2-Exacto
        /// </summary>
        public byte TipoBusqueda { get; set; }
        public bool MayusculasMinusculas { get; set; }
        [Required]
        [Unicode(false)]
        public string Condicion { get; set; }
        [Key]
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        [Key]
        [Column("TableID")]
        public int TableId { get; set; }
        public bool EsOpcionesAvanzadas { get; set; }
        public bool EsMasOpciones { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("BuscarConfiguracion")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("TableId")]
        [InverseProperty("BuscarConfiguracion")]
        public virtual TableDb Table { get; set; }
    }
}