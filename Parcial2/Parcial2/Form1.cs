using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    cpyNros[cpyCont] = Dnis[n];
                    cpyDnis[cpyCont] = Nros[n];
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();
         
            while (formDatos.ShowDialog() == DialogResult.OK)
            {
                int nro = Convert.ToInt32(formDatos.textBox1.Text);
                int dni = Convert.ToInt32(formDatos.textBox2.Text);
                double pago = Convert.ToDouble(formDatos.textBox3.Text);

                Registrar(nro,dni, pago);

                Text = cont.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            double promedio = CalcularPromedio();

            for (int n = 0; n < cont; n++)
            {
                if (Pagos[cont] > promedio)
                {
                    int dni = Dnis[n];
                    int nro = Nros[n];
                    double pago = Pagos[n];
                    formVer.listBox1.Items.Add($"{nro} - {dni} - {pago}");
                }
            }
            **/

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

        private void button4_Click(object sender, EventArgs e)
        {
            
            FormVer formVer = new FormVer();

            int dni = Convert.ToInt32(textBox1.Text);

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

        private void button5_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(textBox2.Text);
            int idx = BuscarPorNro(nro);

            FormDatos formDatos = new FormDatos();

            if (idx > -1)
            {
                formDatos.textBox1.Text = Nros[idx].ToString();
                formDatos.textBox2.Text = Dnis[idx].ToString();
                formDatos.textBox3.Text = Pagos[idx].ToString("0.00");
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
            formDatos.ShowDialog();
        }
    }
}
