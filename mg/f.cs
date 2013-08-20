using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mg
{
    public static class f
    {


        public static List<Clientes> ListadoClientes()
        {

            List<Clientes> l = new List<Clientes>();
            l.Add(new Clientes { Cliente =1, NombreCliente="LOREAL" });
            l.Add(new Clientes { Cliente = 1, NombreCliente = "UNILEVER" });
            l.Add(new Clientes { Cliente = 1, NombreCliente = "MEGALOG" });
            l.Add(new Clientes { Cliente = 1, NombreCliente = "OTRO" });

            return l.ToList();
        }
        public static List<grilla> CargaGrilla()
        {
            List<grilla> lt = new List<grilla>();
            grilla g = new grilla();
            g.Numero = 1;
            g.SKU = "145";
            g.Nombre = "Pendientes de Plata";
            g.Um = "UNID";
            g.Cantidad = 7;
            g.CantidadVerificada = 0;
            lt.Add(g);

            g = new grilla();
            g.Numero = 1;
            g.SKU = "234";
            g.Nombre = "Pendientes de ORO";
            g.Um = "UNID";
            g.Cantidad = 14;
            g.CantidadVerificada = 0;
            lt.Add(g);

            g = new grilla();
            g.Numero = 1;
            g.SKU = "0121";
            g.Nombre = "Collar mp3-15";
            g.Um = "UNID";
            g.Cantidad = 5;
            g.CantidadVerificada = 0;
            lt.Add(g);


            g = new grilla();
            g.Numero = 1;
            g.SKU = "0123";
            g.Nombre = "Collar JK-13";
            g.Um = "UNID";
            g.Cantidad = 6;
            g.CantidadVerificada = 0;
            lt.Add(g);

            return lt.ToList();
        }
    }
    public class Clientes
    {
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
    }
    public class grilla
    {
        public int Numero { get; set; }
        public string SKU { get; set; }
        public string Nombre { get; set; }
        public string Um { get; set; }
        public double Cantidad { get; set; }
        public double CantidadVerificada { get; set; }
    }
}
