namespace PiramideRectangularFinalProg.Windows
{
    partial class frmDetallePiramide
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
            txtAltura = new TextBox();
            txtLado = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCantidadLados = new TextBox();
            label3 = new Label();
            txtMaterial = new TextBox();
            label5 = new Label();
            txtColor = new TextBox();
            label6 = new Label();
            txtVolumen = new TextBox();
            label7 = new Label();
            txtAreaBase = new TextBox();
            label8 = new Label();
            txtAreaLateral = new TextBox();
            label9 = new Label();
            txtAreaTotal = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(149, 53);
            txtAltura.Name = "txtAltura";
            txtAltura.ReadOnly = true;
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 4;
            // 
            // txtLado
            // 
            txtLado.Location = new Point(149, 24);
            txtLado.Name = "txtLado";
            txtLado.ReadOnly = true;
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 53);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Altura";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Lado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 82);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Cant. Lados";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCantidadLados
            // 
            txtCantidadLados.Location = new Point(149, 82);
            txtCantidadLados.Name = "txtCantidadLados";
            txtCantidadLados.ReadOnly = true;
            txtCantidadLados.Size = new Size(100, 23);
            txtCantidadLados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 111);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Material:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // txtMaterial
            // 
            txtMaterial.Location = new Point(149, 111);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.ReadOnly = true;
            txtMaterial.Size = new Size(100, 23);
            txtMaterial.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 140);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 2;
            label5.Text = "Color";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(149, 140);
            txtColor.Name = "txtColor";
            txtColor.ReadOnly = true;
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 169);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 2;
            label6.Text = "Volumen:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(149, 169);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.ReadOnly = true;
            txtVolumen.Size = new Size(100, 23);
            txtVolumen.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 198);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 2;
            label7.Text = "Area Base:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAreaBase
            // 
            txtAreaBase.Location = new Point(149, 198);
            txtAreaBase.Name = "txtAreaBase";
            txtAreaBase.ReadOnly = true;
            txtAreaBase.Size = new Size(100, 23);
            txtAreaBase.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 227);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 2;
            label8.Text = "Area Lateral:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAreaLateral
            // 
            txtAreaLateral.Location = new Point(149, 227);
            txtAreaLateral.Name = "txtAreaLateral";
            txtAreaLateral.ReadOnly = true;
            txtAreaLateral.Size = new Size(100, 23);
            txtAreaLateral.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 256);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 2;
            label9.Text = "Area Total:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAreaTotal
            // 
            txtAreaTotal.Location = new Point(149, 256);
            txtAreaTotal.Name = "txtAreaTotal";
            txtAreaTotal.ReadOnly = true;
            txtAreaTotal.Size = new Size(100, 23);
            txtAreaTotal.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.Location = new Point(114, 301);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 54);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmDetallePiramide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 371);
            Controls.Add(btnOK);
            Controls.Add(txtAreaTotal);
            Controls.Add(txtAreaLateral);
            Controls.Add(label9);
            Controls.Add(txtAreaBase);
            Controls.Add(label8);
            Controls.Add(txtVolumen);
            Controls.Add(label7);
            Controls.Add(txtColor);
            Controls.Add(label6);
            Controls.Add(txtMaterial);
            Controls.Add(label5);
            Controls.Add(txtCantidadLados);
            Controls.Add(label3);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(txtLado);
            Controls.Add(label4);
            Controls.Add(label1);
            MaximumSize = new Size(330, 410);
            MinimumSize = new Size(330, 410);
            Name = "frmDetallePiramide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetallePiramide";
            Load += frmDetallePiramide_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAltura;
        private TextBox txtLado;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox txtCantidadLados;
        private Label label3;
        private TextBox txtMaterial;
        private Label label5;
        private TextBox txtColor;
        private Label label6;
        private TextBox txtVolumen;
        private Label label7;
        private TextBox txtAreaBase;
        private Label label8;
        private TextBox txtAreaLateral;
        private Label label9;
        private TextBox txtAreaTotal;
        private Button btnOK;
    }
}