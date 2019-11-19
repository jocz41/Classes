namespace Practica9
{
    partial class NuevoGrupo
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbAsignaturas = new System.Windows.Forms.GroupBox();
            this.cbDEI = new System.Windows.Forms.CheckBox();
            this.cbEMP = new System.Windows.Forms.CheckBox();
            this.cbDAT = new System.Windows.Forms.CheckBox();
            this.cbAND = new System.Windows.Forms.CheckBox();
            this.cbFOL = new System.Windows.Forms.CheckBox();
            this.cbPRO = new System.Windows.Forms.CheckBox();
            this.cbLEM = new System.Windows.Forms.CheckBox();
            this.cbBAD = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new Practica_8.CajaTextoMayInic();
            this.gbAsignaturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNombre.Location = new System.Drawing.Point(26, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbAsignaturas
            // 
            this.gbAsignaturas.BackColor = System.Drawing.SystemColors.Control;
            this.gbAsignaturas.Controls.Add(this.cbDEI);
            this.gbAsignaturas.Controls.Add(this.cbEMP);
            this.gbAsignaturas.Controls.Add(this.cbDAT);
            this.gbAsignaturas.Controls.Add(this.cbAND);
            this.gbAsignaturas.Controls.Add(this.cbFOL);
            this.gbAsignaturas.Controls.Add(this.cbPRO);
            this.gbAsignaturas.Controls.Add(this.cbLEM);
            this.gbAsignaturas.Controls.Add(this.cbBAD);
            this.gbAsignaturas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsignaturas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbAsignaturas.Location = new System.Drawing.Point(30, 93);
            this.gbAsignaturas.Name = "gbAsignaturas";
            this.gbAsignaturas.Size = new System.Drawing.Size(505, 205);
            this.gbAsignaturas.TabIndex = 2;
            this.gbAsignaturas.TabStop = false;
            this.gbAsignaturas.Text = "Asignaturas";
            // 
            // cbDEI
            // 
            this.cbDEI.AutoSize = true;
            this.cbDEI.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDEI.ForeColor = System.Drawing.Color.Black;
            this.cbDEI.Location = new System.Drawing.Point(282, 166);
            this.cbDEI.Name = "cbDEI";
            this.cbDEI.Size = new System.Drawing.Size(206, 23);
            this.cbDEI.TabIndex = 8;
            this.cbDEI.Text = "Desarrollo de Interfaces";
            this.cbDEI.UseVisualStyleBackColor = true;
            // 
            // cbEMP
            // 
            this.cbEMP.AutoSize = true;
            this.cbEMP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEMP.ForeColor = System.Drawing.Color.Black;
            this.cbEMP.Location = new System.Drawing.Point(282, 82);
            this.cbEMP.Name = "cbEMP";
            this.cbEMP.Size = new System.Drawing.Size(96, 23);
            this.cbEMP.TabIndex = 6;
            this.cbEMP.Text = "Empresa";
            this.cbEMP.UseVisualStyleBackColor = true;
            // 
            // cbDAT
            // 
            this.cbDAT.AutoSize = true;
            this.cbDAT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDAT.ForeColor = System.Drawing.Color.Black;
            this.cbDAT.Location = new System.Drawing.Point(282, 123);
            this.cbDAT.Name = "cbDAT";
            this.cbDAT.Size = new System.Drawing.Size(156, 23);
            this.cbDAT.TabIndex = 7;
            this.cbDAT.Text = "Acceso de Datos";
            this.cbDAT.UseVisualStyleBackColor = true;
            // 
            // cbAND
            // 
            this.cbAND.AutoSize = true;
            this.cbAND.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAND.ForeColor = System.Drawing.Color.Black;
            this.cbAND.Location = new System.Drawing.Point(282, 45);
            this.cbAND.Name = "cbAND";
            this.cbAND.Size = new System.Drawing.Size(88, 23);
            this.cbAND.TabIndex = 5;
            this.cbAND.Text = "Android";
            this.cbAND.UseVisualStyleBackColor = true;
            // 
            // cbFOL
            // 
            this.cbFOL.AutoSize = true;
            this.cbFOL.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFOL.ForeColor = System.Drawing.Color.Black;
            this.cbFOL.Location = new System.Drawing.Point(22, 166);
            this.cbFOL.Name = "cbFOL";
            this.cbFOL.Size = new System.Drawing.Size(198, 23);
            this.cbFOL.TabIndex = 4;
            this.cbFOL.Text = "Entornos de Desarrollo";
            this.cbFOL.UseVisualStyleBackColor = true;
            // 
            // cbPRO
            // 
            this.cbPRO.AutoSize = true;
            this.cbPRO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRO.ForeColor = System.Drawing.Color.Black;
            this.cbPRO.Location = new System.Drawing.Point(22, 82);
            this.cbPRO.Name = "cbPRO";
            this.cbPRO.Size = new System.Drawing.Size(134, 23);
            this.cbPRO.TabIndex = 2;
            this.cbPRO.Text = "Programación";
            this.cbPRO.UseVisualStyleBackColor = true;
            // 
            // cbLEM
            // 
            this.cbLEM.AutoSize = true;
            this.cbLEM.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLEM.ForeColor = System.Drawing.Color.Black;
            this.cbLEM.Location = new System.Drawing.Point(22, 123);
            this.cbLEM.Name = "cbLEM";
            this.cbLEM.Size = new System.Drawing.Size(179, 23);
            this.cbLEM.TabIndex = 3;
            this.cbLEM.Text = "Lenguajes de Marca";
            this.cbLEM.UseVisualStyleBackColor = true;
            // 
            // cbBAD
            // 
            this.cbBAD.AutoSize = true;
            this.cbBAD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBAD.ForeColor = System.Drawing.Color.Black;
            this.cbBAD.Location = new System.Drawing.Point(22, 45);
            this.cbBAD.Name = "cbBAD";
            this.cbBAD.Size = new System.Drawing.Size(146, 23);
            this.cbBAD.TabIndex = 1;
            this.cbBAD.Text = "Bases de Datos";
            this.cbBAD.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCrear.Location = new System.Drawing.Point(207, 318);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(142, 67);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.crearGrupo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(143, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(392, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // NuevoGrupo
            // 
            this.ClientSize = new System.Drawing.Size(565, 397);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gbAsignaturas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "NuevoGrupo";
            this.ShowIcon = false;
            this.Text = "Nuevo Grupo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dialogo_Cerrar);
            this.gbAsignaturas.ResumeLayout(false);
            this.gbAsignaturas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Practica_8.CajaTextoMayInic txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbAsignaturas;
        private System.Windows.Forms.CheckBox cbDEI;
        private System.Windows.Forms.CheckBox cbEMP;
        private System.Windows.Forms.CheckBox cbDAT;
        private System.Windows.Forms.CheckBox cbAND;
        private System.Windows.Forms.CheckBox cbFOL;
        private System.Windows.Forms.CheckBox cbPRO;
        private System.Windows.Forms.CheckBox cbLEM;
        private System.Windows.Forms.CheckBox cbBAD;
        private System.Windows.Forms.Button btnCrear;
    }
}
