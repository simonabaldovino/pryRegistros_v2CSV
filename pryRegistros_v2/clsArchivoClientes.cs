using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryRegistros_v2
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";

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
            Int32 C = 0;

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

    }
}
