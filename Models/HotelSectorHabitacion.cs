﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class HotelSectorHabitacion
    {
        public HotelSectorHabitacion()
        {
            HotelHabitacionAuditoria = new HashSet<HotelHabitacionAuditoria>();
            HotelHabitacionElemento = new HashSet<HotelHabitacionElemento>();
            OrdenServicioHabitacion = new HashSet<OrdenServicioHabitacion>();
            ProductoHotelRest = new HashSet<ProductoHotelRest>();
        }

        [Key]
        [Column("HabitacionID")]
        public int HabitacionId { get; set; }
        public short HabitacionNro { get; set; }
        [Column("HotelSectorID")]
        public short HotelSectorId { get; set; }

        [ForeignKey("HotelSectorId")]
        [InverseProperty("HotelSectorHabitacion")]
        public virtual HotelSector HotelSector { get; set; }
        [InverseProperty("Habitacion")]
        public virtual ICollection<HotelHabitacionAuditoria> HotelHabitacionAuditoria { get; set; }
        [InverseProperty("Habitacion")]
        public virtual ICollection<HotelHabitacionElemento> HotelHabitacionElemento { get; set; }
        [InverseProperty("Habitacion")]
        public virtual ICollection<OrdenServicioHabitacion> OrdenServicioHabitacion { get; set; }
        [InverseProperty("Habitacion")]
        public virtual ICollection<ProductoHotelRest> ProductoHotelRest { get; set; }
    }
}