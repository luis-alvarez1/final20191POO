namespace ActFinalPro
{
    partial class Details_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details_Client));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_pago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cont = new System.Windows.Forms.Label();
            this.pct_comprar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numTarjeta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_comprar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 85);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tienda online";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rellene los siguientes datos para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "continuar  con la compra:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(124, 268);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre:";
            // 
            // cmb_pago
            // 
            this.cmb_pago.FormattingEnabled = true;
            this.cmb_pago.Items.AddRange(new object[] {
            "Tarjeta Débito",
            "Tarjeta Crédito"});
            this.cmb_pago.Location = new System.Drawing.Point(223, 357);
            this.cmb_pago.Name = "cmb_pago";
            this.cmb_pago.Size = new System.Drawing.Size(121, 21);
            this.cmb_pago.TabIndex = 9;
            this.cmb_pago.Text = "Seleccione...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección:";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(142, 409);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(100, 20);
            this.txt_adress.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 81;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cont
            // 
            this.lbl_cont.AutoSize = true;
            this.lbl_cont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cont.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont.Location = new System.Drawing.Point(277, 602);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(136, 31);
            this.lbl_cont.TabIndex = 83;
            this.lbl_cont.Text = "Continuar";
            // 
            // pct_comprar
            // 
            this.pct_comprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_comprar.Image = ((System.Drawing.Image)(resources.GetObject("pct_comprar.Image")));
            this.pct_comprar.Location = new System.Drawing.Point(323, 553);
            this.pct_comprar.Name = "pct_comprar";
            this.pct_comprar.Size = new System.Drawing.Size(62, 46);
            this.pct_comprar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_comprar.TabIndex = 82;
            this.pct_comprar.TabStop = false;
            this.pct_comprar.Click += new System.EventHandler(this.pct_comprar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 31);
            this.label7.TabIndex = 85;
            this.label7.Text = "Correo Electrónico:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(248, 462);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Método de pago:";
            // 
            // txt_numTarjeta
            // 
            this.txt_numTarjeta.Location = new System.Drawing.Point(253, 315);
            this.txt_numTarjeta.Name = "txt_numTarjeta";
            this.txt_numTarjeta.Size = new System.Drawing.Size(160, 20);
            this.txt_numTarjeta.TabIndex = 86;
            this.txt_numTarjeta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_numTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_numTargeta_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 31);
            this.label8.TabIndex = 87;
            this.label8.Text = "Número de tarjeta:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-5, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 31);
            this.label9.TabIndex = 89;
            this.label9.Text = "Celular";
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(101, 508);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(100, 20);
            this.txt_celular.TabIndex = 88;
            // 
            // Details_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(458, 648);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_numTarjeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_cont);
            this.Controls.Add(this.pct_comprar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_pago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Details_Client";
            this.Text = "Details_Client";
            this.Load += new System.EventHandler(this.Details_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_comprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_pago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_cont;
        private System.Windows.Forms.PictureBox pct_comprar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_numTarjeta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_celular;
    }
}