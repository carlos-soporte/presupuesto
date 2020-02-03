namespace Presupuesto_G
{
    partial class FrmCrearProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearProyecto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.NumeroProceso = new System.Windows.Forms.TextBox();
            this.txtPresupuestoProyecto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Presupuesto del Proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Proceso";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(306, 103);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(402, 34);
            this.txtNombreProyecto.TabIndex = 3;
            // 
            // NumeroProceso
            // 
            this.NumeroProceso.Location = new System.Drawing.Point(306, 192);
            this.NumeroProceso.Name = "NumeroProceso";
            this.NumeroProceso.Size = new System.Drawing.Size(402, 34);
            this.NumeroProceso.TabIndex = 4;
            // 
            // txtPresupuestoProyecto
            // 
            this.txtPresupuestoProyecto.Location = new System.Drawing.Point(306, 146);
            this.txtPresupuestoProyecto.Name = "txtPresupuestoProyecto";
            this.txtPresupuestoProyecto.Size = new System.Drawing.Size(402, 34);
            this.txtPresupuestoProyecto.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(306, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(262, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "INICIACIÒN DE PROYECTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Descripciòn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 34);
            this.textBox1.TabIndex = 16;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(447, 304);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(135, 36);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FrmCrearProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 383);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPresupuestoProyecto);
            this.Controls.Add(this.NumeroProceso);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmCrearProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.TextBox NumeroProceso;
        private System.Windows.Forms.TextBox txtPresupuestoProyecto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMenu;
    }
}