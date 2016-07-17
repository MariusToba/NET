namespace Contract
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdaugare = new System.Windows.Forms.Button();
            this.textBoxValoare = new System.Windows.Forms.TextBox();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownContracte = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.textBoxSuma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trasareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContracte)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdaugare);
            this.groupBox1.Controls.Add(this.textBoxValoare);
            this.groupBox1.Controls.Add(this.textBoxDenumire);
            this.groupBox1.Controls.Add(this.textBoxCod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare Contract";
            // 
            // buttonAdaugare
            // 
            this.buttonAdaugare.Location = new System.Drawing.Point(102, 140);
            this.buttonAdaugare.Name = "buttonAdaugare";
            this.buttonAdaugare.Size = new System.Drawing.Size(75, 23);
            this.buttonAdaugare.TabIndex = 6;
            this.buttonAdaugare.Text = "Adaugare";
            this.buttonAdaugare.UseVisualStyleBackColor = true;
            this.buttonAdaugare.Click += new System.EventHandler(this.buttonAdaugare_Click);
            // 
            // textBoxValoare
            // 
            this.textBoxValoare.Location = new System.Drawing.Point(120, 103);
            this.textBoxValoare.Name = "textBoxValoare";
            this.textBoxValoare.Size = new System.Drawing.Size(100, 20);
            this.textBoxValoare.TabIndex = 5;
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(120, 67);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenumire.TabIndex = 4;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(120, 31);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(100, 20);
            this.textBoxCod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valoare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // numericUpDownContracte
            // 
            this.numericUpDownContracte.Location = new System.Drawing.Point(112, 238);
            this.numericUpDownContracte.Name = "numericUpDownContracte";
            this.numericUpDownContracte.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownContracte.TabIndex = 1;
            this.numericUpDownContracte.ValueChanged += new System.EventHandler(this.numericUpDownContracte_ValueChanged);
            this.numericUpDownContracte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDownContracte_KeyDown);
            this.numericUpDownContracte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownContracte_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contract nr.";
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(0, 0);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvare.TabIndex = 7;
            // 
            // textBoxSuma
            // 
            this.textBoxSuma.Location = new System.Drawing.Point(164, 247);
            this.textBoxSuma.Name = "textBoxSuma";
            this.textBoxSuma.ReadOnly = true;
            this.textBoxSuma.Size = new System.Drawing.Size(100, 20);
            this.textBoxSuma.TabIndex = 4;
            this.textBoxSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Suma contracte";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(312, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonSave
            // 
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(23, 22);
            this.buttonSave.Text = "Salvare binar";
            this.buttonSave.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trasareGraficToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // trasareGraficToolStripMenuItem
            // 
            this.trasareGraficToolStripMenuItem.Name = "trasareGraficToolStripMenuItem";
            this.trasareGraficToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.trasareGraficToolStripMenuItem.Text = "Trasare Grafic";
            this.trasareGraficToolStripMenuItem.Click += new System.EventHandler(this.trasareGraficToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 290);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSuma);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownContracte);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContracte)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdaugare;
        private System.Windows.Forms.TextBox textBoxValoare;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownContracte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.TextBox textBoxSuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trasareGraficToolStripMenuItem;
    }
}

