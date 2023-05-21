namespace Practica_1_ArchivoTexto
{
    public partial class Form1 : Form
    {
        private FileStream flujo;
        private bool modoVista = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAlternarModo_Click(object sender, EventArgs e)
        {
            if (modoVista)
            {

            }
        }

        private void buttonElegirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                flujo = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.ReadWrite);
                StreamReader lector = new StreamReader(flujo);
                textBoxPrincipal.Text = lector.ReadToEnd();
                labelArchivoElegido.Text = Path.GetFileName(openFileDialog.FileName);
                toolStripStatusLabelPrincipal.Text = openFileDialog.FileName;
                ToggleTimer();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Controls[0].Visible = false;
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            labelArchivoElegido.Text = "Ningún archivo elegido";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelPrincipal.Text = "Hecho Por: Diana Sesma Yulissa Santiago y Kristan Ruíz Limón";
            ToggleTimer();
        }

        private void ToggleTimer() => timer1.Enabled = !timer1.Enabled;
    }
}