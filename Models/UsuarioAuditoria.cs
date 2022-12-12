﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("AlmaUserId", Name = "IX_UsuarioAuditoria_AlmaUserID")]
    [Index("FechaHora", Name = "IX_UsuarioAuditoria_FechaHora")]
    [Index("FormId", Name = "IX_UsuarioAuditoria_FormID")]
    [Index("IdregistroPrimario", Name = "IX_UsuarioAuditoria_IDRegistroPrimario")]
    [Index("Proceso", Name = "IX_UsuarioAuditoria_Proceso")]
    [Index("TablaPrincipalId", Name = "IX_UsuarioAuditoria_TablaPrincipalID")]
    public partial class UsuarioAuditoria
    {
        public UsuarioAuditoria()
        {
            UsuarioAuditoriaTabla = new HashSet<UsuarioAuditoriaTabla>();
        }

        [Key]
        [Column("RegTransaccionID")]
        public int RegTransaccionId { get; set; }
        [Column("FormID")]
        public int? FormId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        [Column("IDRegistroPrimario")]
        public int IdregistroPrimario { get; set; }
        [Column("TablaPrincipalID")]
        public int TablaPrincipalId { get; set; }
        public byte Proceso { get; set; }
        [Column("WebUserID")]
        public int? WebUserId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("UsuarioAuditoria")]
        public virtual Usuario AlmaUser { get; set; }
        [InverseProperty("RegTransaccion")]
        public virtual ICollection<UsuarioAuditoriaTabla> UsuarioAuditoriaTabla { get; set; }
    }
}