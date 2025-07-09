namespace LoginApp
{
    partial class FormPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreActivo = new System.Windows.Forms.TextBox();
            this.txtCostoOriginal = new System.Windows.Forms.TextBox();
            this.txtValorResidual = new System.Windows.Forms.TextBox();
            this.txtVidaUtil = new System.Windows.Forms.TextBox();
            this.txtAnioCalculo = new System.Windows.Forms.TextBox();
            this.lblDepreciacionAnual = new System.Windows.Forms.Label();
            this.basura = new System.Windows.Forms.Label();
            this.lblValorEnLibros = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDepreciacionAcumulada = new System.Windows.Forms.Label();
            this.txtIrEmpleados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Activo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo Original:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Residual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vida Útil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Depreciación Anual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Depreciación Acumulada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor en Libros:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Calcular para el Año:";
            // 
            // txtNombreActivo
            // 
            this.txtNombreActivo.Location = new System.Drawing.Point(124, 24);
            this.txtNombreActivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreActivo.Name = "txtNombreActivo";
            this.txtNombreActivo.Size = new System.Drawing.Size(176, 20);
            this.txtNombreActivo.TabIndex = 8;
            // 
            // txtCostoOriginal
            // 
            this.txtCostoOriginal.Location = new System.Drawing.Point(124, 48);
            this.txtCostoOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoOriginal.Name = "txtCostoOriginal";
            this.txtCostoOriginal.Size = new System.Drawing.Size(88, 20);
            this.txtCostoOriginal.TabIndex = 9;
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.Location = new System.Drawing.Point(125, 74);
            this.txtValorResidual.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Size = new System.Drawing.Size(87, 20);
            this.txtValorResidual.TabIndex = 10;
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Location = new System.Drawing.Point(125, 100);
            this.txtVidaUtil.Margin = new System.Windows.Forms.Padding(2);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Size = new System.Drawing.Size(43, 20);
            this.txtVidaUtil.TabIndex = 11;
            // 
            // txtAnioCalculo
            // 
            this.txtAnioCalculo.Location = new System.Drawing.Point(124, 123);
            this.txtAnioCalculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnioCalculo.Name = "txtAnioCalculo";
            this.txtAnioCalculo.Size = new System.Drawing.Size(109, 20);
            this.txtAnioCalculo.TabIndex = 12;
            // 
            // lblDepreciacionAnual
            // 
            this.lblDepreciacionAnual.AutoSize = true;
            this.lblDepreciacionAnual.Location = new System.Drawing.Point(127, 200);
            this.lblDepreciacionAnual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepreciacionAnual.Name = "lblDepreciacionAnual";
            this.lblDepreciacionAnual.Size = new System.Drawing.Size(0, 13);
            this.lblDepreciacionAnual.TabIndex = 13;
            // 
            // basura
            // 
            this.basura.AutoSize = true;
            this.basura.BackColor = System.Drawing.SystemColors.Highlight;
            this.basura.Location = new System.Drawing.Point(1313, 431);
            this.basura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.basura.Name = "basura";
            this.basura.Size = new System.Drawing.Size(101, 13);
            this.basura.TabIndex = 14;
            this.basura.Text = "jadsakbdasbfhjbsda";
            // 
            // lblValorEnLibros
            // 
            this.lblValorEnLibros.AutoSize = true;
            this.lblValorEnLibros.Location = new System.Drawing.Point(109, 233);
            this.lblValorEnLibros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorEnLibros.Name = "lblValorEnLibros";
            this.lblValorEnLibros.Size = new System.Drawing.Size(0, 13);
            this.lblValorEnLibros.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(347, 119);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 21);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular Depreciación";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDepreciacionAcumulada
            // 
            this.lblDepreciacionAcumulada.AutoSize = true;
            this.lblDepreciacionAcumulada.Location = new System.Drawing.Point(334, 200);
            this.lblDepreciacionAcumulada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepreciacionAcumulada.Name = "lblDepreciacionAcumulada";
            this.lblDepreciacionAcumulada.Size = new System.Drawing.Size(0, 13);
            this.lblDepreciacionAcumulada.TabIndex = 17;
            // 
            // txtIrEmpleados
            // 
            this.txtIrEmpleados.Location = new System.Drawing.Point(347, 19);
            this.txtIrEmpleados.Name = "txtIrEmpleados";
            this.txtIrEmpleados.ReadOnly = true;
            this.txtIrEmpleados.Size = new System.Drawing.Size(146, 20);
            this.txtIrEmpleados.TabIndex = 18;
            this.txtIrEmpleados.Text = "Ver Recuento de Empleados";
            this.txtIrEmpleados.Click += new System.EventHandler(this.txtIrEmpleados_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 285);
            this.Controls.Add(this.txtIrEmpleados);
            this.Controls.Add(this.lblDepreciacionAcumulada);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorEnLibros);
            this.Controls.Add(this.basura);
            this.Controls.Add(this.lblDepreciacionAnual);
            this.Controls.Add(this.txtAnioCalculo);
            this.Controls.Add(this.txtVidaUtil);
            this.Controls.Add(this.txtValorResidual);
            this.Controls.Add(this.txtCostoOriginal);
            this.Controls.Add(this.txtNombreActivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Activos Fijos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreActivo;
        private System.Windows.Forms.TextBox txtCostoOriginal;
        private System.Windows.Forms.TextBox txtValorResidual;
        private System.Windows.Forms.TextBox txtVidaUtil;
        private System.Windows.Forms.TextBox txtAnioCalculo;
        private System.Windows.Forms.Label lblDepreciacionAnual;
        private System.Windows.Forms.Label basura;
        private System.Windows.Forms.Label lblValorEnLibros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDepreciacionAcumulada;
        private System.Windows.Forms.TextBox txtIrEmpleados;
    }
}