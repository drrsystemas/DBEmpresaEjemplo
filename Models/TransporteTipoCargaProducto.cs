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
    /// Contiene todos los productos q estan relacionado a un tipo de carga (Ejemplo Carga Peligrosa- en esta tabla especifico cuales son todos los productos q transportados se consideran carga Peligrosa)
    /// </summary>
    [Index("CodigoBaseId", Name = "IX_TransporteTipoCargaProducto_CodigoBaseID")]
    [Index("TipoCargaId", Name = "IX_TransporteTipoCargaProducto_TipoCargaID")]
    public partial class TransporteTipoCargaProducto
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        /// <summary>
        /// Codigo q estable el tipo de carga q puede Trasnportar el Vehiculo
        /// </summary>
        [Column("TipoCargaID")]
        public short TipoCargaId { get; set; }
        /// <summary>
        /// Codigo Base utilizado A partir del cual se crea el Producto
        /// </summary>
        [Column("CodigoBaseID")]
        public int CodigoBaseId { get; set; }

        [ForeignKey("CodigoBaseId")]
        [InverseProperty("TransporteTipoCargaProducto")]
        public virtual ProductoBase CodigoBase { get; set; }
        [ForeignKey("TipoCargaId")]
        [InverseProperty("TransporteTipoCargaProducto")]
        public virtual TransporteTipoCarga TipoCarga { get; set; }
    }
}