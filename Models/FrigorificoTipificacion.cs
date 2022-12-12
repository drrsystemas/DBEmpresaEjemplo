﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Permite establecer la calidad de cada Animal Pieza
    /// </summary>
    public partial class FrigorificoTipificacion
    {
        public FrigorificoTipificacion()
        {
            FrigorificoAnimaIngresolProducto = new HashSet<FrigorificoAnimaIngresolProducto>();
            FrigorificoFaenaDetallePieza = new HashSet<FrigorificoFaenaDetallePieza>();
            FrigorificoPiezaEgresoProducto = new HashSet<FrigorificoPiezaEgresoProducto>();
        }

        /// <summary>
        /// Indica el Codigo de Tipificacion de la Pieza (Calidad de la Carne), que la asigan el tipificador
        /// </summary>
        [Key]
        [Column("TipificID")]
        public short TipificId { get; set; }
        /// <summary>
        /// Denominacion de la Tipificacion
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        /// <summary>
        /// indica para que tipo de animal aplica este tipificacion Viene de FrigorificoAnimalTipo
        /// </summary>
        [Column("AnimaTipolID")]
        public short? AnimaTipolId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Abreviatura { get; set; }
        /// <summary>
        /// 0-Ninguno 1-Ingreso 2-Egreso
        /// </summary>
        public byte IngresoEgreso { get; set; }

        [ForeignKey("AnimaTipolId")]
        [InverseProperty("FrigorificoTipificacion")]
        public virtual FrigorificoAnimalTipo AnimaTipol { get; set; }
        [InverseProperty("Tipific")]
        public virtual ICollection<FrigorificoAnimaIngresolProducto> FrigorificoAnimaIngresolProducto { get; set; }
        [InverseProperty("Tipific")]
        public virtual ICollection<FrigorificoFaenaDetallePieza> FrigorificoFaenaDetallePieza { get; set; }
        [InverseProperty("Tipific")]
        public virtual ICollection<FrigorificoPiezaEgresoProducto> FrigorificoPiezaEgresoProducto { get; set; }
    }
}