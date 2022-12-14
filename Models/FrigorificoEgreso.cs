// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class FrigorificoEgreso
    {
        [Column("ItemFaenaPiezaID")]
        public int ItemFaenaPiezaId { get; set; }
        [Key]
        [Column("RegistroEgresoID")]
        public int RegistroEgresoId { get; set; }
        /// <summary>
        /// Item Unico del detalle (Indica en q item de Venta Corresponde el salida de la Media Res)
        /// </summary>
        [Column("ItemID")]
        public int ItemId { get; set; }
        /// <summary>
        /// Indica el Peso de la Pieza expresado en KG.
        /// </summary>
        [Column("Kg_Pieza", TypeName = "decimal(13, 4)")]
        public decimal KgPieza { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("FrigorificoEgreso")]
        public virtual OperacionItemProducto Item { get; set; }
        [ForeignKey("ItemFaenaPiezaId")]
        [InverseProperty("FrigorificoEgreso")]
        public virtual FrigorificoFaenaDetallePieza ItemFaenaPieza { get; set; }
    }
}