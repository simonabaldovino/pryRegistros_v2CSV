using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Schema;

namespace pryRegistros_v2
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";
        Decimal Total = 0;
        Int32 C = 0;

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //Abrir 
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            
            //carga o leer
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);

            //cerrar
            AD.Close(); 
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VectorDatos = new string[4];

            //ab
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VectorDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(VectorDatos[0], VectorDatos[1], VectorDatos[2], VectorDatos[3]); 
                DatosLeidos = AD.ReadLine();
            }

            //cerr
            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadClientes()
        {
            string DatosLeidos;


            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                C++;

                DatosLeidos = AD.ReadLine();
            }

            //cerrar
            AD.Close();
            AD.Dispose();

            return C;        
        }

        public Decimal DeudaClientes()
        {
            string[] VectorDatos = new string[4];
            string DatosLeidos;

            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VectorDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VectorDatos[2]);
                DatosLeidos = AD.ReadLine();
            }

            //cerrar
            AD.Close();
            AD.Dispose();

            return Total;
        }
       
        public Decimal PromedioDeuda()
        {
            string[] VectorDatos = new string[4];
            string DatosLeidos;
           

            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                C++;
                VectorDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VectorDatos[2]);
                DatosLeidos = AD.ReadLine();
            }

            //cerrar
            AD.Close();
            AD.Dispose();

            return Total / C;
        }
       
     

        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VectorDatos = new string[4];

            //ab
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VectorDatos = DatosLeidos.Split(';');

                if (Convert.ToInt32(VectorDatos[3]) > 0)
                {
                    Grilla.Rows.Add(VectorDatos[0], VectorDatos[1], VectorDatos[2], VectorDatos[3]);
                }

                DatosLeidos = AD.ReadLine();
            }

            //cerr
            AD.Close();
            AD.Dispose();
        }

        public Decimal DeudaClientes2()
        {
            string[] VectorDatos = new string[4];
            string DatosLeidos;

            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VectorDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VectorDatos[2]);
                DatosLeidos = AD.ReadLine();
            }

            //cerrar
            AD.Close();
            AD.Dispose();

            return Total;
        }

        public Int32 CantidadClientes2(DataGridView Grilla)
        {
            string[] VectorDatos = new string[4];
            string DatosLeidos;


            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {                
                VectorDatos = DatosLeidos.Split(';');

                if (Convert.ToInt32(VectorDatos[3]) > 0)
                {
                    Grilla.Rows.Add(VectorDatos[0], VectorDatos[1], VectorDatos[2], VectorDatos[3]);
                }
                
                C++;
                DatosLeidos = AD.ReadLine();
            }
            
            //cerrar
            AD.Close();
            AD.Dispose();

            return C;
        }

        public Decimal PromedioDeuda2()
        {
            Decimal Promedio = 0;
            Promedio = Total / C;

            return Promedio;
        }





    }
}
