using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace DRR.Core.DBEmpresaEjemplo.Models
{



    public class OperacionCobroWeb_Observacion
    {

        public enum EnumFormaPago
        {
            Efectivo = 1,
            Transferencia_Bancaria = 2,
            Cheque = 3,
            TarjetaCredito = 4,
            TrajetaDebito = 5,
            MercadoPago = 6,
            Otros = 7
        }


        public OperacionCobroWeb_Observacion( [Optional] String observacion)
        {
            FormaPago = new List<string>();

            if (observacion != null)
            {
                String[] datos = observacion.Split("-");

                try
                {

                    Observacion = datos[0];
                    PagoMultiple = datos[1] == "Si" ? true : false;


                    if (PagoMultiple == false)
                    {
                        FormaPago.Add(datos[2]);
                    }
                    else
                    {
                        String dataFormaPago = datos[2];
                        String[] pagos = dataFormaPago.Split('|');

                        foreach (String item in pagos)
                        {
                            FormaPago.Add(item);
                        }

                    }

   
                }
                catch (Exception ex)
                { 
                    Observacion = observacion;
                }

            }

        }

        //Donde esta la parte de datos.
        public String Observacion { get; set; }

        //Por defecto en false.
        public Boolean PagoMultiple { get; set; } = false;

        //Por Defecto en efectivo.
        public List<String> FormaPago { get; set; }

    

        /// <summary>
        /// Para guardar la Observacion en formato de Sting.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {


            String formaPago = "";
            if(PagoMultiple == false)
            {
                if(FormaPago == null || FormaPago?.Count == 0)
                {
                    formaPago = "Efectivo";
                }
                else
                {
                    formaPago = FormaPago[0];
                }
            }
            else
            {
                for (int i = 0; i < FormaPago.Count ; i++)
                {
                    if(i==0)
                    {
                        formaPago = FormaPago[i];
                    }
                    else
                    {
                        formaPago += $"|{FormaPago[i]}";
                    }
                }
            }

            String resultado = $"{Observacion} - {(PagoMultiple == true ? "Si" : "No")} - {formaPago}";


            return resultado;
        }



        
    }

    public partial class OperacionCobroWeb
    {




 


        private OperacionCobroWeb_Observacion _operacionCobroWeb_Observacion;

        [NotMapped]
        public OperacionCobroWeb_Observacion OperacionCobroWeb_Observacion
        {
            //Aca se tiene que hacer un lindo Laburo.

            get { return _operacionCobroWeb_Observacion; }
            set { _operacionCobroWeb_Observacion = value; }
        }




        private string _representada;

        [NotMapped]
        public string P_Representada
        {
            get { return _representada; }
            set { _representada = value; }
        }


        private string _clienteNombre;

        [NotMapped]
        public string P_ClienteNombre
        {
            get { return _clienteNombre; }
            set { _clienteNombre = value; }
        }
    }
}
