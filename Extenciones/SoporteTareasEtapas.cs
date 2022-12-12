using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class SoporteTareasEtapas
    {
        private Boolean _propSeleccionado;

        /// <summary>
        /// Propiedad extra 
        /// </summary>
        [NotMapped]
        public Boolean PropSeleccionado
        {
            get { return _propSeleccionado; }
            set { _propSeleccionado = value; }
        }
    }
}
