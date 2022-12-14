// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class FrigorificoAnimalPiezaTipo
    {
        public FrigorificoAnimalPiezaTipo()
        {
            FrigorificoAnimalPieza = new HashSet<FrigorificoAnimalPieza>();
        }

        [Key]
        [Column("AnimalPiezaTipoID")]
        public byte AnimalPiezaTipoId { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
        /// <summary>
        /// Indica que en la faena se tiene q especificar si o si un valor para este pieza 
        /// </summary>
        public bool EsObilgatorio { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Abreviatura { get; set; }

        [InverseProperty("AnimalPiezaTipo")]
        public virtual ICollection<FrigorificoAnimalPieza> FrigorificoAnimalPieza { get; set; }
    }
}