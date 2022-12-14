// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("TipoOperacionId", "RegistroOperacionId", "OperLeyendaId", Name = "IX_OperacionLeyenda", IsUnique = true)]
    [Index("Leyenda", Name = "IX_OperacionLeyenda_Leyenda")]
    public partial class OperacionLeyenda
    {
        [Key]
        [Column("OperLeyendaID")]
        public int OperLeyendaId { get; set; }
        /// <summary>
        /// Tipo Operacion a la que se le Ingresa la Leyenda
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Nro Registro de la Operacion a la que se ingresa la Leyenda
        /// </summary>
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        /// <summary>
        /// Texto descriptivo de la observacion
        /// </summary>
        [Required]
        [StringLength(120)]
        [Unicode(false)]
        public string Leyenda { get; set; }

        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionLeyenda")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionLeyenda")]
        public virtual OperacionConsignacion OperacionConsignacion { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionLeyenda")]
        public virtual OperacionPedidoCompra OperacionPedidoCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionLeyenda")]
        public virtual OperacionPedidoVenta OperacionPedidoVenta { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionLeyenda")]
        public virtual OperacionVenta OperacionVenta { get; set; }
    }
}