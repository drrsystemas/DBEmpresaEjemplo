// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class EncuestaRespuesta
    {
        public EncuestaRespuesta()
        {
            EncuestaRespuestaOpcion = new HashSet<EncuestaRespuestaOpcion>();
        }

        [Key]
        [Column("RespuestaID")]
        public int RespuestaId { get; set; }
        /// <summary>
        /// Para el caso q la opcion de respuesta tenga q estar argumentada
        /// </summary>
        [StringLength(250)]
        public string Detalle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        /// <summary>
        /// Nro Sucursal/Entidad
        /// </summary>
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        /// <summary>
        /// Tipo Operacion sobre la q se realiza la encuesta
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Para el caso q esta encuesta este vincualda a alguan Operacion realizada por la empresa
        /// </summary>
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }

        [ForeignKey("EntidadSucId")]
        [InverseProperty("EncuestaRespuesta")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("EncuestaRespuesta")]
        public virtual OperacionPedidoVenta OperacionPedidoVenta { get; set; }
        public virtual OperacionRendicion OperacionRendicion { get; set; }
        [InverseProperty("Respuesta")]
        public virtual ICollection<EncuestaRespuestaOpcion> EncuestaRespuestaOpcion { get; set; }
    }
}