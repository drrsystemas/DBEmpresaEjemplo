﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_EntidadClasificacion_Descripcion")]
    public partial class EntidadClasificacion
    {
        public EntidadClasificacion()
        {
            Entidad = new HashSet<Entidad>();
        }

        [Key]
        [Column("ClasificacionID")]
        public int ClasificacionId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(220)]
        [Unicode(false)]
        public string EntidadClasificacionHierarchy { get; set; }

        [InverseProperty("Clasificacion")]
        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}