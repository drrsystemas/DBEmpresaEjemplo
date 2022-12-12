﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class TableroControl
    {
        [Key]
        [Column("TableroControlID")]
        public int TableroControlId { get; set; }
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Unicode(false)]
        public string Detalle { get; set; }
        [Required]
        [Column("URL")]
        [StringLength(500)]
        [Unicode(false)]
        public string Url { get; set; }
    }
}