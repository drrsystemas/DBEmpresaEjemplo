using System.ComponentModel.DataAnnotations.Schema;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionCobroWebItem
    {
        private string _comprobante;

        [NotMapped]
        public string P_Comprobante
        {
            get { return _comprobante; }
            set { _comprobante = value; }
        }


        private string _tipo;

        [NotMapped]
        public string P_Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }


    }
}
