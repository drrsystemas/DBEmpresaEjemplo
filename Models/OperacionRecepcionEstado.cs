﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionRecepcionEstado
    {
        public OperacionRecepcionEstado()
        {
            OperacionRecepcionItem = new HashSet<OperacionRecepcionItem>();
        }

        /// <summary>
        /// 0-Normal 10-No Posee Compra 20-Error Despacho Indica si Estdo de Proceso Item despachado
        /// </summary>
        [Key]
        [Column("ItemRecepcionEstadoID")]
        public byte ItemRecepcionEstadoId { get; set; }
        /// <summary>
        /// Descripcion del estado del Iteme Recibido
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [InverseProperty("ItemRecepcionEstado")]
        public virtual ICollection<OperacionRecepcionItem> OperacionRecepcionItem { get; set; }
    }
}