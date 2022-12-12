﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class ProduccionInsumosOperacionRecepcionItem
    {
        [Key]
        [Column("RegistroCtrlID")]
        public int RegistroCtrlId { get; set; }
        [Column("RegistroInsumoID")]
        public int RegistroInsumoId { get; set; }
        [Column("RegReccpcionID")]
        public int RegReccpcionId { get; set; }

        [ForeignKey("RegReccpcionId")]
        [InverseProperty("ProduccionInsumosOperacionRecepcionItem")]
        public virtual OperacionRecepcionItemDetalle RegReccpcion { get; set; }
        [ForeignKey("RegistroInsumoId")]
        [InverseProperty("ProduccionInsumosOperacionRecepcionItem")]
        public virtual ProduccionInsumosOrdenItem RegistroInsumo { get; set; }
    }
}