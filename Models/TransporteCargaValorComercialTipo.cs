﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("Descripcion", Name = "IX_TransporteCargaValorComercialTipo_Descripcion")]
    public partial class TransporteCargaValorComercialTipo
    {
        public TransporteCargaValorComercialTipo()
        {
            OperacionVentaExportacion = new HashSet<OperacionVentaExportacion>();
            TransporteCrt = new HashSet<TransporteCrt>();
        }

        [Key]
        [Column("ValorComercialTipoID")]
        public short ValorComercialTipoId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        public bool EsAnulado { get; set; }
        [Unicode(false)]
        public string Observacion { get; set; }

        [InverseProperty("ValorComercialTipo")]
        public virtual ICollection<OperacionVentaExportacion> OperacionVentaExportacion { get; set; }
        [InverseProperty("C14valorComercialTipo")]
        public virtual ICollection<TransporteCrt> TransporteCrt { get; set; }
    }
}