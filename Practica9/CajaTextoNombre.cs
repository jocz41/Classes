/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario II. Más funciones.
* FECHA de ENTREGA.....: 25 de Enero de 2018
*/

using System;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class CajaTextoMayInic : TextBox
    {
        public CajaTextoMayInic()
        {
            InitializeComponent();
            inicializar();
        }

        #region Eventos

        private void KeyPress_MayInic(object sender, KeyPressEventArgs e)
        {
            TextBox caja = (TextBox) sender;

            if (e.KeyChar != (char)(Keys.Back) && e.KeyChar != (char)(Keys.Space) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Leave_MayInic(object sender, EventArgs ev)
        {
            TextBox caja = (TextBox)sender;

            if (caja.Text.ToString().Length == 0)
            {
                MessageBox.Show("El campo no puede estar vacío (Inicial Mayúscula).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Select();
            }
        }

        #endregion        

        private bool Mayuscula(KeyPressEventArgs e)
        {
            return (e.KeyChar >= 'A' && e.KeyChar <= 'Z');
        }
        
        private void inicializar()
        {
            this.KeyPress += new KeyPressEventHandler(KeyPress_MayInic);
            this.Leave += new EventHandler(Leave_MayInic);
        }
    }
}
