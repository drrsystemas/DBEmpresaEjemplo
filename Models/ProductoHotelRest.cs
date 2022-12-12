﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    /// <summary>
    /// Indica el inventario de Mesas Habitaciones
    /// </summary>
    public partial class ProductoHotelRest
    {
        public ProductoHotelRest()
        {
            OperacionPedidoVentaHotelRest = new HashSet<OperacionPedidoVentaHotelRest>();
            ProductoHotelRestReserva = new HashSet<ProductoHotelRestReserva>();
        }

        [Key]
        [Column("ItemServID")]
        public int ItemServId { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string Denominacion { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Abreviarura { get; set; }
        /// <summary>
        /// Indica si tiene un producto relacionado (Ejem. Prcio reserba u habitacion)
        /// </summary>
        [Column("CodigoID")]
        public int? CodigoId { get; set; }
        public bool Inhabilitado { get; set; }
        [Column("CategoriaID")]
        public short? CategoriaId { get; set; }
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
        /// Sector que realizo la Venta
        /// </summary>
        [Column("SectorID")]
        public short? SectorId { get; set; }
        public short? NroControl { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string PosionEnPlanta { get; set; }
        /// <summary>
        /// Indica el Vendedor asignado a la mesa (Por default)
        /// </summary>
        [Column("VendedorID")]
        public int? VendedorId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string Detalle { get; set; }
        /// <summary>
        /// 0-Ninguno  10-Limpieza 20-Mantenimiento
        /// </summary>
        [Column("EstadoID")]
        public byte EstadoId { get; set; }
        [Column("HabitacionID")]
        public int? HabitacionId { get; set; }

        [ForeignKey("CategoriaId")]
        [InverseProperty("ProductoHotelRest")]
        public virtual ProductoHotelRestCategoria Categoria { get; set; }
        [ForeignKey("CodigoId")]
        [InverseProperty("ProductoHotelRest")]
        public virtual Producto Codigo { get; set; }
        [ForeignKey("HabitacionId")]
        [InverseProperty("ProductoHotelRest")]
        public virtual HotelSectorHabitacion Habitacion { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("ProductoHotelRest")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("ProductoHotelRest")]
        public virtual Sucursal Sucursal { get; set; }
        [ForeignKey("VendedorId")]
        [InverseProperty("ProductoHotelRest")]
        public virtual Vendedor Vendedor { get; set; }
        [InverseProperty("ItemServ")]
        public virtual ICollection<OperacionPedidoVentaHotelRest> OperacionPedidoVentaHotelRest { get; set; }
        [InverseProperty("ItemServ")]
        public virtual ICollection<ProductoHotelRestReserva> ProductoHotelRestReserva { get; set; }
    }
}