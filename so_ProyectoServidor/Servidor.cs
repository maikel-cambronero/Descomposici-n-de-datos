using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using SO_ServidorProyectoFinal;

namespace so_ProyectoServidor
{
    class Servidor
    {
        private TcpListener server;
        private TcpClient client = new TcpClient();
        private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 8000);
        private List<Connection> list = new List<Connection>();
        private List<Datos> listaPersonas = new List<Datos>();
        Connection con;

        private struct Connection
        {
            public NetworkStream stream;
            public StreamWriter streamW;
            public StreamReader streamR;
            public string nick;
        }

        Datos datos;
        String CadenaCedula;
        String CadenaNombre;
        String CadenaTelefono;

        public Servidor()
        {
            inicio();
            datos = new Datos();
        }

        public void inicio()
        {
            Console.WriteLine("Activando el servidor...");
            Console.WriteLine("El servidor fue activado exitosamente");

            server = new TcpListener(ipendpoint);
            server.Start();

            while (true)
            {
                client = server.AcceptTcpClient();
                con = new Connection();
                con.stream = client.GetStream();
                con.streamR = new StreamReader(con.stream);
                con.streamW = new StreamWriter(con.stream);
                con.nick = con.streamR.ReadLine();
                list.Add(con);

                Console.WriteLine("" + con.nick + " ha establecido conexión exitosamente!");
                Console.WriteLine("" + list.Count + " usuarios conectados");

                Thread t = new Thread(escucharConexion);
                t.Start();
            }
        }

        void escucharConexion()
        {
            Connection hcon = con;

            do
            {
                try
                {
                    string mensaje = hcon.streamR.ReadLine();
                    desarmarString(mensaje);
                    foreach (Connection c in list)
                    {
                        try
                        {
                            c.streamW.WriteLine(mensaje);
                            c.streamW.Flush();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    list.Remove(hcon);
                    Console.WriteLine(con.nick + " se ha desconectado");
                    Console.WriteLine("" + list.Count + " usuarios conectados...");
                    break;
                }
            }
            while (true);
        }

        void desarmarString(string mensaje)
        {
            string[] datos = mensaje.Split("/");

            for (int i = 0; i < datos.Length; i++)
            {
                if (i == 0)
                {
                    TextWriter escribirced = new StreamWriter(@"D:\OneDrive - Universidad Latina\U La Tina\6° Cuatrimestre\Sistemas Operativos\Proyecto Final\CedulaDatos.txt");
                    CadenaCedula += datos[i] + Environment.NewLine;
                    escribirced.WriteLine(CadenaCedula);
                    escribirced.Close();
                }
                else if (i == 1)
                {
                    TextWriter escribirnom = new StreamWriter(@"D:\OneDrive - Universidad Latina\U La Tina\6° Cuatrimestre\Sistemas Operativos\Proyecto Final\NombreDatos.txt");
                    CadenaNombre += datos[i] + Environment.NewLine;
                    escribirnom.WriteLine(CadenaNombre);
                    escribirnom.Close();
                }
                else
                {
                    TextWriter escribirtel = new StreamWriter(@"D:\OneDrive - Universidad Latina\U La Tina\6° Cuatrimestre\Sistemas Operativos\Proyecto Final\TelefonoDatos.txt");
                    CadenaTelefono += datos[i] + Environment.NewLine;
                    escribirtel.WriteLine(CadenaTelefono);
                    escribirtel.Close();
                }
            }
        }

    }
}