﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class BasculaPesajeDesglose
    {
        [Key]
        [Column("RegistoID")]
        public int RegistoId { get; set; }
        [Column("PesajeID")]
        public int PesajeId { get; set; }
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal ImporteComision { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? CantidadNeto { get; set; }
        /// <summary>
        /// 0-No aplica 1-repite Cantidad TIkete Bascula, 2-Dsglosa la cantidad por cada empleado (la suma del desglose del ticket tiene q coincidir con la del ticket)
        /// </summary>
        public byte? TipoCalculo { get; set; }

        [ForeignKey("PesajeId")]
        [InverseProperty("BasculaPesajeDesglose")]
        public virtual BasculaPesaje Pesaje { get; set; }
    }
}