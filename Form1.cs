using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMaquinaTuring
{
    public partial class Form1 : Form
    {
        int[] alfabeto;
        char[] cadena;
        int cabezal;
        string blanco = "Δ";
        string valeval_mal="La cadena no es válida para el alfabeto definido.";
        public void recorrerIzquierda()
        {
            int cabezalActual = dgMT.CurrentCell.ColumnIndex;

            if (cabezalActual > 0)
            {
                dgMT.CurrentCell.Style.BackColor = Color.Empty;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Empty;
                dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezalActual - 1];
                dgMT.CurrentCell.Style.BackColor = Color.Yellow;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Orange;
                cabezal--;
            }
            else
            {
                MessageBox.Show("No se puede mover a la izquierda. El cabezal está en el borde izquierdo de la cinta.");
            }
        }

        public void recorrerDerecha()
        {
            int cabezalActual = dgMT.CurrentCell.ColumnIndex;
            if (cabezalActual < dgMT.ColumnCount - 1)
            {
                dgMT.CurrentCell.Style.BackColor = Color.Empty;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Empty;
                dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezalActual + 1];
                dgMT.CurrentCell.Style.BackColor = Color.Yellow;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Orange;
                cabezal++;
            }
            else
            {
                MessageBox.Show("No se puede mover a la derecha. El cabezal está en el borde derecho de la cinta.");
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnAIzquierda_Click(object sender, EventArgs e)
        {

        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {

        }
    }
}
