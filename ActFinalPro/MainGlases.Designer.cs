namespace ActFinalPro
{
    partial class MainGlases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGlases));
            this.lbl_nombre_glasses = new System.Windows.Forms.Label();
            this.pct_glasses = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_diseno = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cmb_colorPol = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pct_comprar = new System.Windows.Forms.PictureBox();
            this.lbl_cont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_glasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_comprar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre_glasses
            // 
            this.lbl_nombre_glasses.AutoSize = true;
            this.lbl_nombre_glasses.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_glasses.Location = new System.Drawing.Point(198, 215);
            this.lbl_nombre_glasses.Name = "lbl_nombre_glasses";
            this.lbl_nombre_glasses.Size = new System.Drawing.Size(156, 31);
            this.lbl_nombre_glasses.TabIndex = 40;
            this.lbl_nombre_glasses.Text = "Gafas de sol";
            // 
            // pct_glasses
            // 
            this.pct_glasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_glasses.Image = ((System.Drawing.Image)(resources.GetObject("pct_glasses.Image")));
            this.pct_glasses.Location = new System.Drawing.Point(25, 206);
            this.pct_glasses.Name = "pct_glasses";
            this.pct_glasses.Size = new System.Drawing.Size(167, 93);
            this.pct_glasses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_glasses.TabIndex = 39;
            this.pct_glasses.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Producto seleccionado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 85);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tienda online";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_total.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(227, 256);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(91, 29);
            this.lbl_total.TabIndex = 41;
            this.lbl_total.Text = "$ 34.95";
            this.lbl_total.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 31);
            this.label5.TabIndex = 42;
            this.label5.Text = "Seleccione el color del polarizado:";
            // 
            // cmb_diseno
            // 
            this.cmb_diseno.AutoSize = true;
            this.cmb_diseno.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_diseno.Location = new System.Drawing.Point(19, 413);
            this.cmb_diseno.Name = "cmb_diseno";
            this.cmb_diseno.Size = new System.Drawing.Size(256, 31);
            this.cmb_diseno.TabIndex = 43;
            this.cmb_diseno.Text = "Seleccione el diseño:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 602);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 34);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_colorPol
            // 
            this.cmb_colorPol.FormattingEnabled = true;
            this.cmb_colorPol.Items.AddRange(new object[] {
            "Azul",
            "Negro",
            "Morado",
            "Marron"});
            this.cmb_colorPol.Location = new System.Drawing.Point(137, 361);
            this.cmb_colorPol.Name = "cmb_colorPol";
            this.cmb_colorPol.Size = new System.Drawing.Size(121, 21);
            this.cmb_colorPol.TabIndex = 61;
            this.cmb_colorPol.Text = "Seleccione...";
            this.cmb_colorPol.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Aviator",
            "Wayfarer",
            "Round",
            "Erika"});
            this.comboBox2.Location = new System.Drawing.Point(137, 477);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 62;
            this.comboBox2.Text = "Seleccione...";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // pct_comprar
            // 
            this.pct_comprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_comprar.Image = ((System.Drawing.Image)(resources.GetObject("pct_comprar.Image")));
            this.pct_comprar.Location = new System.Drawing.Point(323, 553);
            this.pct_comprar.Name = "pct_comprar";
            this.pct_comprar.Size = new System.Drawing.Size(62, 46);
            this.pct_comprar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_comprar.TabIndex = 63;
            this.pct_comprar.TabStop = false;
            this.pct_comprar.Click += new System.EventHandler(this.Pct_comprar_Click);
            // 
            // lbl_cont
            // 
            this.lbl_cont.AutoSize = true;
            this.lbl_cont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cont.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont.Location = new System.Drawing.Point(277, 602);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(136, 31);
            this.lbl_cont.TabIndex = 64;
            this.lbl_cont.Text = "Continuar";
            // 
            // MainGlases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(458, 648);
            this.Controls.Add(this.lbl_cont);
            this.Controls.Add(this.pct_comprar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmb_colorPol);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_diseno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_nombre_glasses);
            this.Controls.Add(this.pct_glasses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainGlases";
            this.Text = "MainGlases";
            this.Load += new System.EventHandler(this.MainGlases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_glasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_comprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pct_glasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cmb_diseno;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_colorPol;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pct_comprar;
        private System.Windows.Forms.Label lbl_cont;
        public System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.Label lbl_nombre_glasses;
    }
}