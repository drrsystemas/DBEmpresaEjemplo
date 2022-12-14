// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class FrigorificoTipificador
    {
        public FrigorificoTipificador()
        {
            FrigorificoFaenaDetallePieza = new HashSet<FrigorificoFaenaDetallePieza>();
        }

        /// <summary>
        /// Codigo TIpificador, persona encargada de Tipificar las Piezas del Animal
        /// </summary>
        [Key]
        [Column("TipificadorID")]
        public short TipificadorId { get; set; }
        /// <summary>
        /// Nombre / Denominacion de la Persona encargada de Realizar la tipificacion
        /// </summary>
        [StringLength(150)]
        public string Denominacion { get; set; }

        [InverseProperty("Tipificador")]
        public virtual ICollection<FrigorificoFaenaDetallePieza> FrigorificoFaenaDetallePieza { get; set; }
    }
}