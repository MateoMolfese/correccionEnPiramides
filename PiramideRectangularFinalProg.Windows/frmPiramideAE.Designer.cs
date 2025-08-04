namespace PiramideRectangularFinalProg.Windows
{
    partial class frmPiramideAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtLado = new TextBox();
            label2 = new Label();
            nudCantidad = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtMadera = new RadioButton();
            rbtVidrio = new RadioButton();
            rbtPlastico = new RadioButton();
            label3 = new Label();
            cboColores = new ComboBox();
            btnCancelar = new Button();
            btnOK = new Button();
            errorProvider1 = new ErrorProvider(components);
            label4 = new Label();
            txtAltura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 12);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(167, 12);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 76);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad Lados:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(166, 75);
            nudCantidad.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(101, 23);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtMadera);
            groupBox1.Controls.Add(rbtVidrio);
            groupBox1.Controls.Add(rbtPlastico);
            groupBox1.Location = new Point(58, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = " Material ";
            // 
            // rbtMadera
            // 
            rbtMadera.AutoSize = true;
            rbtMadera.Location = new Point(15, 72);
            rbtMadera.Name = "rbtMadera";
            rbtMadera.Size = new Size(65, 19);
            rbtMadera.TabIndex = 0;
            rbtMadera.Text = "Madera";
            rbtMadera.UseVisualStyleBackColor = true;
            // 
            // rbtVidrio
            // 
            rbtVidrio.AutoSize = true;
            rbtVidrio.Location = new Point(15, 47);
            rbtVidrio.Name = "rbtVidrio";
            rbtVidrio.Size = new Size(56, 19);
            rbtVidrio.TabIndex = 0;
            rbtVidrio.Text = "Vidrio";
            rbtVidrio.UseVisualStyleBackColor = true;
            // 
            // rbtPlastico
            // 
            rbtPlastico.AutoSize = true;
            rbtPlastico.Checked = true;
            rbtPlastico.Location = new Point(15, 22);
            rbtPlastico.Name = "rbtPlastico";
            rbtPlastico.Size = new Size(66, 19);
            rbtPlastico.TabIndex = 0;
            rbtPlastico.TabStop = true;
            rbtPlastico.Text = "Plástico";
            rbtPlastico.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 223);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Color:";
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Items.AddRange(new object[] { "Blanco", "Rojo", "Azul", "Verde", "Negro" });
            cboColores.Location = new Point(103, 220);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(164, 23);
            cboColores.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(192, 286);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 54);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.Location = new Point(58, 286);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 54);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 41);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Altura";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(167, 41);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // frmPiramideAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 359);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboColores);
            Controls.Add(groupBox1);
            Controls.Add(nudCantidad);
            Controls.Add(label2);
            Controls.Add(txtAltura);
            Controls.Add(txtLado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximumSize = new Size(343, 398);
            MinimumSize = new Size(343, 398);
            Name = "frmPiramideAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPiramideAE";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLado;
        private Label label2;
        private NumericUpDown nudCantidad;
        private GroupBox groupBox1;
        private RadioButton rbtPlastico;
        private RadioButton rbtMadera;
        private RadioButton rbtVidrio;
        private Label label3;
        private ComboBox cboColores;
        private Button btnCancelar;
        private Button btnOK;
        private ErrorProvider errorProvider1;
        private TextBox txtAltura;
        private Label label4;
    }
}