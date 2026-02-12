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
        string gael = "Gael";
        private string alfabetoAnterior = "";

        private bool EsCaracterValido(char c)
        {
            // Permitir solo letras y dígitos, no símbolos especiales
            return char.IsLetterOrDigit(c);
        }

        private void txtAlfabeto_TextChanged(object sender, EventArgs e)
        {
            string textoActual = txtAlfabeto.Text;
            string textoLimpio = "";
            int posicionCursor = txtAlfabeto.SelectionStart;

            // Procesar cada carácter
            foreach (char c in textoActual)
            {
                // Si el carácter es válido y no está duplicado
                if (EsCaracterValido(c) && !textoLimpio.Contains(c))
                {
                    textoLimpio += c;
                }
            }

            // Si hubo cambios, actualizar el textbox
            if (textoLimpio != textoActual)
            {
                txtAlfabeto.TextChanged -= txtAlfabeto_TextChanged;
                txtAlfabeto.Text = textoLimpio;
                // Ajustar la posición del cursor
                if (posicionCursor > textoLimpio.Length)
                    posicionCursor = textoLimpio.Length;
                txtAlfabeto.SelectionStart = posicionCursor;
                txtAlfabeto.TextChanged += txtAlfabeto_TextChanged;
            }

            // Limpiar la cadena de entrada si se eliminaron caracteres del alfabeto
            LimpiarCadenaDeEntrada(alfabetoAnterior, textoLimpio);
            alfabetoAnterior = textoLimpio;
        }

        private void LimpiarCadenaDeEntrada(string alfabetoAnterior, string alfabetoNuevo)
        {
            // Encontrar caracteres que se eliminaron
            string caracteresEliminados = "";
            foreach (char c in alfabetoAnterior)
            {
                if (!alfabetoNuevo.Contains(c))
                {
                    caracteresEliminados += c;
                }
            }

            // Si hay caracteres eliminados, limpiar la cadena de entrada
            if (caracteresEliminados.Length > 0)
            {
                string cintaActual = txtCinta.Text;
                string cintaLimpia = "";

                foreach (char c in cintaActual)
                {
                    if (!caracteresEliminados.Contains(c))
                    {
                        cintaLimpia += c;
                    }
                }

                if (cintaLimpia != cintaActual)
                {
                    txtCinta.TextChanged -= txtCinta_TextChanged;
                    txtCinta.Text = cintaLimpia;
                    txtCinta.TextChanged += txtCinta_TextChanged;
                }
            }
        }

        private void txtCinta_TextChanged(object sender, EventArgs e)
        {
            string alfabeto = txtAlfabeto.Text;
            string textoActual = txtCinta.Text;
            string textoLimpio = "";
            int posicionCursor = txtCinta.SelectionStart;

            // Solo permitir caracteres que estén en el alfabeto
            foreach (char c in textoActual)
            {
                if (alfabeto.Contains(c))
                {
                    textoLimpio += c;
                }
            }

            // Si hubo cambios, actualizar el textbox
            if (textoLimpio != textoActual)
            {
                txtCinta.TextChanged -= txtCinta_TextChanged;
                txtCinta.Text = textoLimpio;
                // Ajustar la posición del cursor
                if (posicionCursor > textoLimpio.Length)
                    posicionCursor = textoLimpio.Length;
                txtCinta.SelectionStart = posicionCursor;
                txtCinta.TextChanged += txtCinta_TextChanged;
            }
        }

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
            txtAlfabeto.TextChanged += txtAlfabeto_TextChanged;
            txtCinta.TextChanged += txtCinta_TextChanged;
        }

        private void btnAIzquierda_Click(object sender, EventArgs e)
        {

        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {

        }
    }
}
