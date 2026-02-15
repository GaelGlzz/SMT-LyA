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
        char[] separacion = new char[] { 'Δ' };
        int cabezal;
        string blanco = "Δ";
        private string alfabetoAnterior = "";
        private ToolTip toolTip;

        public Form1()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.AutoPopDelay = 2000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAlfabeto.TextChanged += txtAlfabeto_TextChanged;
            txtCinta.TextChanged += txtCinta_TextChanged;
            txtSimbolo.KeyPress += txtSimbolo_KeyPress;

            dgMT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private bool EsCaracterValido(char c)
        {
            return char.IsLetterOrDigit(c);
        }

        public void moverIzquierda()
        {
            int columnaActual = dgMT.CurrentCell.ColumnIndex;

            if (columnaActual > 0)
            {
                dgMT.CurrentCell.Style.BackColor = Color.Empty;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Empty;
                dgMT.CurrentCell = dgMT.Rows[0].Cells[columnaActual - 1];
                dgMT.CurrentCell.Style.BackColor = Color.Yellow;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Orange;
                cabezal--;
            }
            else
            {
                MessageBox.Show("Has llegado al inicio de la cinta (Izquierda).");
            }
        }

        public void moverDerecha()
        {
            int columnaActual = dgMT.CurrentCell.ColumnIndex;

            if (columnaActual < dgMT.Columns.Count - 1)
            {
                dgMT.CurrentCell.Style.BackColor = Color.Empty;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Empty;
                dgMT.CurrentCell = dgMT.Rows[0].Cells[columnaActual + 1];
                dgMT.CurrentCell.Style.BackColor = Color.Yellow;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Orange;
                cabezal++;
            }
            else
            {
                cadena = cadena.Concat(separacion).ToArray();

                dgMT.Columns.Clear();
                dgMT.Rows.Clear();

                for (int i = 0; i < cadena.Length; i++)
                {
                    dgMT.Columns.Add("Col" + i, i.ToString());
                    dgMT.Columns[i].Width = 40;
                }
                object[] filaEstructurada = cadena.Select(c => c.ToString()).ToArray();
                dgMT.Rows.Add(filaEstructurada);

                cabezal++;
                dgMT.Focus();

                dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezal];
                dgMT.CurrentCell.Style.BackColor = Color.Yellow;
                dgMT.CurrentCell.Style.SelectionBackColor = Color.Orange;
            }
        }

        public void ActualizarCinta()
        {
            dgMT.CurrentCell.Style.BackColor = Color.Empty;
            dgMT.CurrentCell.Style.SelectionBackColor = Color.Empty;
            dgMT.CurrentCell = dgMT.Rows[0].Cells[cabezal];
            dgMT.CurrentCell.Style.BackColor = Color.Yellow;
            dgMT.CurrentCell.Style.SelectionBackColor = Color.Orange;
        }

        public void RehacerCinta()
        {
            dgMT.Columns.Clear();
            dgMT.Rows.Clear();
            for (int i = 0; i < cadena.Length; i++)
            {
                dgMT.Columns.Add("Col" + i, i.ToString());
                dgMT.Columns[i].Width = 40;
            }
            object[] filaEstructurada = cadena.Select(c => c.ToString()).ToArray();
            dgMT.Rows.Add(filaEstructurada);
        }

        private void txtAlfabeto_TextChanged(object sender, EventArgs e)
        {
            string textoActual = txtAlfabeto.Text;
            string textoLimpio = "";
            int posicionCursor = txtAlfabeto.SelectionStart;
            bool tienEerror = false;

            foreach (char c in textoActual)
            {
                if (EsCaracterValido(c) && !textoLimpio.Contains(c))
                {
                    textoLimpio += c;
                }
                else if (!EsCaracterValido(c))
                {
                    tienEerror = true;
                }
                else if (textoLimpio.Contains(c))
                {
                    tienEerror = true;
                }
            }

            if (textoLimpio != textoActual)
            {
                txtAlfabeto.TextChanged -= txtAlfabeto_TextChanged;
                txtAlfabeto.Text = textoLimpio;
                if (posicionCursor > textoLimpio.Length)
                    posicionCursor = textoLimpio.Length;
                txtAlfabeto.SelectionStart = posicionCursor;
                txtAlfabeto.TextChanged += txtAlfabeto_TextChanged;

                if (tienEerror)
                {
                    toolTip.ToolTipIcon = ToolTipIcon.Warning;
                    toolTip.ToolTipTitle = "Carácter no válido";
                    toolTip.Show("Solo se permiten caracteres alfanuméricos sin repetición.", txtAlfabeto, 0, -45, 2000);
                }
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
            bool tienEerror = false;

            foreach (char c in textoActual)
            {
                if (alfabeto.Contains(c) || c == 'Δ')
                {
                    textoLimpio += c;
                }
                else
                {
                    tienEerror = true;
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

                if (tienEerror)
                {
                    toolTip.ToolTipIcon = ToolTipIcon.Warning;
                    toolTip.ToolTipTitle = "Carácter no permitido";
                    toolTip.Show("Solo se permiten símbolos del alfabeto y Δ.", txtCinta, 0, -45, 2000);
                }
            }
        }

        private void CargarCintaEnGrid()
        {
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
                dgMT.Columns.Add("Col" + i, i.ToString());
                dgMT.Columns[i].Width = 40;
            }

            object[] filaEstructurada = cadena.Select(c => c.ToString()).ToArray();
            dgMT.Rows.Add(filaEstructurada);

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
            dgMT.CurrentCell.Style.BackColor = Color.Yellow;
            dgMT.CurrentCell.Style.SelectionBackColor = Color.Orange;
        }

        private void btnIniciarMT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlfabeto.Text))
            {
                MessageBox.Show("Por favor, ingrese un alfabeto primero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void txtSimbolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Si no hay cadena cargada, no permitir entrada
            if (cadena == null || cadena.Length == 0)
            {
                e.Handled = true;
                toolTip.ToolTipIcon = ToolTipIcon.Warning;
                toolTip.ToolTipTitle = "Cadena no iniciada";
                toolTip.Show("Primero debe cargar una cadena.", txtSimbolo, 0, -45, 2000);
                return;
            }

            // Verificar si el carácter está en la cadena
            bool caracterEnCadena = false;
            foreach (char c in cadena)
            {
                if (c == e.KeyChar)
                {
                    caracterEnCadena = true;
                    break;
                }
            }

            // Si el carácter no está en la cadena, rechazarlo
            if (!caracterEnCadena)
            {
                e.Handled = true;
                toolTip.ToolTipIcon = ToolTipIcon.Warning;
                toolTip.ToolTipTitle = "Símbolo no en cadena";
                toolTip.Show($"El símbolo '{e.KeyChar}' no está en la cadena de entrada.", txtSimbolo, 0, -45, 2000);
            }
        }

        private async void btnOpIzq_Click(object sender, EventArgs e)
        {
            if (cadena == null || cadena.Length == 0)
            {
                MessageBox.Show("Primero debe iniciar la máquina de Turing.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await EjecutarOperacion(false);
        }

        private async void btnOpDer_Click(object sender, EventArgs e)
        {
            if (cadena == null || cadena.Length == 0)
            {
                MessageBox.Show("Primero debe iniciar la máquina de Turing.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await EjecutarOperacion(true);
        }

        private async Task EjecutarOperacion(bool derecha)
        {
            if (radBuscarIgual.Checked)
            {
                await BuscarIgual(derecha);
            }
            else if (radEliminarIgual.Checked)
            {
                await EliminarIgual(derecha);
            }
            else if (radEscribirPosAct.Checked)
            {
                await EscribirPosicionActual(derecha);
            }
            else if (radBuscarDif.Checked)
            {
                await BuscarDiferente(derecha);
            }
            else if (radEliminarDif.Checked)
            {
                await EliminarDiferente(derecha);
            }
            else if (radEliminarHastaEncontrar.Checked)
            {
                await EliminarHastaEncontrar(derecha);
            }
        }

        private async Task BuscarIgual(bool derecha)
        {
            if (string.IsNullOrEmpty(txtSimbolo.Text))
            {
                MessageBox.Show("Por favor, ingrese un símbolo a buscar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char simb = txtSimbolo.Text[0];
            bool encontrado = false;

            if (derecha)
            {
                for (int i = cabezal + 1; i < cadena.Length; i++)
                {
                    moverDerecha();
                    ritCompuesta.Text += "D->";
                    await Task.Delay(500);

                    if (cadena[cabezal] == simb)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = cabezal - 1; i >= 0; i--)
                {
                    moverIzquierda();
                    ritCompuesta.Text += "I->";
                    await Task.Delay(500);

                    if (cadena[cabezal] == simb)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }

            ActualizarCinta();

            if (encontrado)
            {
                MessageBox.Show($"Símbolo '{simb}' encontrado en posición {cabezal}", "Búsqueda exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Símbolo '{simb}' no encontrado", "Búsqueda fallida",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task EliminarIgual(bool derecha)
        {
            if (string.IsNullOrEmpty(txtSimbolo.Text))
            {
                MessageBox.Show("Por favor, ingrese un símbolo a eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char simb = txtSimbolo.Text[0];
            int cont = 0;

            if (derecha)
            {
                while (cabezal < dgMT.Columns.Count - 1)
                {
                    moverDerecha();
                    ritCompuesta.Text += "D->";
                    await Task.Delay(500);

                    if (dgMT.CurrentCell.Value.ToString() == simb.ToString())
                    {
                        cont++;
                        dgMT.CurrentCell.Value = blanco;
                        ritCompuesta.Text += blanco + "->";
                    }
                }
                MessageBox.Show(cont > 0 ? $"Eliminados {cont} símbolo(s) '{simb}'" : "No se eliminó ningún símbolo");
            }
            else
            {
                while (cabezal > 0)
                {
                    moverIzquierda();
                    ritCompuesta.Text += "I->";
                    await Task.Delay(500);

                    if (dgMT.CurrentCell.Value.ToString() == simb.ToString())
                    {
                        cont++;
                        dgMT.CurrentCell.Value = blanco;
                        ritCompuesta.Text += blanco + "->";
                    }
                }

                // Verificar la primera posición
                if (dgMT.CurrentCell.Value.ToString() == simb.ToString())
                {
                    cont++;
                    dgMT.CurrentCell.Value = blanco;
                    ritCompuesta.Text += blanco + "->";
                }

                MessageBox.Show(cont > 0 ? $"Eliminados {cont} símbolo(s) '{simb}'" : "No se eliminó ningún símbolo");
            }
        }

        private async Task EscribirPosicionActual(bool derecha)
        {
            if (string.IsNullOrEmpty(txtSimbolo.Text))
            {
                MessageBox.Show("Por favor, ingrese un símbolo a escribir.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char simb = txtSimbolo.Text[0];
            cadena[cabezal] = simb;
            dgMT.Rows[0].Cells[cabezal].Value = simb.ToString();
            ritCompuesta.Text += simb + "->";

            await Task.Delay(500);

            if (derecha)
            {
                moverDerecha();
                ritCompuesta.Text += "D->";
            }
            else
            {
                moverIzquierda();
                ritCompuesta.Text += "I->";
            }

            MessageBox.Show($"Se escribió '{simb}' en la posición {cabezal}");
        }

        private async Task BuscarDiferente(bool derecha)
        {
            if (string.IsNullOrEmpty(txtSimbolo.Text))
            {
                MessageBox.Show("Por favor, ingrese un símbolo de referencia.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char simb = txtSimbolo.Text[0];
            bool encontrado = false;

            if (derecha)
            {
                while (cabezal < dgMT.Columns.Count - 1)
                {
                    moverDerecha();
                    ritCompuesta.Text += "D->";
                    await Task.Delay(500);

                    if (cadena[cabezal] != simb)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }
            else
            {
                while (cabezal > 0)
                {
                    moverIzquierda();
                    ritCompuesta.Text += "I->";
                    await Task.Delay(500);

                    if (cadena[cabezal] != simb)
                    {
                        encontrado = true;
                        break;
                    }
                }

                // Verificar la primera posición
                if (!encontrado && cadena[cabezal] != simb)
                {
                    encontrado = true;
                }
            }

            ActualizarCinta();

            if (encontrado)
            {
                MessageBox.Show($"Símbolo diferente a '{simb}' encontrado en posición {cabezal}", "Búsqueda exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró símbolo diferente a '{simb}'", "Búsqueda fallida",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task EliminarDiferente(bool derecha)
        {
            if (string.IsNullOrEmpty(txtSimbolo.Text))
            {
                MessageBox.Show("Por favor, ingrese un símbolo de referencia.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char simb = txtSimbolo.Text[0];
            int cont = 0;

            if (derecha)
            {
                while (cabezal < dgMT.Columns.Count - 1)
                {
                    moverDerecha();
                    ritCompuesta.Text += "D->";
                    await Task.Delay(500);

                    if (dgMT.CurrentCell.Value.ToString() != simb.ToString())
                    {
                        dgMT.CurrentCell.Value = blanco;
                        cont++;
                        ritCompuesta.Text += blanco + "->";
                    }
                }
                MessageBox.Show(cont > 0 ? $"Eliminados {cont} símbolo(s) diferente(s) a '{simb}'" : "No se eliminó ningún símbolo");
            }
            else
            {
                while (cabezal > 0)
                {
                    moverIzquierda();
                    ritCompuesta.Text += "I->";
                    await Task.Delay(500);

                    if (dgMT.CurrentCell.Value.ToString() != simb.ToString())
                    {
                        dgMT.CurrentCell.Value = blanco;
                        cont++;
                        ritCompuesta.Text += blanco + "->";
                    }
                }

                // Verificar la primera posición
                if (dgMT.CurrentCell.Value.ToString() != simb.ToString())
                {
                    dgMT.CurrentCell.Value = blanco;
                    cont++;
                    ritCompuesta.Text += blanco + "->";
                }

                MessageBox.Show(cont > 0 ? $"Eliminados {cont} símbolo(s) diferente(s) a '{simb}'" : "No se eliminó ningún símbolo");
            }
        }

        private async Task EliminarHastaEncontrar(bool derecha)
        {
            if (string.IsNullOrEmpty(txtSimbolo.Text))
            {
                MessageBox.Show("Por favor, ingrese un símbolo a buscar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char simb = txtSimbolo.Text[0];

            if (derecha)
            {
                while (cabezal < dgMT.Columns.Count - 1)
                {
                    moverDerecha();
                    ritCompuesta.Text += "D->";
                    await Task.Delay(500);

                    if (dgMT.CurrentCell.Value.ToString() == simb.ToString())
                    {
                        MessageBox.Show($"Se eliminaron todos los símbolos hasta encontrar '{simb}' en la posición {cabezal}");
                        return;
                    }

                    dgMT.CurrentCell.Value = blanco;
                    ritCompuesta.Text += blanco + "->";
                }

                MessageBox.Show($"Símbolo '{simb}' no encontrado");
            }
            else
            {
                while (cabezal > 0)
                {
                    moverIzquierda();
                    ritCompuesta.Text += "I->";
                    await Task.Delay(500);

                    if (dgMT.CurrentCell.Value.ToString() == simb.ToString())
                    {
                        MessageBox.Show($"Se eliminaron todos los símbolos hasta encontrar '{simb}' en la posición {cabezal}");
                        return;
                    }

                    dgMT.CurrentCell.Value = blanco;
                    ritCompuesta.Text += blanco + "->";
                }

                // Verificar la primera posición
                if (dgMT.CurrentCell.Value.ToString() == simb.ToString())
                {
                    MessageBox.Show($"Se eliminaron todos los símbolos hasta encontrar '{simb}' en la posición {cabezal}");
                    return;
                }

                MessageBox.Show($"Símbolo '{simb}' no encontrado");
            }
        }

        //insertar blanco en la cinta
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

            txtCinta.SelectionStart = posicion + 1;
        }

        private void dgMT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnAIzquierda_Click(object sender, EventArgs e)
        {
            await BuscarCadenaCompleta(false);
        }
        private async void btnADerecha_Click(object sender, EventArgs e)
        {
            await BuscarCadenaCompleta(true);
        }

        //insertar blanco en buscar cinta
        private void btnCadBlanco_Click(object sender, EventArgs e)
        {
            string texto = txtBuscarCadena.Text;
            int posicion = txtBuscarCadena.SelectionStart;

            if (posicion < 0)
                posicion = 0;

            if (posicion > texto.Length)
                posicion = texto.Length;

            texto = texto.Insert(posicion, "Δ");
            txtBuscarCadena.Text = texto;

            txtBuscarCadena.SelectionStart = posicion + 1;
        }
        //metodo para buscar la cadena 
        private async Task BuscarCadenaCompleta(bool derecha)
        {
            if (string.IsNullOrEmpty(txtBuscarCadena.Text))
            {
                MessageBox.Show("Ingrese una cadena a buscar.");
                return;
            }

            string cadenaBuscar = txtBuscarCadena.Text;
            bool encontrada = false;

            if (derecha)
            {
                for (int i = cabezal; i <= cadena.Length - cadenaBuscar.Length; i++)
                {
                    moverDerecha();
                    ritCompuesta.Text += "D->";
                    await Task.Delay(400);

                    bool coincide = true;

                    for (int j = 0; j < cadenaBuscar.Length; j++)
                    {
                        if (cadena[i + j] != cadenaBuscar[j])
                        {
                            coincide = false;
                            break;
                        }
                    }

                    if (coincide)
                    {
                        cabezal = i;
                        ActualizarCinta();
                        encontrada = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = cabezal; i >= 0; i--)
                {
                    moverIzquierda();
                    ritCompuesta.Text += "I->";
                    await Task.Delay(400);

                    if (i - cadenaBuscar.Length + 1 < 0)
                        continue;

                    bool coincide = true;

                    for (int j = 0; j < cadenaBuscar.Length; j++)
                    {
                        if (cadena[i - cadenaBuscar.Length + 1 + j] != cadenaBuscar[j])
                        {
                            coincide = false;
                            break;
                        }
                    }

                    if (coincide)
                    {
                        cabezal = i - cadenaBuscar.Length + 1;
                        ActualizarCinta();
                        encontrada = true;
                        break;
                    }
                }
            }

            if (encontrada)
                MessageBox.Show($"Cadena \"{cadenaBuscar}\" encontrada en posición {cabezal}");
            else
                MessageBox.Show($"Cadena \"{cadenaBuscar}\" no encontrada");
        }

    }
}