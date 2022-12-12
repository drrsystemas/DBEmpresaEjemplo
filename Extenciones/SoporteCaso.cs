using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class SoporteCaso
    {
        private string _registroCaso;

        [NotMapped]
        public string RegistroCaso
        {
            get { return _registroCaso; }
            set { _registroCaso = value; }
        }


        public string _idTareaPrincipal;
        [NotMapped]
        public string IdTareaPrincipa
        {
            get { return _idTareaPrincipal; }
            set { _idTareaPrincipal = value; }
        }



        public override string ToString()
        {
            StringBuilder dato = new StringBuilder();
            dato.AppendLine("CasoId: " + CasoId);
            dato.AppendLine("TareaId: " + IdTareaPrincipa);


            String idZona = this.Cliente?.EntidadSuc?.ZonaId.ToString();

            String cliente = this.Cliente.ClienteId + " " + Cliente?.EntidadSuc?.Entidad?.RazonSocial;

            if (Cliente.EntidadSuc.ZonaId != null)
            {
                cliente = "[Z-" + idZona + "]-" + cliente;
            }

            dato.AppendLine("Cliente: " + cliente);
            dato.AppendLine("\n");

            String contac = "Contacto: " + Contacto?.ApellidoNombre + " - Tel: " + Contacto?.Telefono;

            dato.AppendLine("Contacto: " + contac);

            dato.AppendLine("Descripción Caso: " + DescripcionProblema);
            dato.AppendLine("\n");
            if (!String.IsNullOrEmpty(QuienDetectaProblema))
            {
                dato.AppendLine("Detecto el prob: " + QuienDetectaProblema);
                dato.AppendLine("\n");
            }

            if (!String.IsNullOrEmpty(Notificar))
            {
                dato.AppendLine("Notificar: " + Notificar);
                dato.AppendLine("\n");
            }


            if (!String.IsNullOrEmpty(RegistroCaso))
            {
                dato.AppendLine("Registro: " + RegistroCaso);
            }
            if (!String.IsNullOrEmpty(EmailNotificacion))
            {
                dato.AppendLine("Email Notificar: " + EmailNotificacion);
            }
            if (!String.IsNullOrEmpty(Telefono))
            {
                dato.AppendLine("Tel/Cel: " + Telefono);
            }

            try
            {
                var tarea = this.SoporteCasoTarea?.FirstOrDefault();
                if (tarea != null && tarea.PrioridadId > 0)
                {
                    String prioridad = "Alta";
                    if (tarea.PrioridadId == 1)
                    {
                        prioridad = "Baja";
                    }
                    else if (tarea.PrioridadId == 5)
                    {
                        prioridad = "Media";
                    }

                    dato.AppendLine("Prioridad: " + prioridad);

                }
            }
            catch
            {

            }




            return dato.ToString();
        }


        public string getDatos(String usuario)
        {
            StringBuilder dato = new StringBuilder();
            dato.AppendLine("CasoId: " + CasoId);
            dato.AppendLine("TareaId: " + IdTareaPrincipa);


            String idZona = this.Cliente?.EntidadSuc?.ZonaId.ToString();

            String cliente = this.Cliente.ClienteId + " " + Cliente?.EntidadSuc?.Entidad?.RazonSocial;

            if (Cliente.EntidadSuc.ZonaId != null)
            {
                cliente = "[Z-" + idZona + "]-" + cliente;
            }

            dato.AppendLine("Cliente: " + cliente);
            dato.AppendLine("\n");

            String contac = "Contacto: " + Contacto?.ApellidoNombre + " - Tel: " + Contacto?.Telefono;

            dato.AppendLine("Contacto: " + contac);

            dato.AppendLine("Descripción Caso: " + DescripcionProblema);
            dato.AppendLine("\n");
            if (!String.IsNullOrEmpty(QuienDetectaProblema))
            {
                dato.AppendLine("Detecto el prob: " + QuienDetectaProblema);
                dato.AppendLine("\n");
            }

            if (!String.IsNullOrEmpty(Notificar))
            {
                dato.AppendLine("Notificar: " + Notificar);
                dato.AppendLine("\n");
            }


            if (!String.IsNullOrEmpty(RegistroCaso))
            {
                dato.AppendLine("Registro: " + RegistroCaso);
            }
            if (!String.IsNullOrEmpty(EmailNotificacion))
            {
                dato.AppendLine("Email Notificar: " + EmailNotificacion);
            }
            if (!String.IsNullOrEmpty(Telefono))
            {
                dato.AppendLine("Tel/Cel: " + Telefono);
            }

            try
            {
                var tarea = this.SoporteCasoTarea?.FirstOrDefault();
                if (tarea != null && tarea.PrioridadId > 0)
                {
                    String prioridad = "Alta";
                    if (tarea.PrioridadId == 1)
                    {
                        prioridad = "Baja";
                    }
                    else if (tarea.PrioridadId == 5)
                    {
                        prioridad = "Media";
                    }

                    dato.AppendLine("Prioridad: " + prioridad);

                }
            }
            catch
            {

            }

            if (!String.IsNullOrEmpty(usuario))
            {
                dato.AppendLine("Reg. por: " + usuario);
            }


            return dato.ToString();
        }
    }
}
