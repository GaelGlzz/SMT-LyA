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
        private string alfabetoAnterior = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAlfabeto.TextChanged += txtAlfabeto_TextChanged;
            txtCinta.TextChanged += txtCinta_TextChanged;

            dgMT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private bool EsCaracterValido(char c)
        {
            return char.IsLetterOrDigit(c);
        }

        private void txtAlfabeto_TextChanged(object sender, EventArgs e)
        {
            string textoActual = txtAlfabeto.Text;
            string textoLimpio = "";
            int posicionCursor = txtAlfabeto.SelectionStart;

            foreach (char c in textoActual)
            {
                // Si el carácter es válido y no está duplicado
                if (EsCaracterValido(c) && !textoLimpio.Contains(c))
                {
                    textoLimpio += c;
                }
            }

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

            LimpiarCadenaDeEntrada(alfabetoAnterior, textoLimpio);
            alfabetoAnterior = textoLimpio;
        }

        private void LimpiarCadenaDeEntrada(string alfabetoAnterior, string alfabetoNuevo)
        {
            string caracteresEliminados = "";
            foreach (char c in alfabetoAnterior)
            {
                if (!alfabetoNuevo.Contains(c))
                {
                    caracteresEliminados += c;
                }
            }

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

            foreach (char c in textoActual)
            {
                if (alfabeto.Contains(c) || c == 'Δ')
                {
                    textoLimpio += c;
                }
            }

            if (textoLimpio != textoActual)
            {
                txtCinta.TextChanged -= txtCinta_TextChanged;
                txtCinta.Text = textoLimpio;

                if (posicionCursor > textoLimpio.Length)
                    posicionCursor = textoLimpio.Length;

                txtCinta.SelectionStart = posicionCursor;
                txtCinta.TextChanged += txtCinta_TextChanged;
            }
        }

        public void recorrerIzquierda()
        {
            if (cabezal > 0)
            {
                dgMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Empty;
                dgMT.Rows[0].Cells[cabezal].Style.SelectionBackColor = Color.Empty;

                cabezal--;

                dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezal];
                dgMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                dgMT.Rows[0].Cells[cabezal].Style.SelectionBackColor = Color.Orange;

                
                if (ritCompuesta != null)
                    ritCompuesta.Text += "I->";
            }
            else
            {
                MessageBox.Show("No se puede mover a la izquierda. El cabezal está en el borde izquierdo de la cinta.",
                    "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void recorrerDerecha()
        {
            if (cabezal < dgMT.ColumnCount - 1)
            {
                dgMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Empty;
                dgMT.Rows[0].Cells[cabezal].Style.SelectionBackColor = Color.Empty;

                cabezal++;

                dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezal];
                dgMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                dgMT.Rows[0].Cells[cabezal].Style.SelectionBackColor = Color.Orange;

                if (ritCompuesta != null)
                    ritCompuesta.Text += "D->";
            }
            else
            {
                char[] separacion = new char[] { 'Δ' };
                cadena = cadena.Concat(separacion).ToArray();

                dgMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Empty;
                dgMT.Rows[0].Cells[cabezal].Style.SelectionBackColor = Color.Empty;

                RehacerCinta();

                cabezal++;

                dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezal];
                dgMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                dgMT.Rows[0].Cells[cabezal].Style.SelectionBackColor = Color.Orange;

                if (ritCompuesta != null)
                    ritCompuesta.Text += "D->";
            }
        }

        public void RehacerCinta()
        {
            dgMT.Columns.Clear();
            dgMT.Rows.Clear();

            for (int i = 0; i < cadena.Length; i++)
            {
                int colIndex = dgMT.Columns.Add("col" + i, i.ToString());
                dgMT.Columns[colIndex].Width = 40;
                dgMT.Columns[colIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgMT.Rows.Add(); 

            for (int i = 0; i < cadena.Length; i++)
            {
                dgMT.Rows[0].Cells[i].Value = cadena[i].ToString();
            }
        }

        private void CargarCintaEnGrid()
        {
            // Validar que haya una cadena
            string cinta = txtCinta.Text;
            if (string.IsNullOrEmpty(cinta))
            {
                MessageBox.Show("Por favor, ingrese una cadena de entrada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cadena = cinta.ToCharArray();

            dgMT.Columns.Clear();
            dgMT.Rows.Clear();

           
            for (int i = 0; i < cadena.Length; i++)
            {
                
                dgMT.Columns.Add("col" + i, i.ToString());
                dgMT.Columns[i].Width = 50;
            }

            dgMT.Rows.Add();

            for (int i = 0; i < cadena.Length; i++)
            {
                dgMT.Rows[0].Cells[i].Value = cadena[i].ToString();
            }

           
            int posicionInicial = 0;

            if (txtCabezal != null && !string.IsNullOrEmpty(txtCabezal.Text))
            {
                if (int.TryParse(txtCabezal.Text, out int pos))
                {
                    if (pos >= 0 && pos < cadena.Length)
                    {
                        posicionInicial = pos;
                    }
                    else
                    {
                        MessageBox.Show($"La posición del cabezal debe estar entre 0 y {cadena.Length - 1}.\nSe usará la posición 0.",
                            "Posición inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        posicionInicial = 0;
                    }
                }
                else
                {
                    MessageBox.Show("La posición del cabezal debe ser un número.\nSe usará la posición 0.",
                        "Posición inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    posicionInicial = 0;
                }
            }
            
            cabezal = posicionInicial;

            dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezal];
            dgMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
            dgMT.Rows[0].Cells[cabezal].Style.SelectionBackColor = Color.Orange;
        }

        private void btnIniciarMT_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un alfabeto
            if (string.IsNullOrEmpty(txtAlfabeto.Text))
            {
                MessageBox.Show("Por favor, ingrese un alfabeto primero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar el alfabeto
            string alfabetoCadena = txtAlfabeto.Text;
            char[] alfabetoChar = alfabetoCadena.ToCharArray();
            alfabeto = alfabetoChar.Select(c => (int)c).ToArray();

            CargarCintaEnGrid();

            if (ritCompuesta != null)
                ritCompuesta.Clear();

            MessageBox.Show("Máquina de Turing iniciada correctamente!\n\n" +
                           $"Cabezal en posición: {cabezal}",
                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpIzq_Click(object sender, EventArgs e)
        {
            // Validar que la máquina esté iniciada
            if (cadena == null || cadena.Length == 0)
            {
                MessageBox.Show("Primero debe iniciar la máquina de Turing.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            recorrerIzquierda();
        }

        private void btnOpDer_Click(object sender, EventArgs e)
        {
            // Validar que la máquina esté iniciada
            if (cadena == null || cadena.Length == 0)
            {
                MessageBox.Show("Primero debe iniciar la máquina de Turing.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            recorrerDerecha();
        }

        private void btnAIzquierda_Click(object sender, EventArgs e)
        {
            btnOpIzq_Click(sender, e);
        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {
            string texto = txtCinta.Text;

            int posicion = txtCinta.SelectionStart;

            if (posicion < 0)
                posicion = 0;

            if (posicion > texto.Length)
                posicion = texto.Length;

            texto = texto.Insert(posicion, "Δ");

            txtCinta.Text = texto;

            // Volver a colocar el cursor después del símbolo insertado
            txtCinta.SelectionStart = posicion + 1;
        }

        private void dgMT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}