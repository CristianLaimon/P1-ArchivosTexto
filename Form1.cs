namespace Practica_1_ArchivoTexto
{
    public partial class Form1 : Form
    {
        private FileStream flujo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Controls[0].Visible = false;
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
        }

        private void buttonElegirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                flujo = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.ReadWrite);
                StreamReader lector = new StreamReader(flujo);
                textBoxPrincipal.Text = lector.ReadToEnd();
            }
        }
    }
}