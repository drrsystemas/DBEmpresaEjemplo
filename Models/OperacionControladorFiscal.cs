// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionControladorFiscal
    {
        public OperacionControladorFiscal()
        {
            OperacionTalonarioNumeracion = new HashSet<OperacionTalonarioNumeracion>();
        }

        [Key]
        [Column("ControladorFiscalID")]
        public int ControladorFiscalId { get; set; }
        public short TipoFiscal { get; set; }
        public short ModeloFiscal { get; set; }
        [Required]
        [Column("DirreccionIP")]
        [StringLength(50)]
        public string DirreccionIp { get; set; }
        [Required]
        [StringLength(150)]
        public string NroSerie { get; set; }
        [Column("TalonarioID")]
        public short TalonarioId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaVencimiento { get; set; }

        [InverseProperty("ControladorFiscal")]
        public virtual ICollection<OperacionTalonarioNumeracion> OperacionTalonarioNumeracion { get; set; }
    }
}