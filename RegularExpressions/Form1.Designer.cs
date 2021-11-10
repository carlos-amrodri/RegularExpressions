namespace RegularExpressions
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTE = new System.Windows.Forms.Button();
            this.btnRemito = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textPatternSubcadena = new System.Windows.Forms.TextBox();
            this.textSubcadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxSubcadena = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubcadenas = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(13, 13);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(824, 590);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnRemito);
            this.tabPage1.Controls.Add(this.btnTE);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Match";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSubcadenas);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBoxSubcadena);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textSubcadena);
            this.tabPage2.Controls.Add(this.textPatternSubcadena);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subcadenas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadena para analizar";
            // 
            // btnTE
            // 
            this.btnTE.Location = new System.Drawing.Point(12, 115);
            this.btnTE.Name = "btnTE";
            this.btnTE.Size = new System.Drawing.Size(92, 63);
            this.btnTE.TabIndex = 2;
            this.btnTE.Text = "Número telefónico";
            this.btnTE.UseVisualStyleBackColor = true;
            this.btnTE.Click += new System.EventHandler(this.btnTE_Click);
            // 
            // btnRemito
            // 
            this.btnRemito.Location = new System.Drawing.Point(138, 115);
            this.btnRemito.Name = "btnRemito";
            this.btnRemito.Size = new System.Drawing.Size(83, 64);
            this.btnRemito.TabIndex = 3;
            this.btnRemito.Text = "Remito";
            this.btnRemito.UseVisualStyleBackColor = true;
            this.btnRemito.Click += new System.EventHandler(this.btnRemito_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textPatternSubcadena
            // 
            this.textPatternSubcadena.Location = new System.Drawing.Point(6, 60);
            this.textPatternSubcadena.Name = "textPatternSubcadena";
            this.textPatternSubcadena.Size = new System.Drawing.Size(260, 20);
            this.textPatternSubcadena.TabIndex = 0;
            // 
            // textSubcadena
            // 
            this.textSubcadena.Location = new System.Drawing.Point(6, 133);
            this.textSubcadena.Multiline = true;
            this.textSubcadena.Name = "textSubcadena";
            this.textSubcadena.Size = new System.Drawing.Size(260, 268);
            this.textSubcadena.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patron";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Texto a analizar";
            // 
            // listBoxSubcadena
            // 
            this.listBoxSubcadena.FormattingEnabled = true;
            this.listBoxSubcadena.Location = new System.Drawing.Point(355, 133);
            this.listBoxSubcadena.Name = "listBoxSubcadena";
            this.listBoxSubcadena.Size = new System.Drawing.Size(230, 277);
            this.listBoxSubcadena.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado";
            // 
            // btnSubcadenas
            // 
            this.btnSubcadenas.Location = new System.Drawing.Point(355, 57);
            this.btnSubcadenas.Name = "btnSubcadenas";
            this.btnSubcadenas.Size = new System.Drawing.Size(75, 23);
            this.btnSubcadenas.TabIndex = 6;
            this.btnSubcadenas.Text = "Analizar";
            this.btnSubcadenas.UseVisualStyleBackColor = true;
            this.btnSubcadenas.Click += new System.EventHandler(this.btnSubcadenas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 626);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "Expresiones Regulares";
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRemito;
        private System.Windows.Forms.Button btnTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSubcadenas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSubcadena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSubcadena;
        private System.Windows.Forms.TextBox textPatternSubcadena;
    }
}

