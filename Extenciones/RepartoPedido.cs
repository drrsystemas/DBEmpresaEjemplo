using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class RepartoPedido
    {
        private Boolean _tieneCobroWeb;

        [NotMapped]
        public Boolean TieneCobroWeb
        {
            get { return _tieneCobroWeb; }
            set { _tieneCobroWeb = value; }
        }
    }
}
