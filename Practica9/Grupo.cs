/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario II. Más funciones.
* FECHA de ENTREGA.....: 25 de Enero de 2018
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica9
{
    [Serializable]
    class Grupo
    {
        #region Atributos

        private string nombreGrupo;
        private byte nAsig;
        private string[] codAsignaturas;
        private List<Alumno> alumnos;

        #endregion

        public Grupo(string nombre, byte nAsig, string[] codAsig)
        {
            this.nombreGrupo = nombre;
            this.nAsig = nAsig;

            this.codAsignaturas = new string[codAsig.Length];
            Array.Copy(codAsig, this.codAsignaturas, codAsig.Length);
            
            this.alumnos = new List<Alumno>();
        }

        #region Propiedades

        public string NombreGrupo
        {
            get => nombreGrupo;
        }

        public byte NAsig
        {
            get => nAsig;
        }

        public string[] CodAsignaturas
        {
            get => codAsignaturas;
        }

        public List<Alumno> Alumnos
        {
            get => alumnos;
        }

        #endregion

        #region Métodos

        public void aniadirAlumno(Alumno a)
        {
            alumnos.Add(a);
            alumnos.Sort();
        }

        private int localizaAlumno(uint nMat)
        {
            return alumnos.FindIndex(a => a.NMat == nMat);
        }

        public Alumno buscaAlumno(uint nMat)
        {
            int ind = localizaAlumno(nMat);
            
            return (ind < 0) ? null : alumnos.ElementAt(ind);
        }

        public bool borraAlumno(Alumno a)
        {             
            alumnos.Remove(a);            

            return true;
        }

        public float mediaAsignatura (string asignatura)
        {
            float media = 0;
            int ind = Array.IndexOf(CodAsignaturas, asignatura);

            foreach (Alumno a in alumnos)
            {
                media += a.Notas[ind];
            }

            return (float) Math.Round(media/alumnos.Count, 1);
        }
        
        public void creaFichero()
        {
            FileStream fs = new FileStream(@"..\..\Grupos\" + this.NombreGrupo + ".gru", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public uint maxMat()
        {
            uint nMatMax = 0;

            if (alumnos != null)
            {
                foreach (Alumno a in Alumnos)
                {
                    nMatMax = (a.NMat > nMatMax) ? a.NMat : nMatMax;
                }
            }

            return nMatMax;
        }

        public bool dniExiste(String dni)
        {
            bool existe = false;
            int c = 0;

            while (c < this.Alumnos.Count && !existe)
            {
                existe = (Alumnos[c].Dni.Equals(dni));
                c++;
            }

            return existe;
        }

        public void vaciar ()
        {
            if (Alumnos.Count > 0)
            {
                alumnos = new List<Alumno>();
            }
        }

        #endregion
    }
}
