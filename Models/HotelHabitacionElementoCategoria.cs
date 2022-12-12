﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class HotelHabitacionElementoCategoria
    {
        public HotelHabitacionElementoCategoria()
        {
            HotelElemento = new HashSet<HotelElemento>();
        }

        [Key]
        [Column("ElementoCategoriaID")]
        public short ElementoCategoriaId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [StringLength(10)]
        public string Orden { get; set; }

        [InverseProperty("ElementoCategoria")]
        public virtual ICollection<HotelElemento> HotelElemento { get; set; }
    }
}