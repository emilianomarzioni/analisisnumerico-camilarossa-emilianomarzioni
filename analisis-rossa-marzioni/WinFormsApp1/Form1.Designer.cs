
namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Funcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xi = new System.Windows.Forms.TextBox();
            this.xd = new System.Windows.Forms.TextBox();
            this.ite = new System.Windows.Forms.TextBox();
            this.tole = new System.Windows.Forms.TextBox();
            this.metodosSelect = new System.Windows.Forms.ComboBox();
            this.errorRelativo = new System.Windows.Forms.Label();
            this.Xresult = new System.Windows.Forms.Label();
            this.Iteraciones = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.convergelabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExeSeidel = new System.Windows.Forms.Button();
            this.ExeGauss = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matrizgenerator = new System.Windows.Forms.Button();
            this.matrizvalues = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(x) = ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Funcion
            // 
            this.Funcion.Location = new System.Drawing.Point(139, 87);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(100, 23);
            this.Funcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Iteraciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tolerancia";
            // 
            // xi
            // 
            this.xi.BackColor = System.Drawing.SystemColors.Window;
            this.xi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xi.Location = new System.Drawing.Point(139, 128);
            this.xi.Name = "xi";
            this.xi.Size = new System.Drawing.Size(100, 23);
            this.xi.TabIndex = 6;
            // 
            // xd
            // 
            this.xd.Location = new System.Drawing.Point(139, 163);
            this.xd.Name = "xd";
            this.xd.Size = new System.Drawing.Size(100, 23);
            this.xd.TabIndex = 7;
            // 
            // ite
            // 
            this.ite.Location = new System.Drawing.Point(139, 196);
            this.ite.Name = "ite";
            this.ite.Size = new System.Drawing.Size(100, 23);
            this.ite.TabIndex = 8;
            // 
            // tole
            // 
            this.tole.Location = new System.Drawing.Point(139, 232);
            this.tole.Name = "tole";
            this.tole.Size = new System.Drawing.Size(100, 23);
            this.tole.TabIndex = 9;
            // 
            // metodosSelect
            // 
            this.metodosSelect.FormattingEnabled = true;
            this.metodosSelect.Items.AddRange(new object[] {
            "Biseccion",
            "ReglaFalsa",
            "NewtonRaphson",
            "Secante"});
            this.metodosSelect.Location = new System.Drawing.Point(257, 28);
            this.metodosSelect.Name = "metodosSelect";
            this.metodosSelect.Size = new System.Drawing.Size(121, 23);
            this.metodosSelect.TabIndex = 10;
            this.metodosSelect.SelectedValueChanged += new System.EventHandler(this.metodosSelect_SelectedValueChanged);
            // 
            // errorRelativo
            // 
            this.errorRelativo.AutoSize = true;
            this.errorRelativo.Location = new System.Drawing.Point(427, 104);
            this.errorRelativo.Name = "errorRelativo";
            this.errorRelativo.Size = new System.Drawing.Size(12, 15);
            this.errorRelativo.TabIndex = 11;
            this.errorRelativo.Text = "-";
            // 
            // Xresult
            // 
            this.Xresult.AutoSize = true;
            this.Xresult.Location = new System.Drawing.Point(427, 137);
            this.Xresult.Name = "Xresult";
            this.Xresult.Size = new System.Drawing.Size(12, 15);
            this.Xresult.TabIndex = 12;
            this.Xresult.Text = "-";
            // 
            // Iteraciones
            // 
            this.Iteraciones.AutoSize = true;
            this.Iteraciones.Location = new System.Drawing.Point(427, 168);
            this.Iteraciones.Name = "Iteraciones";
            this.Iteraciones.Size = new System.Drawing.Size(12, 15);
            this.Iteraciones.TabIndex = 13;
            this.Iteraciones.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calcularF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Método:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // convergelabel
            // 
            this.convergelabel.AutoSize = true;
            this.convergelabel.Location = new System.Drawing.Point(427, 205);
            this.convergelabel.Name = "convergelabel";
            this.convergelabel.Size = new System.Drawing.Size(12, 15);
            this.convergelabel.TabIndex = 17;
            this.convergelabel.Text = "-";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 426);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Funcion);
            this.tabPage1.Controls.Add(this.convergelabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Iteraciones);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Xresult);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.errorRelativo);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.metodosSelect);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.xi);
            this.tabPage1.Controls.Add(this.xd);
            this.tabPage1.Controls.Add(this.tole);
            this.tabPage1.Controls.Add(this.ite);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unidad 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Iteraciones:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Converge o no:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "XR:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Error Relativo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ExeSeidel);
            this.tabPage2.Controls.Add(this.ExeGauss);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.matrizgenerator);
            this.tabPage2.Controls.Add(this.matrizvalues);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unidad 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExeSeidel
            // 
            this.ExeSeidel.Location = new System.Drawing.Point(426, 24);
            this.ExeSeidel.Name = "ExeSeidel";
            this.ExeSeidel.Size = new System.Drawing.Size(103, 23);
            this.ExeSeidel.TabIndex = 4;
            this.ExeSeidel.Text = "Gauss-Jordan";
            this.ExeSeidel.UseVisualStyleBackColor = true;
            this.ExeSeidel.Click += new System.EventHandler(this.ExeSeidel_Click);
            // 
            // ExeGauss
            // 
            this.ExeGauss.Location = new System.Drawing.Point(294, 24);
            this.ExeGauss.Name = "ExeGauss";
            this.ExeGauss.Size = new System.Drawing.Size(103, 23);
            this.ExeGauss.TabIndex = 3;
            this.ExeGauss.Text = "Gauss-Jordan";
            this.ExeGauss.UseVisualStyleBackColor = true;
            this.ExeGauss.Click += new System.EventHandler(this.ExeGauss_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 299);
            this.panel1.TabIndex = 2;
            // 
            // matrizgenerator
            // 
            this.matrizgenerator.Location = new System.Drawing.Point(164, 24);
            this.matrizgenerator.Name = "matrizgenerator";
            this.matrizgenerator.Size = new System.Drawing.Size(80, 23);
            this.matrizgenerator.TabIndex = 1;
            this.matrizgenerator.Text = "Generar Matriz";
            this.matrizgenerator.UseVisualStyleBackColor = true;
            this.matrizgenerator.Click += new System.EventHandler(this.matrizgenerator_Click);
            // 
            // matrizvalues
            // 
            this.matrizvalues.Location = new System.Drawing.Point(44, 24);
            this.matrizvalues.Name = "matrizvalues";
            this.matrizvalues.Size = new System.Drawing.Size(100, 23);
            this.matrizvalues.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Tolerancia";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Funcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xi;
        private System.Windows.Forms.TextBox xd;
        private System.Windows.Forms.TextBox ite;
        private System.Windows.Forms.TextBox tole;
        private System.Windows.Forms.ComboBox metodosSelect;
        private System.Windows.Forms.Label errorRelativo;
        private System.Windows.Forms.Label Xresult;
        private System.Windows.Forms.Label Iteraciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label convergelabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button matrizgenerator;
        private System.Windows.Forms.TextBox matrizvalues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExeSeidel;
        private System.Windows.Forms.Button ExeGauss;
    }
}

