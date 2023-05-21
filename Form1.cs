namespace Practica_1_ArchivoTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Controls[0].Visible = false;
            OpenFileDialog openFileDialog = new();
        }

        private void buttonElegirArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
    }
}