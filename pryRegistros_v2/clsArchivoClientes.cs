using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace pryRegistros_v2
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";
        Decimal Total = 0;
        Int32 C = 0;

        private struct RegClientes
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }

        private RegClientes[] VecClientes = new RegClientes[1500];
        private Int32 IND = 0;

        private void CargarVector()
        {

            string DatosLeidos;
            string[] VectorDatos = new string[4];
            IND = 0;

            //ab
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VectorDatos = DatosLeidos.Split(';');

                VecClientes[IND].Codigo = Convert.ToInt32(VectorDatos[0]);
                VecClientes[IND].Nombre = VectorDatos[1];
                VecClientes[IND].Deuda = Convert.ToDecimal(VectorDatos[2]);
                VecClientes[IND].Limite = Convert.ToDecimal(VectorDatos[3]);
                IND++;

                DatosLeidos = AD.ReadLine();
            }

            //cerr
            AD.Close();
            AD.Dispose();

        }

        private void OrdenarVector()
        {
            RegClientes aux;

            for (Int32 c = 0; c < IND - 1; c++) //contador de vueltas 
            {
                for (Int32 i = 0; i < IND - 1; i++) //recorre el vector
                {
                    if (VecClientes[i].Codigo > VecClientes[i + 1].Codigo)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }
        }

        private void ReescribirArchivo()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);

            for (Int32 i = 0; i < IND; i++)
            { 
                AD.Write(VecClientes[i].Codigo);
                AD.Write(";");
                AD.Write(VecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(VecClientes[i].Deuda);
                AD.Write(";");
                AD.WriteLine(VecClientes[i].Limite);
            }
            AD.Close();
            AD.Dispose();
        }

        public void OrdenarArchivos()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();
        }


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


        // frm clientes deudores

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
            C = 0;

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

                if (Convert.ToInt32(VectorDatos[2]) > 0)
                {
                    Grilla.Rows.Add(VectorDatos[0], VectorDatos[1], VectorDatos[2], VectorDatos[3]);
                    C++;

                }
                
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

        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] VectorDatos = new string[4];

            Int32 cantidad = 0;
            Decimal total = 0;


            StreamWriter Reporte = new StreamWriter("Reporte.CSV", false, Encoding.UTF8);

            Reporte.WriteLine("Listado de clientes");
            Reporte.WriteLine("");
            Reporte.WriteLine("Código;Nombre;Límite;Deuda");  


            //ab
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VectorDatos = DatosLeidos.Split(';');

                Reporte.Write(VectorDatos[0]);
                Reporte.Write(";");
                Reporte.Write(VectorDatos[1]);
                Reporte.Write(";");
                Reporte.Write(VectorDatos[3]);
                Reporte.Write(";");
                Reporte.WriteLine(VectorDatos[2]);

                DatosLeidos = AD.ReadLine();
                cantidad++;
                total = total + Convert.ToDecimal(VectorDatos[2]); //acum
            }

            //cerr
            AD.Close();
            AD.Dispose();
            Reporte.WriteLine();
            Reporte.Write("Total de deudas:;;");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de clientes:;;");
            Reporte.WriteLine(cantidad);
            Reporte.Write("Promedio de deuda:;;");
            Reporte.WriteLine(total / cantidad);


            Reporte.Close();
            Reporte.Dispose();
        }





    }
}
