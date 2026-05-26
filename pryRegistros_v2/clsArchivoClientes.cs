using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Drawing;

namespace pryRegistros_v2
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";
        Decimal Total = 0;
        Int32 C = 0;

        public RegCliente[] VectorClientes = new RegCliente[5];

        public Int32 CantidadClientes = 0;

        public struct RegCliente
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
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

        public Int32 CantidadClient()
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

        public void CargarDesdeArchivo()
        {
            if (File.Exists(NombreArchivo) == true)
            {
                StreamReader SR = new StreamReader(NombreArchivo);
                CantidadClientes = 0;

                String linea = SR.ReadLine();
                while (linea != null)
                {
                    if (CantidadClientes < 100)
                    {
                        String[] vec = linea.Split(';');

                        VectorClientes[CantidadClientes].Codigo = Convert.ToInt32(vec[0]);
                        VectorClientes[CantidadClientes].Nombre = vec[1];
                        VectorClientes[CantidadClientes].Deuda = Convert.ToDecimal(vec[2]);
                        VectorClientes[CantidadClientes].Limite = Convert.ToDecimal(vec[3]);

                        CantidadClientes++;
                    }
                    linea = SR.ReadLine();
                }
                SR.Close();
                SR.Dispose(); 
            }
        }
        public void OrdenarClientes(String Campo, String Modo)
        {
            for (int i = 0; i < CantidadClientes - 1; i++)
            {
                for (int j = 0; j < CantidadClientes - 1; j++)
                {
                    bool debeIntercambiar = false;

                    if (Campo == "Código")
                    {
                        if (Modo == "Ascendente")
                        {
                            if (VectorClientes[j].Codigo > VectorClientes[j + 1].Codigo)
                            { debeIntercambiar = true; }
                        }
                        if (Modo == "Descendente")
                        {
                            if (VectorClientes[j].Codigo < VectorClientes[j + 1].Codigo)
                            { debeIntercambiar = true; }
                        }
                    }
                    
                    if (Campo == "Nombre y Apellido")
                    {
                        if (Modo == "Ascendente")
                        {
                            if (string.Compare(VectorClientes[j].Nombre, VectorClientes[j + 1].Nombre) > 0)
                            { debeIntercambiar = true; }
                        }
                        if (Modo == "Descendente")
                        {
                            if (string.Compare(VectorClientes[j].Nombre, VectorClientes[j + 1].Nombre) < 0)
                            { debeIntercambiar = true; }
                        }
                    }

                    if (Campo == "Deuda")
                    {
                        if (Modo == "Ascendente")
                        {
                            if (VectorClientes[j].Deuda > VectorClientes[j + 1].Deuda)
                            { debeIntercambiar = true; }
                        }
                        if (Modo == "Descendente")
                        {
                            if (VectorClientes[j].Deuda < VectorClientes[j + 1].Deuda)
                            { debeIntercambiar = true; }
                        }
                    }
                    if (Campo == "Límite de crédito")
                    {
                        if (Modo == "Ascendente")
                        {
                            if (VectorClientes[j].Limite > VectorClientes[j + 1].Limite)
                            { debeIntercambiar = true; }
                        }
                        if (Modo == "Descendente")
                        {
                            if (VectorClientes[j].Limite < VectorClientes[j + 1].Limite)
                            { debeIntercambiar = true; }
                        }
                    }

                    if (debeIntercambiar == true)
                    {
                        RegCliente aux = VectorClientes[j];
                        VectorClientes[j] = VectorClientes[j + 1];
                        VectorClientes[j + 1] = aux;
                    }
                }
            }
        }
    }
}
