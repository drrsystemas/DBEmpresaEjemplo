// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Indica q este concepto no se puede utilizar mas
    /// </summary>
    public partial class UnidadFacturacionConceptos
    {
        public UnidadFacturacionConceptos()
        {
            UnidadFacturacionItem = new HashSet<UnidadFacturacionItem>();
        }

        [Key]
        [Column("UF_ConceptoID")]
        public int UfConceptoId { get; set; }
        [Column("CodigoID")]
        public int CodigoId { get; set; }
        /// <summary>
        /// Cantidad, Puede estar expresado hasta con 4 decimales
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Cantidad { get; set; }
        /// <summary>
        /// Bonificacion Item
        /// </summary>
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? Bonificacion { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CantMinima { get; set; }
        /// <summary>
        /// 0-Ninguno ,1-EquipoMedidor (La cantidad esta determinada por la toma de estado) 
        /// </summary>
        public byte TipoCalculo { get; set; }
        /// <summary>
        /// Codigo aplicar para cobro exedente
        /// </summary>
        [Column("CodigoID_Exedente")]
        public int? CodigoIdExedente { get; set; }
        /// <summary>
        /// Indica q este concepto no se puede aplicar mas a las facturacio
        /// </summary>
        public bool Inhabilitado { get; set; }

        [ForeignKey("CodigoId")]
        [InverseProperty("UnidadFacturacionConceptos")]
        public virtual Producto Codigo { get; set; }
        [InverseProperty("UfConcepto")]
        public virtual ICollection<UnidadFacturacionItem> UnidadFacturacionItem { get; set; }
    }
}