using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tabuada : Form
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minMultiplicando = Convert.ToInt32(minMultiplicandotextBox.Text);
            int maxMultiplicando = Convert.ToInt32(maxMultiplicandotextBox.Text);
            int minMultiplicador = Convert.ToInt32(minMultiplicadortextBox.Text);
            int maxMultiplicador = Convert.ToInt32(maxMultiplicadortextBox.Text);
            int contadorMultiplicador;
            int contadorMultiplicando;
            List<string> tabuada = new List<string>();
            resultadoListView.View = View.Details;
            resultadoListView.Clear();
            resultadoListView.Columns.Add("Multiplicação", 240, HorizontalAlignment.Left);
            resultadoListView.Columns.Add("Resultado", 235, HorizontalAlignment.Left);


            contadorMultiplicador = minMultiplicador;
            contadorMultiplicando = minMultiplicando;

            while (contadorMultiplicando <= maxMultiplicando)
            {

                while (contadorMultiplicador <= maxMultiplicador)
                {
                    int resultado = contadorMultiplicador * contadorMultiplicando;
                    string strResultadoFormatado = String.Format("{0} x {1} =", contadorMultiplicando, contadorMultiplicador);
                    ListViewItem listViewItem = new ListViewItem(strResultadoFormatado);
                    listViewItem.SubItems.Add(Convert.ToString(resultado));
                    resultadoListView.Items.Add(listViewItem);
                    contadorMultiplicador++;
                }
                contadorMultiplicando++;
                contadorMultiplicador = minMultiplicador;
            }

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minMultiplicandotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
