﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            HotelSector = new HashSet<HotelSector>();
        }

        [Key]
        [Column("HotelID")]
        public int HotelId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Denominacion { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TelefonoPrincipal { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TelfonoSecundario { get; set; }
        [Column("EMail")]
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }

        [ForeignKey("SucursalId")]
        [InverseProperty("Hotel")]
        public virtual Sucursal Sucursal { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<HotelSector> HotelSector { get; set; }
    }
}