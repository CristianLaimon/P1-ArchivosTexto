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
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxPrincipal = new System.Windows.Forms.TextBox();
            this.buttonElegirArchivo = new System.Windows.Forms.Button();
            this.labelRutaArchivo = new System.Windows.Forms.Label();
            this.buttonAlternarModo = new System.Windows.Forms.Button();
            this.labelArchivoElegido = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 83);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(217, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lector de Archivos";
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
            this.buttonElegirArchivo.Click += new System.EventHandler(this.buttonElegirArchivo_Click);
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
            this.buttonAlternarModo.Location = new System.Drawing.Point(571, 88);
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
            this.numericUpDown1.Location = new System.Drawing.Point(217, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 27);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "No. Bloques";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. Lineas P/bloque";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(497, 153);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(94, 27);
            this.numericUpDown2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ajustes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ayuda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Eligiendo un archivo...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 672);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private Label label3;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog;
    }
}