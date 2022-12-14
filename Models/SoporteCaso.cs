// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ClienteId", Name = "IX_SoporteCaso_ClienteID")]
    [Index("ContactoId", Name = "IX_SoporteCaso_ContactoID")]
    [Index("ContactoNombre", Name = "IX_SoporteCaso_ContactoNombre")]
    [Index("DescripcionCorta", Name = "IX_SoporteCaso_DescripcionCorta")]
    [Index("Telefono", Name = "IX_SoporteCaso_Telefono")]
    public partial class SoporteCaso
    {
        public SoporteCaso()
        {
            SoporteCasoTarea = new HashSet<SoporteCasoTarea>();
        }

        [Key]
        [Column("CasoID")]
        public int CasoId { get; set; }
        /// <summary>
        /// Usuario Sistema
        /// </summary>
        [Column("AlmaUserID")]
        public int AlmaUserId { get; set; }
        /// <summary>
        /// Cliente al que se factura
        /// </summary>
        [Column("ClienteID")]
        public int ClienteId { get; set; }
        /// <summary>
        /// ID COnexion sobre la que se dio Soporte
        /// </summary>
        [Column("ConexionSopID")]
        public int? ConexionSopId { get; set; }
        /// <summary>
        /// Ip distinta a la q tiene por defecto el Cliente TeamViewer ID
        /// </summary>
        [Column("IP_Actual")]
        [StringLength(80)]
        [Unicode(false)]
        public string IpActual { get; set; }
        /// <summary>
        /// En caso que sea distinto a la del CLiente Ver Casos en q llama un vendedor
        /// </summary>
        [StringLength(60)]
        [Unicode(false)]
        public string Telefono { get; set; }
        /// <summary>
        /// Perosna q llama y presenta el Caso
        /// </summary>
        [Column("ContactoID")]
        public int? ContactoId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ContactoNombre { get; set; }
        /// <summary>
        /// Descripcion Corta del caso
        /// </summary>
        [StringLength(100)]
        [Unicode(false)]
        public string DescripcionCorta { get; set; }
        /// <summary>
        /// Fecha y hora en que se registra
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        /// <summary>
        /// Fecha y hora desde que se presenta el problema
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FechaDeteccionCaso { get; set; }
        /// <summary>
        /// Persona/Operador que detecto el problema
        /// </summary>
        [StringLength(60)]
        [Unicode(false)]
        public string QuienDetectaProblema { get; set; }
        /// <summary>
        /// Pantalla en la que se registra el Problema
        /// </summary>
        [Column("FormularioID")]
        public short? FormularioId { get; set; }
        /// <summary>
        /// Codigo de error q se visualiza
        /// </summary>
        [Column("ErrorID")]
        public int? ErrorId { get; set; }
        /// <summary>
        /// Descripcion mensaje Error
        /// </summary>
        [Unicode(false)]
        public string DescripcionProblema { get; set; }
        /// <summary>
        /// Pasos para reproducir el Problema
        /// </summary>
        [Unicode(false)]
        public string PasosRepProblema { get; set; }
        /// <summary>
        /// Estado en que se encuentra el caso Abierto, En  Proceso, Transferido
        /// </summary>
        [Column("EstadoID")]
        public int? EstadoId { get; set; }
        /// <summary>
        /// Indica si esta actico el Caso
        /// </summary>
        public bool Activo { get; set; }
        /// <summary>
        /// e-mail a los que se tiene que notificar la evolucion del Caso
        /// </summary>
        [StringLength(150)]
        [Unicode(false)]
        public string EmailNotificacion { get; set; }
        /// <summary>
        /// Etapa en la que se encuentra el Estado ejem. Reg Recla
        /// </summary>
        [Column("EtapaID")]
        public short EtapaId { get; set; }
        /// <summary>
        /// Otras Personas a Notificar
        /// </summary>
        [StringLength(500)]
        [Unicode(false)]
        public string Notificar { get; set; }
        /// <summary>
        /// FechaHora a relizar el soporte del Caso
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AgendarFecha { get; set; }
        /// <summary>
        /// (Soporte/Instalacion-Actualizacion)
        /// </summary>
        [Column("TipoCasoID")]
        public short TipoCasoId { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("SoporteCaso")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("ContactoId")]
        [InverseProperty("SoporteCaso")]
        public virtual Contacto Contacto { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("SoporteCaso")]
        public virtual SoporteCasoEstado Estado { get; set; }
        [ForeignKey("TipoCasoId")]
        [InverseProperty("SoporteCaso")]
        public virtual SoporteCasoTipo TipoCaso { get; set; }
        [InverseProperty("Caso")]
        public virtual ICollection<SoporteCasoTarea> SoporteCasoTarea { get; set; }
    }
}