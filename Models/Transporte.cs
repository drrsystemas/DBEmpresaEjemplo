﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("EntidadSucId", Name = "IX_Transporte_EntidadSucID", IsUnique = true)]
    [Index("TranspClasificacionId", Name = "IX_Transporte_TranspClasificacionID")]
    public partial class Transporte
    {
        public Transporte()
        {
            EntidadSucursal = new HashSet<EntidadSucursal>();
            OperacionPedidoCompra = new HashSet<OperacionPedidoCompra>();
            OperacionPedidoVenta = new HashSet<OperacionPedidoVenta>();
            OperacionPedidoVentaWeb = new HashSet<OperacionPedidoVentaWeb>();
            ServisProcesos = new HashSet<ServisProcesos>();
            TransporteCapacidad = new HashSet<TransporteCapacidad>();
            TransporteConductor = new HashSet<TransporteConductor>();
            TransporteVehiculo = new HashSet<TransporteVehiculo>();
        }

        /// <summary>
        /// Codigo de trasnporte
        /// </summary>
        [Key]
        [Column("TransporteID")]
        public int TransporteId { get; set; }
        [Required]
        [Unicode(false)]
        public string Detalles { get; set; }
        /// <summary>
        /// Entidad Sucursal a la q relaciona
        /// </summary>
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        /// <summary>
        /// Codigo transporte internacional
        /// </summary>
        public int? CodigoInternacional { get; set; }
        [Column("TranspClasificacionID")]
        public int? TranspClasificacionId { get; set; }

        [ForeignKey("EntidadSucId")]
        [InverseProperty("TransporteNavigation")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
        [ForeignKey("TranspClasificacionId")]
        [InverseProperty("Transporte")]
        public virtual TransporteClasificacion TranspClasificacion { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<EntidadSucursal> EntidadSucursal { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<OperacionPedidoCompra> OperacionPedidoCompra { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<OperacionPedidoVenta> OperacionPedidoVenta { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<OperacionPedidoVentaWeb> OperacionPedidoVentaWeb { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<ServisProcesos> ServisProcesos { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<TransporteCapacidad> TransporteCapacidad { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<TransporteConductor> TransporteConductor { get; set; }
        [InverseProperty("Transporte")]
        public virtual ICollection<TransporteVehiculo> TransporteVehiculo { get; set; }
    }
}