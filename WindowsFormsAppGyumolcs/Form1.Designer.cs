namespace WindowsFormsAppGyumolcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelEgysegar = new System.Windows.Forms.Label();
            this.labelMennyiseg = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.numericUpDownEgysegar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.buttonUjGyumolcs = new System.Windows.Forms.Button();
            this.buttonModosítas = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 450);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(202, 58);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(15, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "id";
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(192, 83);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(25, 13);
            this.labelNev.TabIndex = 2;
            this.labelNev.Text = "nev";
            // 
            // labelEgysegar
            // 
            this.labelEgysegar.AutoSize = true;
            this.labelEgysegar.Location = new System.Drawing.Point(168, 109);
            this.labelEgysegar.Name = "labelEgysegar";
            this.labelEgysegar.Size = new System.Drawing.Size(50, 13);
            this.labelEgysegar.TabIndex = 3;
            this.labelEgysegar.Text = "egységár";
            // 
            // labelMennyiseg
            // 
            this.labelMennyiseg.AutoSize = true;
            this.labelMennyiseg.Location = new System.Drawing.Point(160, 136);
            this.labelMennyiseg.Name = "labelMennyiseg";
            this.labelMennyiseg.Size = new System.Drawing.Size(57, 13);
            this.labelMennyiseg.TabIndex = 4;
            this.labelMennyiseg.Text = "mennyiseg";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(223, 51);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(223, 80);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 6;
            // 
            // numericUpDownEgysegar
            // 
            this.numericUpDownEgysegar.Location = new System.Drawing.Point(224, 107);
            this.numericUpDownEgysegar.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownEgysegar.Name = "numericUpDownEgysegar";
            this.numericUpDownEgysegar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEgysegar.TabIndex = 7;
            // 
            // numericUpDownMennyiseg
            // 
            this.numericUpDownMennyiseg.Location = new System.Drawing.Point(223, 134);
            this.numericUpDownMennyiseg.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownMennyiseg.Name = "numericUpDownMennyiseg";
            this.numericUpDownMennyiseg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMennyiseg.TabIndex = 8;
            // 
            // buttonUjGyumolcs
            // 
            this.buttonUjGyumolcs.Location = new System.Drawing.Point(163, 173);
            this.buttonUjGyumolcs.Name = "buttonUjGyumolcs";
            this.buttonUjGyumolcs.Size = new System.Drawing.Size(181, 35);
            this.buttonUjGyumolcs.TabIndex = 9;
            this.buttonUjGyumolcs.Text = "Új gyümölcs";
            this.buttonUjGyumolcs.UseVisualStyleBackColor = true;
            this.buttonUjGyumolcs.Click += new System.EventHandler(this.buttonUjGyumolcs_Click);
            // 
            // buttonModosítas
            // 
            this.buttonModosítas.Location = new System.Drawing.Point(162, 214);
            this.buttonModosítas.Name = "buttonModosítas";
            this.buttonModosítas.Size = new System.Drawing.Size(181, 35);
            this.buttonModosítas.TabIndex = 10;
            this.buttonModosítas.Text = "Módosítás";
            this.buttonModosítas.UseVisualStyleBackColor = true;
            this.buttonModosítas.Click += new System.EventHandler(this.buttonModosítas_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(162, 255);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(181, 35);
            this.buttonTorles.TabIndex = 11;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonModosítas);
            this.Controls.Add(this.buttonUjGyumolcs);
            this.Controls.Add(this.numericUpDownMennyiseg);
            this.Controls.Add(this.numericUpDownEgysegar);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelMennyiseg);
            this.Controls.Add(this.labelEgysegar);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gyümölcsök";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelEgysegar;
        private System.Windows.Forms.Label labelMennyiseg;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.NumericUpDown numericUpDownEgysegar;
        private System.Windows.Forms.NumericUpDown numericUpDownMennyiseg;
        private System.Windows.Forms.Button buttonUjGyumolcs;
        private System.Windows.Forms.Button buttonModosítas;
        private System.Windows.Forms.Button buttonTorles;
    }
}

