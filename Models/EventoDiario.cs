// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("RegPeriodoDiarioId", "AvisoTipoId", Name = "IX_EventoDiario", IsUnique = true)]
    public partial class EventoDiario
    {
        public EventoDiario()
        {
            Evento = new HashSet<Evento>();
        }

        [Key]
        [Column("RegPeriodoDiarioID")]
        public int RegPeriodoDiarioId { get; set; }
        /// <summary>
        /// Define como valor un Tipo Diario
        /// </summary>
        [Column("AvisoTipoID")]
        public byte AvisoTipoId { get; set; }
        /// <summary>
        /// Indica cada cuantos dia se debe producucir el evento
        /// </summary>
        public byte Dia { get; set; }
        public bool SoloLaborable { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaFinal { get; set; }
        public int? Repeticiones { get; set; }
        /// <summary>
        /// Indica q el Evento Fue Cancelado
        /// </summary>
        public bool? Cancelado { get; set; }
        /// <summary>
        /// Se Indica para q Usuario de Alma Eesta asiganado el Evento
        /// </summary>
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        /// <summary>
        /// Indica la Cantidad de Minutos q dura el Evento
        /// </summary>
        public int Duracion { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}