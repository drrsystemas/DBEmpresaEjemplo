// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class HotelRestTurno
    {
        public HotelRestTurno()
        {
            OperacionPedidoVentaHotelRest = new HashSet<OperacionPedidoVentaHotelRest>();
        }

        [Key]
        [Column("CierreID")]
        public int CierreId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraHasta { get; set; }
        /// <summary>
        /// 1- RestaurantMesa 10-HotelHabitacion (Tiene como finalidad determinar si pertenece al Hotel o al Restaurant)
        /// </summary>
        [Column("TipoServID")]
        public byte TipoServId { get; set; }
        /// <summary>
        /// N° de Sucursal
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        /// <summary>
        /// Sector en que se asento el Pedido
        /// </summary>
        [Column("SectorID")]
        public short? SectorId { get; set; }
        /// <summary>
        /// Nro de Resmun de Operaciones
        /// </summary>
        [Column("ResumenID")]
        public int? ResumenId { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Detalle { get; set; }
        /// <summary>
        /// 0-Abierto 1-Cerrado
        /// </summary>
        [Column("EstadoID")]
        public byte? EstadoId { get; set; }
        /// <summary>
        /// Almacena el dato de todas las tranascciones q se realizaron y en\ el orden q se producen
        /// </summary>
        [Unicode(false)]
        public string LogProceso { get; set; }

        [ForeignKey("ResumenId")]
        [InverseProperty("HotelRestTurno")]
        public virtual OperacionResumen Resumen { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("HotelRestTurno")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("HotelRestTurno")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("Cierre")]
        public virtual ICollection<OperacionPedidoVentaHotelRest> OperacionPedidoVentaHotelRest { get; set; }
    }
}