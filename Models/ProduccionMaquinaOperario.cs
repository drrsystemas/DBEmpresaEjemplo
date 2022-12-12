﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("MaquinaId", Name = "IX_ProduccionMaquinaOperario_MaquinaID")]
    [Index("OperadorId", Name = "IX_ProduccionMaquinaOperario_OperadorID")]
    public partial class ProduccionMaquinaOperario
    {
        /// <summary>
        /// Codigo Unico Asigando a Cadad Mquina
        /// </summary>
        [Column("MaquinaID")]
        public short MaquinaId { get; set; }
        /// <summary>
        /// Codigo Empleado Operador de la Maquina
        /// </summary>
        [Column("OperadorID")]
        public int OperadorId { get; set; }
        [Key]
        [Column("RegistroMaqOperID")]
        public int RegistroMaqOperId { get; set; }

        [ForeignKey("MaquinaId")]
        [InverseProperty("ProduccionMaquinaOperario")]
        public virtual ProduccionMaquina Maquina { get; set; }
        [ForeignKey("OperadorId")]
        [InverseProperty("ProduccionMaquinaOperario")]
        public virtual ProduccionOperario Operador { get; set; }
    }
}