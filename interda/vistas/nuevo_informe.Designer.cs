namespace interda.vistas
{
    partial class nuevo_informe
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_tipo_examen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2_fecha = new System.Windows.Forms.ComboBox();
            this.textBox1_CI = new System.Windows.Forms.TextBox();
            this.textBox2_digito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_Apellido = new System.Windows.Forms.TextBox();
            this.textBox1_edad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1_codigo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2_procedencia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3_prevision = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1_valor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1_atras = new System.Windows.Forms.Button();
            this.comboBox1_ecografista = new System.Windows.Forms.ComboBox();
            this.comboBox1_ecografo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.hospitales = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de exámen:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1_tipo_examen
            // 
            this.comboBox1_tipo_examen.FormattingEnabled = true;
            this.comboBox1_tipo_examen.Location = new System.Drawing.Point(306, 152);
            this.comboBox1_tipo_examen.Name = "comboBox1_tipo_examen";
            this.comboBox1_tipo_examen.Size = new System.Drawing.Size(303, 24);
            this.comboBox1_tipo_examen.TabIndex = 1;
            this.comboBox1_tipo_examen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // comboBox2_fecha
            // 
            this.comboBox2_fecha.FormattingEnabled = true;
            this.comboBox2_fecha.Location = new System.Drawing.Point(672, 152);
            this.comboBox2_fecha.Name = "comboBox2_fecha";
            this.comboBox2_fecha.Size = new System.Drawing.Size(303, 24);
            this.comboBox2_fecha.TabIndex = 3;
            // 
            // textBox1_CI
            // 
            this.textBox1_CI.Location = new System.Drawing.Point(160, 204);
            this.textBox1_CI.Name = "textBox1_CI";
            this.textBox1_CI.Size = new System.Drawing.Size(100, 22);
            this.textBox1_CI.TabIndex = 4;
            // 
            // textBox2_digito
            // 
            this.textBox2_digito.Location = new System.Drawing.Point(266, 204);
            this.textBox2_digito.Name = "textBox2_digito";
            this.textBox2_digito.Size = new System.Drawing.Size(42, 22);
            this.textBox2_digito.TabIndex = 5;
            this.textBox2_digito.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "CI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dígito";
            // 
            // textBox3_nombre
            // 
            this.textBox3_nombre.Location = new System.Drawing.Point(331, 204);
            this.textBox3_nombre.Name = "textBox3_nombre";
            this.textBox3_nombre.Size = new System.Drawing.Size(232, 22);
            this.textBox3_nombre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Apellido";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1_Apellido
            // 
            this.textBox1_Apellido.Location = new System.Drawing.Point(569, 204);
            this.textBox1_Apellido.Name = "textBox1_Apellido";
            this.textBox1_Apellido.Size = new System.Drawing.Size(232, 22);
            this.textBox1_Apellido.TabIndex = 11;
            // 
            // textBox1_edad
            // 
            this.textBox1_edad.Location = new System.Drawing.Point(807, 204);
            this.textBox1_edad.Name = "textBox1_edad";
            this.textBox1_edad.Size = new System.Drawing.Size(60, 22);
            this.textBox1_edad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edad";
            // 
            // comboBox1_codigo
            // 
            this.comboBox1_codigo.FormattingEnabled = true;
            this.comboBox1_codigo.Location = new System.Drawing.Point(156, 259);
            this.comboBox1_codigo.Name = "comboBox1_codigo";
            this.comboBox1_codigo.Size = new System.Drawing.Size(160, 24);
            this.comboBox1_codigo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Código";
            // 
            // comboBox2_procedencia
            // 
            this.comboBox2_procedencia.FormattingEnabled = true;
            this.comboBox2_procedencia.Location = new System.Drawing.Point(322, 259);
            this.comboBox2_procedencia.Name = "comboBox2_procedencia";
            this.comboBox2_procedencia.Size = new System.Drawing.Size(160, 24);
            this.comboBox2_procedencia.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Procedencia";
            // 
            // comboBox3_prevision
            // 
            this.comboBox3_prevision.FormattingEnabled = true;
            this.comboBox3_prevision.Location = new System.Drawing.Point(488, 259);
            this.comboBox3_prevision.Name = "comboBox3_prevision";
            this.comboBox3_prevision.Size = new System.Drawing.Size(160, 24);
            this.comboBox3_prevision.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Previsión";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox1_valor
            // 
            this.textBox1_valor.Location = new System.Drawing.Point(654, 259);
            this.textBox1_valor.Name = "textBox1_valor";
            this.textBox1_valor.Size = new System.Drawing.Size(160, 22);
            this.textBox1_valor.TabIndex = 20;
            this.textBox1_valor.TextChanged += new System.EventHandler(this.textBox1_valor_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Valor $";
            // 
            // button1_atras
            // 
            this.button1_atras.Location = new System.Drawing.Point(1092, 21);
            this.button1_atras.Name = "button1_atras";
            this.button1_atras.Size = new System.Drawing.Size(113, 45);
            this.button1_atras.TabIndex = 22;
            this.button1_atras.Text = "Atrás";
            this.button1_atras.UseVisualStyleBackColor = true;
            this.button1_atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1_ecografista
            // 
            this.comboBox1_ecografista.FormattingEnabled = true;
            this.comboBox1_ecografista.Location = new System.Drawing.Point(156, 316);
            this.comboBox1_ecografista.Name = "comboBox1_ecografista";
            this.comboBox1_ecografista.Size = new System.Drawing.Size(160, 24);
            this.comboBox1_ecografista.TabIndex = 23;
            // 
            // comboBox1_ecografo
            // 
            this.comboBox1_ecografo.FormattingEnabled = true;
            this.comboBox1_ecografo.Location = new System.Drawing.Point(322, 316);
            this.comboBox1_ecografo.Name = "comboBox1_ecografo";
            this.comboBox1_ecografo.Size = new System.Drawing.Size(160, 24);
            this.comboBox1_ecografo.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ecografista";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ecógrafo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.hospitales);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1_atras);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 93);
            this.panel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "->";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 52);
            this.button4.TabIndex = 28;
            this.button4.Text = "Ecotomografía ginecológica";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 52);
            this.button5.TabIndex = 31;
            this.button5.Text = "Ecotomografía obstétrica (único)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(652, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 68);
            this.button7.TabIndex = 32;
            this.button7.Text = "Ecotomografía Obstétrico gemelar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // hospitales
            // 
            this.hospitales.FormattingEnabled = true;
            this.hospitales.Location = new System.Drawing.Point(803, 32);
            this.hospitales.Name = "hospitales";
            this.hospitales.Size = new System.Drawing.Size(121, 24);
            this.hospitales.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(930, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "IV";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(930, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "La Serena";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 379);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(661, 25);
            this.label16.TabIndex = 29;
            this.label16.Text = "FUR: Calculador de FUR según Eco y FUR aportada por la paciente";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(81, 434);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(350, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "FUR segura aportada por la embarazada";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(510, 459);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "FURpaciente:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // nuevo_informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1277, 408);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1_ecografo);
            this.Controls.Add(this.comboBox1_ecografista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1_valor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox3_prevision);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2_procedencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1_codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1_edad);
            this.Controls.Add(this.textBox1_Apellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_digito);
            this.Controls.Add(this.textBox1_CI);
            this.Controls.Add(this.comboBox2_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1_tipo_examen);
            this.Controls.Add(this.label1);
            this.Name = "nuevo_informe";
            this.Text = "nuevo_informe";
            this.Load += new System.EventHandler(this.nuevo_informe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_tipo_examen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2_fecha;
        private System.Windows.Forms.TextBox textBox1_CI;
        private System.Windows.Forms.TextBox textBox2_digito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_Apellido;
        private System.Windows.Forms.TextBox textBox1_edad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2_procedencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3_prevision;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1_valor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1_atras;
        private System.Windows.Forms.ComboBox comboBox1_ecografista;
        private System.Windows.Forms.ComboBox comboBox1_ecografo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox hospitales;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
    }
}