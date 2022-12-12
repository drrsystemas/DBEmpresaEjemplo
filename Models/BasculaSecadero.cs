﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class BasculaSecadero
    {
        public BasculaSecadero()
        {
            BasculaPesaje = new HashSet<BasculaPesaje>();
        }

        [Key]
        [Column("SecaderoID")]
        public short SecaderoId { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [InverseProperty("Secadero")]
        public virtual ICollection<BasculaPesaje> BasculaPesaje { get; set; }
    }
}