namespace Practica9
{
    partial class VistaGrupo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaGrupo));
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.abrirGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirGrupoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAlumnos = new System.Windows.Forms.DataGridView();
            this.cbAprobados = new System.Windows.Forms.CheckBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.menuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOpciones
            // 
            this.menuOpciones.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirGrupoToolStripMenuItem,
            this.abrirGrupoToolStripMenuItem1,
            this.guardarGrupoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(852, 33);
            this.menuOpciones.TabIndex = 0;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // abrirGrupoToolStripMenuItem
            // 
            this.abrirGrupoToolStripMenuItem.Name = "abrirGrupoToolStripMenuItem";
            this.abrirGrupoToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.abrirGrupoToolStripMenuItem.Text = "Nuevo Grupo";
            this.abrirGrupoToolStripMenuItem.Click += new System.EventHandler(this.nuevoGrupo_Click);
            // 
            // abrirGrupoToolStripMenuItem1
            // 
            this.abrirGrupoToolStripMenuItem1.Name = "abrirGrupoToolStripMenuItem1";
            this.abrirGrupoToolStripMenuItem1.Size = new System.Drawing.Size(124, 29);
            this.abrirGrupoToolStripMenuItem1.Text = "Abrir Grupo";
            this.abrirGrupoToolStripMenuItem1.Click += new System.EventHandler(this.abrirGrupo_Click);
            // 
            // guardarGrupoToolStripMenuItem
            // 
            this.guardarGrupoToolStripMenuItem.Enabled = false;
            this.guardarGrupoToolStripMenuItem.Name = "guardarGrupoToolStripMenuItem";
            this.guardarGrupoToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.guardarGrupoToolStripMenuItem.Text = "Guardar Grupo";
            this.guardarGrupoToolStripMenuItem.Click += new System.EventHandler(this.guardarGrupo_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.CausesValidation = false;
            this.listaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAlumnos.Enabled = false;
            this.listaAlumnos.Location = new System.Drawing.Point(12, 165);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.RowTemplate.Height = 24;
            this.listaAlumnos.Size = new System.Drawing.Size(828, 291);
            this.listaAlumnos.TabIndex = 1;
            this.listaAlumnos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.celda_ValidacionCelda);
            this.listaAlumnos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            this.listaAlumnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Lista);
            // 
            // cbAprobados
            // 
            this.cbAprobados.AutoSize = true;
            this.cbAprobados.Enabled = false;
            this.cbAprobados.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAprobados.Location = new System.Drawing.Point(53, 120);
            this.cbAprobados.Name = "cbAprobados";
            this.cbAprobados.Size = new System.Drawing.Size(150, 23);
            this.cbAprobados.TabIndex = 2;
            this.cbAprobados.Text = "Todo aprobado";
            this.cbAprobados.UseVisualStyleBackColor = true;
            this.cbAprobados.CheckedChanged += new System.EventHandler(this.cbAprobados_CheckedChanged);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNombreGrupo.Location = new System.Drawing.Point(25, 54);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(0, 38);
            this.lblNombreGrupo.TabIndex = 3;
            // 
            // VistaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 468);
            this.ControlBox = false;
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.cbAprobados);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.menuOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "VistaGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Grupos";
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem abrirGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirGrupoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView listaAlumnos;
        private System.Windows.Forms.CheckBox cbAprobados;
        private System.Windows.Forms.Label lblNombreGrupo;
    }
}

