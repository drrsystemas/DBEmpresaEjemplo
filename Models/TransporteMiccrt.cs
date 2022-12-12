﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Table("TransporteMICCRT")]
    [Index("CrtId", Name = "IX_TransporteMICCRT_CRT_ID")]
    [Index("M24aduanaDestinoId", Name = "IX_TransporteMICCRT_M24AduanaDestinoID")]
    [Index("M24codigoAduana", Name = "IX_TransporteMICCRT_M24CodigoAduana")]
    [Index("MicId", Name = "IX_TransporteMICCRT_MIC_ID")]
    public partial class TransporteMiccrt
    {
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        [Column("MIC_ID")]
        public int MicId { get; set; }
        [Column("CRT_ID")]
        public int CrtId { get; set; }
        [Column("M24AduanaDestinoID")]
        public int? M24aduanaDestinoId { get; set; }
        [Column("M24CodigoAduana")]
        [StringLength(30)]
        [Unicode(false)]
        public string M24codigoAduana { get; set; }
        [Column("M26OrigenMercancias")]
        [StringLength(150)]
        [Unicode(false)]
        public string M26origenMercancias { get; set; }
        [Column("M27ValorFOT", TypeName = "money")]
        public decimal? M27valorFot { get; set; }
        [Column("M28Flete", TypeName = "money")]
        public decimal? M28flete { get; set; }
        [Column("M29Seguro", TypeName = "money")]
        public decimal? M29seguro { get; set; }
        [Column("M31CantidadBultos", TypeName = "money")]
        public decimal? M31cantidadBultos { get; set; }
        [Column("M32PesoBruto", TypeName = "money")]
        public decimal? M32pesoBruto { get; set; }
        [Column("M33Remitente")]
        [StringLength(300)]
        [Unicode(false)]
        public string M33remitente { get; set; }
        [Column("M34Destinatario")]
        [StringLength(300)]
        [Unicode(false)]
        public string M34destinatario { get; set; }
        [Column("M35Consignatario")]
        [StringLength(300)]
        [Unicode(false)]
        public string M35consignatario { get; set; }
        [Column("M36DocumentosAnexos")]
        [Unicode(false)]
        public string M36documentosAnexos { get; set; }
        [Column("M37NroPresintos")]
        [StringLength(150)]
        [Unicode(false)]
        public string M37nroPresintos { get; set; }
        [Column("M38DetalleCarga")]
        [Unicode(false)]
        public string M38detalleCarga { get; set; }
        [Column("M40NroDTA")]
        [Unicode(false)]
        public string M40nroDta { get; set; }
        [Column("M26CodPaisDestino")]
        public short? M26codPaisDestino { get; set; }

        [ForeignKey("CrtId")]
        [InverseProperty("TransporteMiccrt")]
        public virtual TransporteCrt Crt { get; set; }
        [ForeignKey("M24aduanaDestinoId")]
        [InverseProperty("TransporteMiccrt")]
        public virtual TransporteAduana M24aduanaDestino { get; set; }
        [ForeignKey("MicId")]
        [InverseProperty("TransporteMiccrt")]
        public virtual TransporteMic Mic { get; set; }
    }
}