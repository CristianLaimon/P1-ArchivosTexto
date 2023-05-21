namespace Practica_1_ArchivoTexto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPrincipal = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxPrincipal = new System.Windows.Forms.TextBox();
            this.buttonElegirArchivo = new System.Windows.Forms.Button();
            this.buttonAlternarModo = new System.Windows.Forms.Button();
            this.labelArchivoElegido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLineasBloque = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelNoBloques = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineasBloque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 83);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(232, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lector de Archivos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPrincipal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(749, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPrincipal
            // 
            this.toolStripStatusLabelPrincipal.Name = "toolStripStatusLabelPrincipal";
            this.toolStripStatusLabelPrincipal.Size = new System.Drawing.Size(420, 20);
            this.toolStripStatusLabelPrincipal.Text = "Hecho por: Diana Yulissa Sesma Santiago y Kristan Ruíz Limón";
            // 
            // textBoxPrincipal
            // 
            this.textBoxPrincipal.Location = new System.Drawing.Point(38, 184);
            this.textBoxPrincipal.Multiline = true;
            this.textBoxPrincipal.Name = "textBoxPrincipal";
            this.textBoxPrincipal.ReadOnly = true;
            this.textBoxPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPrincipal.Size = new System.Drawing.Size(656, 385);
            this.textBoxPrincipal.TabIndex = 2;
            // 
            // buttonElegirArchivo
            // 
            this.buttonElegirArchivo.Location = new System.Drawing.Point(70, 107);
            this.buttonElegirArchivo.Name = "buttonElegirArchivo";
            this.buttonElegirArchivo.Size = new System.Drawing.Size(130, 36);
            this.buttonElegirArchivo.TabIndex = 4;
            this.buttonElegirArchivo.Text = "Eligir Archivo";
            this.buttonElegirArchivo.UseVisualStyleBackColor = true;
            this.buttonElegirArchivo.Click += new System.EventHandler(this.buttonElegirArchivo_Click);
            // 
            // buttonAlternarModo
            // 
            this.buttonAlternarModo.Location = new System.Drawing.Point(510, 107);
            this.buttonAlternarModo.Name = "buttonAlternarModo";
            this.buttonAlternarModo.Size = new System.Drawing.Size(175, 37);
            this.buttonAlternarModo.TabIndex = 6;
            this.buttonAlternarModo.Text = "Dividir en bloques";
            this.buttonAlternarModo.UseVisualStyleBackColor = true;
            this.buttonAlternarModo.Click += new System.EventHandler(this.buttonAlternarModo_Click);
            // 
            // labelArchivoElegido
            // 
            this.labelArchivoElegido.AutoSize = true;
            this.labelArchivoElegido.Location = new System.Drawing.Point(128, 604);
            this.labelArchivoElegido.Name = "labelArchivoElegido";
            this.labelArchivoElegido.Size = new System.Drawing.Size(143, 20);
            this.labelArchivoElegido.TabIndex = 7;
            this.labelArchivoElegido.Text = "labelArchivoElegido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. Lineas P/bloque";
            // 
            // numericUpDownLineasBloque
            // 
            this.numericUpDownLineasBloque.Location = new System.Drawing.Point(379, 145);
            this.numericUpDownLineasBloque.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLineasBloque.Name = "numericUpDownLineasBloque";
            this.numericUpDownLineasBloque.Size = new System.Drawing.Size(94, 27);
            this.numericUpDownLineasBloque.TabIndex = 10;
            this.numericUpDownLineasBloque.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Eligiendo un archivo...";
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelNoBloques
            // 
            this.labelNoBloques.AutoSize = true;
            this.labelNoBloques.Location = new System.Drawing.Point(321, 604);
            this.labelNoBloques.Name = "labelNoBloques";
            this.labelNoBloques.Size = new System.Drawing.Size(105, 20);
            this.labelNoBloques.TabIndex = 14;
            this.labelNoBloques.Text = "labelnoChunks";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(508, 599);
            this.botonSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(86, 31);
            this.botonSalir.TabIndex = 15;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 689);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.labelNoBloques);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownLineasBloque);
            this.Controls.Add(this.labelArchivoElegido);
            this.Controls.Add(this.buttonAlternarModo);
            this.Controls.Add(this.buttonElegirArchivo);
            this.Controls.Add(this.textBoxPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(767, 736);
            this.MinimumSize = new System.Drawing.Size(767, 736);
            this.Name = "Form1";
            this.Text = "Archivos De Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineasBloque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelPrincipal;
        private TextBox textBoxPrincipal;
        private Button buttonElegirArchivo;
        private Button buttonAlternarModo;
        private Label labelArchivoElegido;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDownLineasBloque;
        private OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer1;
        private Label labelNoBloques;
        private Button botonSalir;
    }
}