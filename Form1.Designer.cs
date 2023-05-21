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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxPrincipal = new System.Windows.Forms.TextBox();
            this.buttonElegirArchivo = new System.Windows.Forms.Button();
            this.labelRutaArchivo = new System.Windows.Forms.Label();
            this.buttonAlternarModo = new System.Windows.Forms.Button();
            this.labelArchivoElegido = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 83);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(420, 20);
            this.toolStripStatusLabel1.Text = "Hecho por: Diana Yulissa Sesma Santiago y Kristan Ruíz Limón";
            // 
            // textBoxPrincipal
            // 
            this.textBoxPrincipal.Location = new System.Drawing.Point(77, 197);
            this.textBoxPrincipal.Multiline = true;
            this.textBoxPrincipal.Name = "textBoxPrincipal";
            this.textBoxPrincipal.Size = new System.Drawing.Size(541, 386);
            this.textBoxPrincipal.TabIndex = 2;
            // 
            // buttonElegirArchivo
            // 
            this.buttonElegirArchivo.Location = new System.Drawing.Point(12, 89);
            this.buttonElegirArchivo.Name = "buttonElegirArchivo";
            this.buttonElegirArchivo.Size = new System.Drawing.Size(130, 36);
            this.buttonElegirArchivo.TabIndex = 4;
            this.buttonElegirArchivo.Text = "Elegir archivo...";
            this.buttonElegirArchivo.UseVisualStyleBackColor = true;
            // 
            // labelRutaArchivo
            // 
            this.labelRutaArchivo.AutoSize = true;
            this.labelRutaArchivo.Location = new System.Drawing.Point(148, 97);
            this.labelRutaArchivo.Name = "labelRutaArchivo";
            this.labelRutaArchivo.Size = new System.Drawing.Size(72, 20);
            this.labelRutaArchivo.TabIndex = 5;
            this.labelRutaArchivo.Text = "labelRuta";
            // 
            // buttonAlternarModo
            // 
            this.buttonAlternarModo.Location = new System.Drawing.Point(553, 97);
            this.buttonAlternarModo.Name = "buttonAlternarModo";
            this.buttonAlternarModo.Size = new System.Drawing.Size(119, 37);
            this.buttonAlternarModo.TabIndex = 6;
            this.buttonAlternarModo.Text = "Alternar Vista";
            this.buttonAlternarModo.UseVisualStyleBackColor = true;
            // 
            // labelArchivoElegido
            // 
            this.labelArchivoElegido.AutoSize = true;
            this.labelArchivoElegido.Location = new System.Drawing.Point(13, 612);
            this.labelArchivoElegido.Name = "labelArchivoElegido";
            this.labelArchivoElegido.Size = new System.Drawing.Size(143, 20);
            this.labelArchivoElegido.TabIndex = 7;
            this.labelArchivoElegido.Text = "labelArchivoElegido";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(336, 149);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 27);
            this.numericUpDown1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 672);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelArchivoElegido);
            this.Controls.Add(this.buttonAlternarModo);
            this.Controls.Add(this.labelRutaArchivo);
            this.Controls.Add(this.buttonElegirArchivo);
            this.Controls.Add(this.textBoxPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBoxPrincipal;
        private Button buttonElegirArchivo;
        private Label labelRutaArchivo;
        private Button buttonAlternarModo;
        private Label labelArchivoElegido;
        private NumericUpDown numericUpDown1;
    }
}