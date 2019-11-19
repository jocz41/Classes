/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario II. Más funciones.
* FECHA de ENTREGA.....: 25 de Enero de 2018
*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica9
{

    public partial class NuevoGrupo : Form
    {
        private Grupo grupoNuevo;
        private bool creado;
        
        internal Grupo GrupoNuevo { get => grupoNuevo; }

        public NuevoGrupo()
        {
            creado = false;
            grupoNuevo = null;

            InitializeComponent();
            txtNombre.Select();
        }

        private void crearGrupo_Click(object sender, EventArgs e)
        {
            int cont = 0;
            List<String> asig = new List<String>();

            foreach (Control ct in gbAsignaturas.Controls)
            {
                if (ct is CheckBox)
                {
                    CheckBox c = (CheckBox) ct;
                    
                    if (c.Checked)
                    {
                        cont++;
                        asig.Add(c.Name.Substring(2));
                    }
                }
            }

            if (cont < 4)
            {
                MessageBox.Show("Debe seleccionar como mínimo 4 asignaturas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grupoNuevo = new Grupo(txtNombre.Text.ToString(), Convert.ToByte(cont), asig.ToArray());
                grupoNuevo.creaFichero();
                creado = true;

                MessageBox.Show("Grupo guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
        }

        private void dialogo_Cerrar(object sender, FormClosingEventArgs e)
        {
            if (!creado)
            {
                DialogResult d = MessageBox.Show("¿Desea salir sin guardar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
