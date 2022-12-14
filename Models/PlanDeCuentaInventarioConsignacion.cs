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
    /// Lleva un registro de todos los equipos q tiene la empresa en consiganacion, en algunos caso asigandos a clientes con la condicion de un objetivo de venta
    /// </summary>
    public partial class PlanDeCuentaInventarioConsignacion
    {
        public PlanDeCuentaInventarioConsignacion()
        {
            PlanDeCuentaInventarioConsignacionAsignacion = new HashSet<PlanDeCuentaInventarioConsignacionAsignacion>();
        }

        /// <summary>
        /// Codigo de Inventario del equipo en consignacion
        /// </summary>
        [Key]
        [Column("CodigoInventarioID")]
        public int CodigoInventarioId { get; set; }
        /// <summary>
        /// Indico el monto de venta q tiene q cumplir el cliente
        /// </summary>
        [Column(TypeName = "money")]
        public decimal MontoRequerido { get; set; }
        /// <summary>
        /// Codigo Cliente, Dode actualmente esta asignado
        /// </summary>
        [Column("ClienteID")]
        public int? ClienteId { get; set; }
        /// <summary>
        /// Observaciones q se tengan sobre esta consignacion
        /// </summary>
        [Unicode(false)]
        public string Detalle { get; set; }
        /// <summary>
        /// 0-Asigando 1-Disponible 10-Dado de Baja
        /// </summary>
        [Column("EstadoConisgnacionID")]
        public byte EstadoConisgnacionId { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("PlanDeCuentaInventarioConsignacion")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("CodigoInventarioId")]
        [InverseProperty("PlanDeCuentaInventarioConsignacion")]
        public virtual PlanDeCuentaInventario CodigoInventario { get; set; }
        [InverseProperty("CodigoInventario")]
        public virtual ICollection<PlanDeCuentaInventarioConsignacionAsignacion> PlanDeCuentaInventarioConsignacionAsignacion { get; set; }
    }
}