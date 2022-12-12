﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionImpresionUsuario
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("TipoOperacionID")]
        public short TipoOperacionId { get; set; }
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OperacionImpresionUsuario")]
        public virtual Usuario AlmaUser { get; set; }
    }
}