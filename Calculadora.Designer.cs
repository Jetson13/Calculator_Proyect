namespace Calculadora_Proyecto_Final
{
    partial class Calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button_N7 = new System.Windows.Forms.Button();
            this.button_N4 = new System.Windows.Forms.Button();
            this.button_N1 = new System.Windows.Forms.Button();
            this.button_Signo = new System.Windows.Forms.Button();
            this.button_N8 = new System.Windows.Forms.Button();
            this.button_N5 = new System.Windows.Forms.Button();
            this.button_N2 = new System.Windows.Forms.Button();
            this.button_N0 = new System.Windows.Forms.Button();
            this.button_N9 = new System.Windows.Forms.Button();
            this.button_N6 = new System.Windows.Forms.Button();
            this.button_N3 = new System.Windows.Forms.Button();
            this.button_Punto = new System.Windows.Forms.Button();
            this.button_Multiplicar = new System.Windows.Forms.Button();
            this.button_Restar = new System.Windows.Forms.Button();
            this.button_Sumar = new System.Windows.Forms.Button();
            this.button_Igual = new System.Windows.Forms.Button();
            this.button_1_X = new System.Windows.Forms.Button();
            this.button_Alcuadrado = new System.Windows.Forms.Button();
            this.button_RaízCuadrada = new System.Windows.Forms.Button();
            this.button_Dividir = new System.Windows.Forms.Button();
            this.button_Porciento = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button_Reiniciar = new System.Windows.Forms.Button();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.Operaciones = new System.Windows.Forms.TextBox();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_Minimizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NombreDeLaCalculadora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Verdana", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(3, 64);
            this.txtResultado.MaxLength = 8;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResultado.Size = new System.Drawing.Size(294, 56);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // button_N7
            // 
            this.button_N7.BackColor = System.Drawing.SystemColors.Control;
            this.button_N7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N7.Location = new System.Drawing.Point(3, 239);
            this.button_N7.Name = "button_N7";
            this.button_N7.Size = new System.Drawing.Size(75, 52);
            this.button_N7.TabIndex = 1;
            this.button_N7.Text = "7";
            this.button_N7.UseVisualStyleBackColor = false;
            this.button_N7.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N4
            // 
            this.button_N4.BackColor = System.Drawing.SystemColors.Control;
            this.button_N4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N4.Location = new System.Drawing.Point(3, 287);
            this.button_N4.Name = "button_N4";
            this.button_N4.Size = new System.Drawing.Size(75, 52);
            this.button_N4.TabIndex = 2;
            this.button_N4.Text = "4";
            this.button_N4.UseVisualStyleBackColor = false;
            this.button_N4.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N1
            // 
            this.button_N1.BackColor = System.Drawing.SystemColors.Control;
            this.button_N1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N1.Location = new System.Drawing.Point(3, 335);
            this.button_N1.Name = "button_N1";
            this.button_N1.Size = new System.Drawing.Size(75, 52);
            this.button_N1.TabIndex = 3;
            this.button_N1.Text = "1";
            this.button_N1.UseVisualStyleBackColor = false;
            this.button_N1.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_Signo
            // 
            this.button_Signo.BackColor = System.Drawing.SystemColors.Control;
            this.button_Signo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Signo.Location = new System.Drawing.Point(3, 383);
            this.button_Signo.Name = "button_Signo";
            this.button_Signo.Size = new System.Drawing.Size(75, 52);
            this.button_Signo.TabIndex = 4;
            this.button_Signo.Text = "+/-";
            this.button_Signo.UseVisualStyleBackColor = false;
            this.button_Signo.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_N8
            // 
            this.button_N8.BackColor = System.Drawing.SystemColors.Control;
            this.button_N8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N8.Location = new System.Drawing.Point(76, 239);
            this.button_N8.Name = "button_N8";
            this.button_N8.Size = new System.Drawing.Size(75, 52);
            this.button_N8.TabIndex = 5;
            this.button_N8.Text = "8";
            this.button_N8.UseVisualStyleBackColor = false;
            this.button_N8.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N5
            // 
            this.button_N5.BackColor = System.Drawing.SystemColors.Control;
            this.button_N5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N5.Location = new System.Drawing.Point(76, 287);
            this.button_N5.Name = "button_N5";
            this.button_N5.Size = new System.Drawing.Size(75, 52);
            this.button_N5.TabIndex = 6;
            this.button_N5.Text = "5";
            this.button_N5.UseVisualStyleBackColor = false;
            this.button_N5.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N2
            // 
            this.button_N2.BackColor = System.Drawing.SystemColors.Control;
            this.button_N2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N2.Location = new System.Drawing.Point(76, 335);
            this.button_N2.Name = "button_N2";
            this.button_N2.Size = new System.Drawing.Size(75, 52);
            this.button_N2.TabIndex = 7;
            this.button_N2.Text = "2";
            this.button_N2.UseVisualStyleBackColor = false;
            this.button_N2.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N0
            // 
            this.button_N0.BackColor = System.Drawing.SystemColors.Control;
            this.button_N0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N0.Location = new System.Drawing.Point(76, 383);
            this.button_N0.Name = "button_N0";
            this.button_N0.Size = new System.Drawing.Size(75, 52);
            this.button_N0.TabIndex = 8;
            this.button_N0.Text = "0";
            this.button_N0.UseVisualStyleBackColor = false;
            this.button_N0.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N9
            // 
            this.button_N9.BackColor = System.Drawing.SystemColors.Control;
            this.button_N9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N9.Location = new System.Drawing.Point(149, 239);
            this.button_N9.Name = "button_N9";
            this.button_N9.Size = new System.Drawing.Size(75, 52);
            this.button_N9.TabIndex = 9;
            this.button_N9.Text = "9";
            this.button_N9.UseVisualStyleBackColor = false;
            this.button_N9.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N6
            // 
            this.button_N6.BackColor = System.Drawing.SystemColors.Control;
            this.button_N6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N6.Location = new System.Drawing.Point(149, 287);
            this.button_N6.Name = "button_N6";
            this.button_N6.Size = new System.Drawing.Size(75, 52);
            this.button_N6.TabIndex = 10;
            this.button_N6.Text = "6";
            this.button_N6.UseVisualStyleBackColor = false;
            this.button_N6.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_N3
            // 
            this.button_N3.BackColor = System.Drawing.SystemColors.Control;
            this.button_N3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_N3.Location = new System.Drawing.Point(149, 335);
            this.button_N3.Name = "button_N3";
            this.button_N3.Size = new System.Drawing.Size(75, 52);
            this.button_N3.TabIndex = 11;
            this.button_N3.Text = "3";
            this.button_N3.UseVisualStyleBackColor = false;
            this.button_N3.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button_Punto
            // 
            this.button_Punto.BackColor = System.Drawing.SystemColors.Control;
            this.button_Punto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Punto.Location = new System.Drawing.Point(149, 383);
            this.button_Punto.Name = "button_Punto";
            this.button_Punto.Size = new System.Drawing.Size(75, 52);
            this.button_Punto.TabIndex = 12;
            this.button_Punto.Text = ".";
            this.button_Punto.UseVisualStyleBackColor = false;
            this.button_Punto.Click += new System.EventHandler(this.button_Punto_Click);
            // 
            // button_Multiplicar
            // 
            this.button_Multiplicar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Multiplicar.Location = new System.Drawing.Point(222, 239);
            this.button_Multiplicar.Name = "button_Multiplicar";
            this.button_Multiplicar.Size = new System.Drawing.Size(75, 52);
            this.button_Multiplicar.TabIndex = 13;
            this.button_Multiplicar.Tag = "×";
            this.button_Multiplicar.Text = "×";
            this.button_Multiplicar.UseVisualStyleBackColor = true;
            this.button_Multiplicar.Click += new System.EventHandler(this.Operador_Click);
            // 
            // button_Restar
            // 
            this.button_Restar.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Restar.Location = new System.Drawing.Point(222, 287);
            this.button_Restar.Name = "button_Restar";
            this.button_Restar.Size = new System.Drawing.Size(75, 52);
            this.button_Restar.TabIndex = 14;
            this.button_Restar.Tag = "-";
            this.button_Restar.Text = "-";
            this.button_Restar.UseVisualStyleBackColor = true;
            this.button_Restar.Click += new System.EventHandler(this.Operador_Click);
            // 
            // button_Sumar
            // 
            this.button_Sumar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Sumar.Location = new System.Drawing.Point(222, 335);
            this.button_Sumar.Name = "button_Sumar";
            this.button_Sumar.Size = new System.Drawing.Size(75, 52);
            this.button_Sumar.TabIndex = 15;
            this.button_Sumar.Tag = "+";
            this.button_Sumar.Text = "+";
            this.button_Sumar.UseVisualStyleBackColor = true;
            this.button_Sumar.Click += new System.EventHandler(this.Operador_Click);
            // 
            // button_Igual
            // 
            this.button_Igual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Igual.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Igual.Location = new System.Drawing.Point(222, 383);
            this.button_Igual.Name = "button_Igual";
            this.button_Igual.Size = new System.Drawing.Size(75, 52);
            this.button_Igual.TabIndex = 16;
            this.button_Igual.Text = "=";
            this.button_Igual.UseVisualStyleBackColor = false;
            this.button_Igual.Click += new System.EventHandler(this.button_Igual_Click);
            // 
            // button_1_X
            // 
            this.button_1_X.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1_X.Location = new System.Drawing.Point(3, 191);
            this.button_1_X.Name = "button_1_X";
            this.button_1_X.Size = new System.Drawing.Size(75, 52);
            this.button_1_X.TabIndex = 17;
            this.button_1_X.Text = "¹/x";
            this.button_1_X.UseVisualStyleBackColor = true;
            // 
            // button_Alcuadrado
            // 
            this.button_Alcuadrado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Alcuadrado.Location = new System.Drawing.Point(76, 191);
            this.button_Alcuadrado.Name = "button_Alcuadrado";
            this.button_Alcuadrado.Size = new System.Drawing.Size(75, 52);
            this.button_Alcuadrado.TabIndex = 18;
            this.button_Alcuadrado.Tag = "²";
            this.button_Alcuadrado.Text = "x²";
            this.button_Alcuadrado.UseVisualStyleBackColor = true;
            this.button_Alcuadrado.Click += new System.EventHandler(this.Operador_Click);
            // 
            // button_RaízCuadrada
            // 
            this.button_RaízCuadrada.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_RaízCuadrada.Location = new System.Drawing.Point(149, 191);
            this.button_RaízCuadrada.Name = "button_RaízCuadrada";
            this.button_RaízCuadrada.Size = new System.Drawing.Size(75, 52);
            this.button_RaízCuadrada.TabIndex = 19;
            this.button_RaízCuadrada.Tag = "√";
            this.button_RaízCuadrada.Text = "²√ᵪ";
            this.button_RaízCuadrada.UseVisualStyleBackColor = true;
            this.button_RaízCuadrada.Click += new System.EventHandler(this.Operador_Click);
            // 
            // button_Dividir
            // 
            this.button_Dividir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Dividir.Location = new System.Drawing.Point(222, 191);
            this.button_Dividir.Name = "button_Dividir";
            this.button_Dividir.Size = new System.Drawing.Size(75, 52);
            this.button_Dividir.TabIndex = 20;
            this.button_Dividir.Tag = "÷";
            this.button_Dividir.Text = "÷";
            this.button_Dividir.UseVisualStyleBackColor = true;
            this.button_Dividir.Click += new System.EventHandler(this.Operador_Click);
            // 
            // button_Porciento
            // 
            this.button_Porciento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Porciento.Location = new System.Drawing.Point(3, 143);
            this.button_Porciento.Name = "button_Porciento";
            this.button_Porciento.Size = new System.Drawing.Size(75, 52);
            this.button_Porciento.TabIndex = 21;
            this.button_Porciento.Tag = "%";
            this.button_Porciento.Text = "%";
            this.button_Porciento.UseVisualStyleBackColor = true;
            this.button_Porciento.Click += new System.EventHandler(this.Operador_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.Location = new System.Drawing.Point(76, 143);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 52);
            this.button22.TabIndex = 22;
            this.button22.Text = "CE";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button_Reiniciar
            // 
            this.button_Reiniciar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Reiniciar.Location = new System.Drawing.Point(149, 143);
            this.button_Reiniciar.Name = "button_Reiniciar";
            this.button_Reiniciar.Size = new System.Drawing.Size(75, 52);
            this.button_Reiniciar.TabIndex = 23;
            this.button_Reiniciar.Text = "C";
            this.button_Reiniciar.UseVisualStyleBackColor = true;
            this.button_Reiniciar.Click += new System.EventHandler(this.button_Reiniciar_Click);
            // 
            // button_Borrar
            // 
            this.button_Borrar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Borrar.Location = new System.Drawing.Point(222, 143);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(75, 52);
            this.button_Borrar.TabIndex = 24;
            this.button_Borrar.Text = "«";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.Click += new System.EventHandler(this.button_Borrar_Click);
            // 
            // Operaciones
            // 
            this.Operaciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Operaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Operaciones.Location = new System.Drawing.Point(197, 35);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.ReadOnly = true;
            this.Operaciones.Size = new System.Drawing.Size(100, 16);
            this.Operaciones.TabIndex = 28;
            this.Operaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Salir.FlatAppearance.BorderSize = 0;
            this.button_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Salir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Salir.Location = new System.Drawing.Point(259, 1);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(38, 23);
            this.button_Salir.TabIndex = 29;
            this.button_Salir.Text = "×";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // button_Minimizar
            // 
            this.button_Minimizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Minimizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Minimizar.FlatAppearance.BorderSize = 0;
            this.button_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Minimizar.Location = new System.Drawing.Point(221, 1);
            this.button_Minimizar.Name = "button_Minimizar";
            this.button_Minimizar.Size = new System.Drawing.Size(38, 23);
            this.button_Minimizar.TabIndex = 30;
            this.button_Minimizar.Text = "_";
            this.button_Minimizar.UseVisualStyleBackColor = false;
            this.button_Minimizar.Click += new System.EventHandler(this.button_Minimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 26);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NombreDeLaCalculadora
            // 
            this.NombreDeLaCalculadora.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NombreDeLaCalculadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreDeLaCalculadora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreDeLaCalculadora.Location = new System.Drawing.Point(3, 1);
            this.NombreDeLaCalculadora.Name = "NombreDeLaCalculadora";
            this.NombreDeLaCalculadora.ReadOnly = true;
            this.NombreDeLaCalculadora.Size = new System.Drawing.Size(152, 16);
            this.NombreDeLaCalculadora.TabIndex = 32;
            this.NombreDeLaCalculadora.Text = "Calculadora JJMSoft";
            this.NombreDeLaCalculadora.TextChanged += new System.EventHandler(this.NombreDeLaCalculadora_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(300, 439);
            this.Controls.Add(this.NombreDeLaCalculadora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Minimizar);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.Operaciones);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.button_Reiniciar);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button_Porciento);
            this.Controls.Add(this.button_Dividir);
            this.Controls.Add(this.button_RaízCuadrada);
            this.Controls.Add(this.button_Alcuadrado);
            this.Controls.Add(this.button_1_X);
            this.Controls.Add(this.button_Igual);
            this.Controls.Add(this.button_Sumar);
            this.Controls.Add(this.button_Restar);
            this.Controls.Add(this.button_Multiplicar);
            this.Controls.Add(this.button_Punto);
            this.Controls.Add(this.button_N3);
            this.Controls.Add(this.button_N6);
            this.Controls.Add(this.button_N9);
            this.Controls.Add(this.button_N0);
            this.Controls.Add(this.button_N2);
            this.Controls.Add(this.button_N5);
            this.Controls.Add(this.button_N8);
            this.Controls.Add(this.button_Signo);
            this.Controls.Add(this.button_N1);
            this.Controls.Add(this.button_N4);
            this.Controls.Add(this.button_N7);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora by JJMSoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResultado;
        private Button button_N7;
        private Button button_N4;
        private Button button_N1;
        private Button button_Signo;
        private Button button_N8;
        private Button button_N5;
        private Button button_N2;
        private Button button_N0;
        private Button button_N9;
        private Button button_N6;
        private Button button_N3;
        private Button button_Punto;
        private Button button_Multiplicar;
        private Button button_Restar;
        private Button button_Sumar;
        private Button button_Igual;
        private Button button_1_X;
        private Button button_Alcuadrado;
        private Button button_RaízCuadrada;
        private Button button_Dividir;
        private Button button_Porciento;
        private Button button22;
        private Button button_Reiniciar;
        private Button button_Borrar;
        private TextBox Operaciones;
        private Button button_Salir;
        private Button button_Minimizar;
        private PictureBox pictureBox1;
        private TextBox NombreDeLaCalculadora;
    }
}