﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class FrigorificoAnimalTipo
    {
        public FrigorificoAnimalTipo()
        {
            FrigorificoAnimaIngresolProducto = new HashSet<FrigorificoAnimaIngresolProducto>();
            FrigorificoAnimalPieza = new HashSet<FrigorificoAnimalPieza>();
            FrigorificoTipificacion = new HashSet<FrigorificoTipificacion>();
        }

        [Key]
        [Column("AnimaTipolID")]
        public short AnimaTipolId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Abreviatura { get; set; }

        [InverseProperty("AnimaTipol")]
        public virtual ICollection<FrigorificoAnimaIngresolProducto> FrigorificoAnimaIngresolProducto { get; set; }
        [InverseProperty("AnimaTipol")]
        public virtual ICollection<FrigorificoAnimalPieza> FrigorificoAnimalPieza { get; set; }
        [InverseProperty("AnimaTipol")]
        public virtual ICollection<FrigorificoTipificacion> FrigorificoTipificacion { get; set; }
    }
}