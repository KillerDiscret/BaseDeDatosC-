using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public class nPersona
    {
        dPersona persona;
        public nPersona()
        {
            persona = new dPersona();
        }
        public string RegistrarPersona(string codigo, string nombre,int edad)
        {
            ePersona objpersona = new ePersona()
            {
                Codigo=codigo,
                Nombre=nombre,
                Edad=edad
            };
            return persona.insertar(objpersona);



        }

    }
}
