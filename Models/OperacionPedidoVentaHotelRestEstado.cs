// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionPedidoVentaHotelRestEstado
    {
        public OperacionPedidoVentaHotelRestEstado()
        {
            OperacionPedidoVentaHotelRest = new HashSet<OperacionPedidoVentaHotelRest>();
        }

        /// <summary>
        /// 0-Disponible (Blanco) 10-Abierta(Vede) 20-Posse Pedido Pendiente(Naranja), 30-Solicito Cierre(Negro) 50-Reservado (Amarillo)
        /// </summary>
        [Key]
        [Column("EstadoID")]
        public short EstadoId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Detalle { get; set; }
        /// <summary>
        /// 1- RestaurantMesa 10-HotelHabitacion (Tiene como finalidad determinar si pertenece al Hotel o al Restaurant)
        /// </summary>
        [Column("TipoServID")]
        public byte? TipoServId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Color { get; set; }

        [InverseProperty("Estado")]
        public virtual ICollection<OperacionPedidoVentaHotelRest> OperacionPedidoVentaHotelRest { get; set; }
    }
}