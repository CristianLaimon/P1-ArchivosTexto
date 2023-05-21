using System.Configuration;
using System.Text;

namespace Practica_1_ArchivoTexto
{
    public partial class Form1 : Form
    {
        private FileStream flujo;
        private StreamReader lector;
        private StringBuilder texto;

        public Form1()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (flujo != null)
            {
                flujo.Close();
                lector.Close();
            }
            Application.Exit();
        }

        private void buttonAlternarModo_Click(object sender, EventArgs e)
        {
            flujo.Seek(0, SeekOrigin.Begin);
            texto = new();
            textBoxPrincipal.Text = "";
            byte contador = 0, contadorBloques = 0;
            

            while (!lector.EndOfStream)
            {
                if (contador < (byte)numericUpDownLineasBloque.Value)
                {
                    texto.AppendLine(lector.ReadLine());
                    contador++;
                }
                else
                {
                    textBoxPrincipal.Text += texto.ToString();
                    textBoxPrincipal.Text += "\n\r++++++++++\n\r\r\n\r\n";
                    texto.Clear();
                    contador = 0;
                    contadorBloques++;
                }
            }

            labelNoBloques.Text = "Numero de Bloques: " + " " + contadorBloques.ToString();
        }

        private void buttonElegirArchivo_Click(object sender, EventArgs e)
        {
            if (flujo != null)
            {
                flujo.Close();
                lector.Close();
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                flujo = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                lector = new StreamReader(flujo);

                textBoxPrincipal.Text = lector.ReadToEnd();
                labelArchivoElegido.Text = Path.GetFileName(openFileDialog.FileName);
                toolStripStatusLabelPrincipal.Text = openFileDialog.FileName;
                buttonAlternarModo.Enabled = true;
                ToggleTimer();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            labelArchivoElegido.Text = "Ningún archivo elegido";
            labelNoBloques.Text = "Numero de Bloques: 0";
            buttonAlternarModo.Enabled = false;
            openFileDialog.InitialDirectory = Path.GetFullPath("./recursos");
            this.MaximizeBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelPrincipal.Text = "Hecho Por: Diana Sesma Yulissa Santiago y Kristan Ruíz Limón";
            ToggleTimer();
        }

        private void ToggleTimer() => timer1.Enabled = !timer1.Enabled;
    }
}