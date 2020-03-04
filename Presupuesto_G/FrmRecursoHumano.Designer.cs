namespace Presupuesto_G
{
    partial class FrmRecursoHumano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecursoHumano));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbRecursoHumano = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtVofertado = new System.Windows.Forms.TextBox();
            this.txtTiempoM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtPtoOficial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVoficial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.observaciones = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMenuItems = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1344, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 44);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1344, 358);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(126, 44);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lbRecursoHumano
            // 
            this.lbRecursoHumano.AutoSize = true;
            this.lbRecursoHumano.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecursoHumano.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbRecursoHumano.Location = new System.Drawing.Point(521, 9);
            this.lbRecursoHumano.Name = "lbRecursoHumano";
            this.lbRecursoHumano.Size = new System.Drawing.Size(245, 29);
            this.lbRecursoHumano.TabIndex = 24;
            this.lbRecursoHumano.Text = "RECURSO HUMANO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 256);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(640, 109);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 38);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtVofertado
            // 
            this.txtVofertado.Location = new System.Drawing.Point(640, 47);
            this.txtVofertado.Name = "txtVofertado";
            this.txtVofertado.Size = new System.Drawing.Size(148, 35);
            this.txtVofertado.TabIndex = 21;
            // 
            // txtTiempoM
            // 
            this.txtTiempoM.Location = new System.Drawing.Point(225, 98);
            this.txtTiempoM.Name = "txtTiempoM";
            this.txtTiempoM.Size = new System.Drawing.Size(126, 35);
            this.txtTiempoM.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor Oficial :";
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.Location = new System.Drawing.Point(179, 53);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(264, 35);
            this.txtNombreProfesional.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tiempo en Meses";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(179, 3);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(264, 35);
            this.txtCargo.TabIndex = 28;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(461, 119);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(137, 35);
            this.btnAsignar.TabIndex = 31;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtPtoOficial
            // 
            this.txtPtoOficial.Location = new System.Drawing.Point(191, 119);
            this.txtPtoOficial.Name = "txtPtoOficial";
            this.txtPtoOficial.Size = new System.Drawing.Size(264, 35);
            this.txtPtoOficial.TabIndex = 30;
            this.txtPtoOficial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPtoOficial_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Pto Oficial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "ValorOfertado :";
            // 
            // txtVoficial
            // 
            this.txtVoficial.Location = new System.Drawing.Point(640, 0);
            this.txtVoficial.Name = "txtVoficial";
            this.txtVoficial.Size = new System.Drawing.Size(148, 35);
            this.txtVoficial.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cargo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "N.Profesional";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.observaciones);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtVoficial);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtCargo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVofertado);
            this.panel1.Controls.Add(this.txtTiempoM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreProfesional);
            this.panel1.Location = new System.Drawing.Point(12, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 166);
            this.panel1.TabIndex = 37;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(799, 47);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(308, 100);
            this.txtObservaciones.TabIndex = 38;
            // 
            // observaciones
            // 
            this.observaciones.AutoSize = true;
            this.observaciones.Location = new System.Drawing.Point(872, 3);
            this.observaciones.Name = "observaciones";
            this.observaciones.Size = new System.Drawing.Size(180, 29);
            this.observaciones.TabIndex = 37;
            this.observaciones.Text = "observaciones";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(1, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(126, 37);
            this.btnMenu.TabIndex = 38;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMenuItems
            // 
            this.btnMenuItems.Location = new System.Drawing.Point(133, 1);
            this.btnMenuItems.Name = "btnMenuItems";
            this.btnMenuItems.Size = new System.Drawing.Size(126, 37);
            this.btnMenuItems.TabIndex = 39;
            this.btnMenuItems.Text = "Items";
            this.btnMenuItems.UseVisualStyleBackColor = true;
            this.btnMenuItems.Click += new System.EventHandler(this.btnMenuItems_Click);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt2.Location = new System.Drawing.Point(340, 701);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(172, 35);
            this.txt2.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 707);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 29);
            this.label13.TabIndex = 46;
            this.label13.Text = "Total % ejecutado";
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt3.Location = new System.Drawing.Point(742, 647);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(172, 35);
            this.txt3.TabIndex = 45;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt4.Location = new System.Drawing.Point(742, 698);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(172, 35);
            this.txt4.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(543, 704);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 29);
            this.label12.TabIndex = 43;
            this.label12.Text = "Total % ganancia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 653);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 29);
            this.label11.TabIndex = 42;
            this.label11.Text = "Total ganancias";
            // 
            // txtTotalP
            // 
            this.txtTotalP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTotalP.Location = new System.Drawing.Point(340, 650);
            this.txtTotalP.Name = "txtTotalP";
            this.txtTotalP.ReadOnly = true;
            this.txtTotalP.Size = new System.Drawing.Size(172, 35);
            this.txtTotalP.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Total Presupuesto Ofertado";
            // 
            // FrmRecursoHumano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1482, 775);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMenuItems);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbRecursoHumano);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPtoOficial);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecursoHumano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expertos profesionales en servicios sociales integrales";
            this.Load += new System.EventHandler(this.FrmRecursoHumano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lbRecursoHumano;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtVofertado;
        private System.Windows.Forms.TextBox txtTiempoM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtPtoOficial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVoficial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label observaciones;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMenuItems;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalP;
        private System.Windows.Forms.Label label2;
    }
}