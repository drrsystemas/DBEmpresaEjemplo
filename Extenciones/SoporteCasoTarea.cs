using System.ComponentModel.DataAnnotations.Schema;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class SoporteCasoTarea
    {
        private string _registroCaso;

        [NotMapped]
        public string RegistroCaso
        {
            get { return _registroCaso; }
            set { _registroCaso = value; }
        }


        private string _datosFacturacion;
        [NotMapped]
        public string DatosFacturacion
        {
            get { return _datosFacturacion; }
            set { _datosFacturacion = value; }
        }

    }
}
