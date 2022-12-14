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
    /// Contiene una Tabla con todos los archivos Referidos a un Cliente, Proveedor,Venededor, Transporte Etc., estos archivos pueden ser planillas de Excel, Documentos de Word, Imagenes Etc.
    /// </summary>
    [Index("DescripcionArchivo", Name = "IX_EntidadSucursalArchivos_DescripcionArchivo")]
    [Index("EntidadSucId", Name = "IX_EntidadSucursalArchivos_EntidadSucID")]
    public partial class EntidadSucursalArchivos
    {
        /// <summary>
        /// Seleciona  la Clasificacion de AlmaNET.ArchivosClasificacion (Indica si se trata de un Presupuesto, informe, Documento etc.)
        /// </summary>
        [Column("ClasificacionArchivoID")]
        public short ClasificacionArchivoId { get; set; }
        /// <summary>
        /// Contiene algun detalle que aga referencia al  Archivo (Ejem. Presupuesto Auto xx)
        /// </summary>
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string DescripcionArchivo { get; set; }
        /// <summary>
        /// Sucursal a la que esta relacionado
        /// </summary>
        [Column("EntidadSucID")]
        public int EntidadSucId { get; set; }
        [Key]
        [Column("RegistroArchivoID")]
        public int RegistroArchivoId { get; set; }
        [Required]
        public byte[] Archivo { get; set; }
        /// <summary>
        /// Extencion para determinar el tipo de archivo que se esta grabando
        /// </summary>
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string Extension { get; set; }
        /// <summary>
        /// Indica el Codigo de Archivo Modelo Utilizado a partir de cual se creo este (AlmaNET.ArchivoModelo.ModeloArchivoID)
        /// </summary>
        [Column("TemplateID")]
        public int? TemplateId { get; set; }
        /// <summary>
        /// Para el caso que para una Entidad se necesiten vincular varias imagenes estas se enumeran para facilitar su Sincronizacion
        /// </summary>
        public short? NroArchivo { get; set; }

        [ForeignKey("EntidadSucId")]
        [InverseProperty("EntidadSucursalArchivos")]
        public virtual EntidadSucursal EntidadSuc { get; set; }
    }
}