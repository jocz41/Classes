/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario II. Más funciones.
* FECHA de ENTREGA.....: 25 de Enero de 2018
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Practica9
{
    public partial class VistaGrupo : Form
    {
        private Grupo grupo;

        public VistaGrupo()
        {
            InitializeComponent();
            listaAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region Eventos
        
        private void nuevoGrupo_Click(object sender, EventArgs e)
        {
            NuevoGrupo ng = new NuevoGrupo();

            ng.ShowDialog();
            grupo = ng.GrupoNuevo;

            if (grupo != null)
            {
                refrescar();
            }
        }

        private void guardarGrupo_Click(object sender, EventArgs e)
        {
            String dni;

            grupo.vaciar();
            listaAlumnos.ClearSelection();
            listaAlumnos.CurrentCell = null;

            try
            {
                foreach (DataGridViewRow fila in listaAlumnos.Rows)
                {
                    if (fila.Index < (listaAlumnos.RowCount - 1))
                    {
                        dni = fila.Cells[0].Value.ToString();

                        if (grupo.dniExiste(dni))
                        {
                            fila.Cells[0].ErrorText = "DNI ya registrado.";
                            throw new Exception();
                        }
                        else
                        {
                            int[] notas = new int[grupo.NAsig];

                            for (int i = 0; i < notas.Length; i++)
                            {
                                if (!fila.Cells[i + 2].ErrorText.Equals(""))
                                {
                                    throw new Exception();
                                }

                                String s = fila.Cells[i + 2].Value.ToString();
                                notas[i] = Int16.Parse(fila.Cells[i + 2].Value.ToString());
                            }

                            if (!fila.Cells[0].ErrorText.Equals("") || !fila.Cells[1].ErrorText.Equals(""))
                            {
                                throw new Exception();
                            }

                            Alumno a = new Alumno(dni, fila.Cells[1].Value.ToString(), notas);
                            grupo.aniadirAlumno(a);
                            grupo.creaFichero();
                        }
                    }
                }

                MessageBox.Show("Grupo guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Uno o más campos vacíos o erróneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirGrupo_Click(object sender, EventArgs e)
        {
            OpenFileDialog busca = new OpenFileDialog();
            DialogResult respuesta;
            string ruta = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Grupos");
            string nombre;

            busca.InitialDirectory = Path.GetFullPath(ruta);
            busca.Multiselect = false;
            busca.Filter = "Grupos (.gru)|*.gru";
            busca.FilterIndex = 1;

            respuesta = busca.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                nombre = busca.FileName;
                String s = nombre;
                grupo = leerFichero(nombre);
                refrescar();
                cbAprobados.Checked = false;
            }
        }

        private void celda_ValidacionCelda (Object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewCell celda = listaAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            String s = e.FormattedValue.ToString();
            
            if (!String.IsNullOrEmpty(s))
            {
                if (e.ColumnIndex == 0)
                {
                    if (!formatoDNI(s))
                    {
                        celda.ErrorText = "Formato de DNI erróneo.";
                    }
                    else
                    {
                        celda.ErrorText = "";
                    }

                }
                else if (e.ColumnIndex > 1)
                {
                    int nota = Int16.Parse(s);

                    if (nota > 10)
                    {
                        celda.ErrorText = "Las notas no deben ser mayor de 10.";
                    }
                    else
                    {
                        celda.ErrorText = "";
                    }
                }
            }
                        
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(KeyPress_Lista);
        }
        
        private void KeyPress_Lista(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != (char)(Keys.Back) && c != (char)(Keys.Space) && !char.IsLetterOrDigit(c))
                e.Handled = true;
            else
            {
                TextBox caja = (TextBox)sender;

                if (listaAlumnos.SelectedCells[0].ColumnIndex == 0)
                {

                    if (!char.IsLetterOrDigit(c) && c != (char)(Keys.Back))
                    {
                        e.Handled = true;
                    }
                }
                else if (listaAlumnos.SelectedCells[0].ColumnIndex == 1)
                {
                    if (!char.IsLetter(c)  && c != (char)(Keys.Back) && c != (char)(Keys.Space))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (caja.ToString().Equals("") || caja.ToString().EndsWith(" "))
                        {
                            if (!Mayuscula(e))
                                e.Handled = true;
                        }
                        else
                        {
                            if (Mayuscula(e))
                                e.Handled = true;
                        }
                    }
                }
                else
                {
                    if (!char.IsDigit(c) && c != (char)(Keys.Back))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void cbAprobados_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            listaAlumnos.CurrentCell = null;

            if (cb.Checked)
            {
                foreach (DataGridViewRow fila in listaAlumnos.Rows)
                {
                    if (fila.Index < (listaAlumnos.RowCount -1) && !todoAprobado(fila))
                    {
                        fila.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow fila in listaAlumnos.Rows)
                {
                    if (fila.Index < (listaAlumnos.RowCount - 1))
                    {
                        fila.Visible = true;
                    }
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Está seguro de que desea salir? Los cambios no guardados no se almacenarán.",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Métodos Auxiliares

        private void rellenarLista()
        {
            DataTable Alumnos = new DataTable("Alumnos");
            List<DataColumn> columnas = new List<DataColumn>();

            columnas.Add(new DataColumn("DNI"));
            columnas.Add(new DataColumn("Nombre"));

            foreach (String s in grupo.CodAsignaturas)
            {
                columnas.Add(new DataColumn(s));
            }

            foreach (DataColumn c in columnas)
            {
                Alumnos.Columns.Add(c);
            }

            DataRow row;

            foreach (Alumno a in grupo.Alumnos)
            {
                row = Alumnos.NewRow();

                row["DNI"] = a.Dni;
                row["Nombre"] = a.Nombre;

                for (int i = 2; i < columnas.Count; i++)
                {
                    row[i] = a.Notas[i - 2];
                }
                
                Alumnos.Rows.Add(row);
            }
            
            listaAlumnos.DataSource = Alumnos;
        }

        private bool Mayuscula(KeyPressEventArgs e)
        {
            return (e.KeyChar >= 'A' && e.KeyChar <= 'Z');
        }

        private bool formatoDNI(string s)
        {
            bool correcto = false;
            string LETRAS = "TRWAGMYFPDXBNJZSQVHLCKE";

            if (s.Length == 9)
            {
                string n = s.Substring(0, 8);
                char c = s.Substring(8).ToUpper()[0];

                try
                {
                    int num = Int32.Parse(n);

                    correcto = (LETRAS[num % 23] == c);
                }
                catch (FormatException) { }
            }

            return correcto;
        }

        private Grupo leerFichero(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Grupo g = bf.Deserialize(fs) as Grupo;
            fs.Close();

            if (g.Alumnos != null && g.Alumnos.Count > 0)
            {
                Alumno a;
                uint i = 1;

                while ((a = g.buscaAlumno(i)) == null)
                {
                    i++;
                }

                a.ContMat = g.maxMat();
            }

            return g;
        }

        private void refrescar()
        {
            lblNombreGrupo.Text = grupo.NombreGrupo;
            rellenarLista();

            if (!cbAprobados.Enabled)
            {
                cbAprobados.Enabled = true;
                listaAlumnos.Enabled = true;
                menuOpciones.Items[2].Enabled = true;
            }
        }

        private bool todoAprobado(DataGridViewRow fila)
        {
            bool aprobado = true;
            int c = 2;

            while (c < listaAlumnos.ColumnCount && aprobado)
            {
                try
                {
                    String s = fila.Cells[c].Value.ToString();
                    int nota = Int16.Parse(s);

                    aprobado = (nota > 4);

                }
                catch (Exception)
                {
                    aprobado = false;
                }

                c++;
            }

            return aprobado;
        }

        #endregion
    }
}
