using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace FarmaciaGaleras
{
    public class Conexion
    {
        string Cadena="Data Source=SALA235-PC24\\SQLEXPRESS; Initial Catalog=Farmacia; User Id=sa; password=fnsp";
        public SqlConnection conectarbd;

        public Conexion(){

        }

        public void abrir()
        {
            try 
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, no conecta"+ex);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }
    }   

        
}
