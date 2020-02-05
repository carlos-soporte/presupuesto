namespace Presupuesto_G
{
    partial class FrmListarProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarProyectos));
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNombreProyecto = new System.Windows.Forms.RadioButton();
            this.rdbNumeroProceso = new System.Windows.Forms.RadioButton();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(369, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lista de Proyectos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(308, 175);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(60, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filtrar por:";
            // 
            // rdbNombreProyecto
            // 
            this.rdbNombreProyecto.AutoSize = true;
            this.rdbNombreProyecto.Location = new System.Drawing.Point(218, 123);
            this.rdbNombreProyecto.Name = "rdbNombreProyecto";
            this.rdbNombreProyecto.Size = new System.Drawing.Size(218, 26);
            this.rdbNombreProyecto.TabIndex = 19;
            this.rdbNombreProyecto.TabStop = true;
            this.rdbNombreProyecto.Text = "Nombre de Proyecto";
            this.rdbNombreProyecto.UseVisualStyleBackColor = true;
            // 
            // rdbNumeroProceso
            // 
            this.rdbNumeroProceso.AutoSize = true;
            this.rdbNumeroProceso.Location = new System.Drawing.Point(502, 123);
            this.rdbNumeroProceso.Name = "rdbNumeroProceso";
            this.rdbNumeroProceso.Size = new System.Drawing.Size(212, 26);
            this.rdbNumeroProceso.TabIndex = 20;
            this.rdbNumeroProceso.TabStop = true;
            this.rdbNumeroProceso.Text = "Nùmero de Proceso";
            this.rdbNumeroProceso.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(65, 175);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(237, 29);
            this.txtFiltrar.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 426);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 36);
            this.btnMenu.TabIndex = 23;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(426, 175);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(154, 35);
            this.btnRefrescar.TabIndex = 24;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(678, 175);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(72, 35);
            this.btnVer.TabIndex = 25;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(756, 175);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 35);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(908, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmListarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1140, 686);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.rdbNumeroProceso);
            this.Controls.Add(this.rdbNombreProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmListarProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListarProyectocs";
            this.Load += new System.EventHandler(this.FrmListarProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNombreProyecto;
        private System.Windows.Forms.RadioButton rdbNumeroProceso;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}