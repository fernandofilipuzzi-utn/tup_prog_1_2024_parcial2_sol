using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        #region expediente 
        int[] Nros = new int[1000];
        int[] Dnis= new int[1000];
        double[] Pagos = new double[1000];
        int cont = 0;

        void Registrar(int nro, int dni, double pago)
        {
            Nros[cont] = nro;
            Dnis[cont] = dni;
            Pagos[cont] = pago;
            cont++;
        }

        double CalcularPromedio()
        {
            double sum = 0;
            double promedio = 0;
            for (int n = 0; n < cont; n++)
            { 
                sum += Pagos[n];
            }
            if(cont>0)
                promedio=sum/sum;

            return promedio;
        }

        int[] cpyNros = new int[1000];
        int[] cpyDnis = new int[1000];
        double[] cpyPagos= new double[1000];
        int cpyCont = 0;

        void CalcularMayPromedio()
        {
            cpyCont = 0;
            double promedio = CalcularPromedio();

            for (int n = 0; n < cont; n++)
            {
                if (Pagos[cont] > promedio)
                {
                    cpyNros[cpyCont] = Nros[n];
                    cpyDnis[cpyCont] = Dnis[n];
                    cpyPagos[cpyCont] = Pagos[n];
                }
            }
        }

        void Ordenar()
        {

            for (int n = 0; n < cont-1; n++)
            {
                for (int m = n + 1; m < cont; m++)
                {
                    if (Pagos[n] < Pagos[m])
                    {
                        int nro = Nros[n];
                        Nros[n] = Nros[m];
                        Nros[m] = nro;

                        int dni= Dnis[n];
                        Dnis[n] = Dnis[m];
                        Dnis[m] = dni;

                        double pago = Pagos[n];
                        Pagos[n] = Pagos[m];
                        Pagos[m] = pago;
                    }
                }
            }
        }

        int BuscarPorNro(int nro)
        {
            int idx = -1;
            int n = 0;

            while ( n < cont && idx==-1)
            {
                if (Nros[n]==nro)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test
            Registrar(23, 332323232, 220.3);
            Registrar(27, 332323232, 110.3);
            Registrar(13, 382323232, 220.3);
            Registrar(15, 332323232, 20.3);
        }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();
         
            while (formDatos.ShowDialog() == DialogResult.OK)
            {
                int nro = Convert.ToInt32(formDatos.tbNroCausa.Text);
                int dni = Convert.ToInt32(formDatos.tbDNI.Text);
                double pago = Convert.ToDouble(formDatos.tbMonto.Text);

                Registrar(nro,dni, pago);

                formDatos.tbNroCausa.Clear();
                formDatos.tbDNI.Clear();
                formDatos.tbMonto.Clear();

                Text = cont.ToString();
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();
            Ordenar();

            for (int n = 0; n < cont; n++)
            {
                int dni = Dnis[n];
                int nro = Nros[n];
                double pago = Pagos[n];
                formVer.listBox1.Items.Add($"{nro} - {dni} - {pago}");
            }

            formVer.ShowDialog();

            formVer.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVer formVer=   new FormVer();
            /*
             * 
             * forma sencilla para cuando no me pide ordenar los datos ordenados
             * 
            double promedio = CalcularPromedio();

            for (int n = 0; n < cont; n++)
            {
                if (Pagos[cont] > promedio)
                {
                    int nro = Nros[n];
                    int dni = Dnis[n];
                    double pago = Pagos[n];
                    formVer.listBox1.Items.Add($"{nro} - {dni} - {pago}");
                }
            }
            **/

            //forma que me resultaria util para cuando necesito ordenar los datos filtrados
            CalcularMayPromedio();

            for (int n = 0; n < cpyCont; n++)
            {
                int dni = cpyDnis[n];
                int nro = cpyNros[n];
                double pago = cpyPagos[n];
                formVer.listBox1.Items.Add($"{nro} - {dni} - {pago}");
            }
            formVer.ShowDialog();

            formVer.Dispose();
        }

        private void btnVerExpedientesPorDNI_Click(object sender, EventArgs e)
        {
            
            FormVer formVer = new FormVer();

            int dni = Convert.ToInt32(tbDNI.Text);

            int m = 0;
            for (int n = 0; n < cont; n++)
            {
                int dni1 = Dnis[n];
                if (dni1== dni)
                {
                    int nro = Nros[n];
                    double pago = Pagos[n];
                    formVer.listBox1.Items.Add($"{nro} - {dni} - {pago}");
                    m++;
                }
            }
            if (m == 0)
            {
                formVer.listBox1.Items.Add("No se encontraron expedientes");
            }

            formVer.ShowDialog();

            formVer.Dispose();
        }

        private void btnVerCausa_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(tbNumeroCausa.Text);
            int idx = BuscarPorNro(nro);

            FormDatos formDatos = new FormDatos();

            if (idx > -1)
            {
                formDatos.tbNroCausa.Text = Nros[idx].ToString();
                formDatos.tbDNI.Text = Dnis[idx].ToString();
                formDatos.tbMonto.Text = Pagos[idx].ToString("0.00");
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
            formDatos.ShowDialog();
        }
    }
}
