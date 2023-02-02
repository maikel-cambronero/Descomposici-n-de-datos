using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace so_ProyectoCliente
{
    public partial class Form1 : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamW;
        static private StreamReader streamR;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknow";

        private delegate void DaddItem(String s);


        private void addItem(String s)
        {
            lstDatos.Items.Add(s);
        }

        public void listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DaddItem(addItem), streamR.ReadLine());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se a logrado establecer la comunicación con el servidor... " + ex);
                    Application.Exit();
                }
            }
        }

        public void conectar()
        {
            try
            { 
                client.Connect("127.0.0.1", 8000);

                if (client.Connected)
                {
                    Thread t = new Thread(listen);
                    stream = client.GetStream();
                    streamW = new StreamWriter(stream);
                    streamR = new StreamReader(stream);

                    streamW.WriteLine(nick);
                    streamW.Flush();
                    t.Start();
                }
                else
                {
                    MessageBox.Show("El servidor no está disponible intene más tarde...");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontrarón problemas para conectar con el servidor: " + ex);
                Application.Exit();
            }
        }
        public Form1()
        {
            InitializeComponent();
            pCargarDatos.Visible = false;
            pVerDatos.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            nick = txtUsername.Text;
            conectar();

            pCargarDatos.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            streamW.WriteLine(txtCedula.Text + " / " + txtNombre.Text + " / " + txtTelefono.Text);
            streamW.Flush();
            MessageBox.Show("Los datos se han enviado correctamente...");
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            pVerDatos.Visible = true;

            int filas = lstDatos.Items.Count;
            lstDatos.Visible = filas != 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pCargarDatos.Visible = true;
            pVerDatos.Visible = false;
            
        }
    }
}
