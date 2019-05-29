using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
   public class dPersona
    {
        Database db = new Database();
        public string insertar(ePersona obj)
        {
            try
            {
                SqlConnection con = db.conectaDB();
                string insert = string.Format("insert into persona (codigo,nombre,edad) values('{0}','{1}',{2})",obj.Codigo,obj.Nombre,obj.Edad);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "insertó";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }


    }
}
