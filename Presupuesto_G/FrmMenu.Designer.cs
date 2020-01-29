namespace Presupuesto_G
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnCrearProyecto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListarProyectos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProyecto
            // 
            this.btnCrearProyecto.Location = new System.Drawing.Point(199, 132);
            this.btnCrearProyecto.Margin = new System.Windows.Forms.Padding(5);
            this.btnCrearProyecto.Name = "btnCrearProyecto";
            this.btnCrearProyecto.Size = new System.Drawing.Size(343, 57);
            this.btnCrearProyecto.TabIndex = 0;
            this.btnCrearProyecto.Text = "CREAR PROYECTO";
            this.btnCrearProyecto.UseVisualStyleBackColor = true;
            this.btnCrearProyecto.Click += new System.EventHandler(this.btnCrearProyecto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 1;
            // 
            // btnListarProyectos
            // 
            this.btnListarProyectos.Location = new System.Drawing.Point(199, 207);
            this.btnListarProyectos.Margin = new System.Windows.Forms.Padding(5);
            this.btnListarProyectos.Name = "btnListarProyectos";
            this.btnListarProyectos.Size = new System.Drawing.Size(343, 57);
            this.btnListarProyectos.TabIndex = 2;
            this.btnListarProyectos.Text = "LISTAR PROYECTOS";
            this.btnListarProyectos.UseVisualStyleBackColor = true;
            this.btnListarProyectos.Click += new System.EventHandler(this.btnListarProyectos_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 346);
            this.Controls.Add(this.btnListarProyectos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearProyecto);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarProyectos;
    }
}