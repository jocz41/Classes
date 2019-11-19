/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario II. Más funciones.
* FECHA de ENTREGA.....: 25 de Enero de 2018
*/

using System;

namespace Practica9
{
    [Serializable]

    class Alumno : IComparable
    {
        #region Atributos

        private static uint contMat = 0;
        private uint nMat;
        private string dni, nombre;
        private int[] notas;

        #endregion

        public Alumno(string dni, string nombre, int[] notas)
        {
            nMat = ++contMat;
            this.dni = dni;
            this.nombre = nombre;
            this.notas = new int[notas.Length];
            Array.Copy(notas, this.notas, notas.Length);
        }

        #region Propiedades

        public uint ContMat
        {
            set => contMat = value;
        }

        public uint NMat
        {
            get => nMat;
        }

        public string Nombre
        {
            get => nombre;
        }

        public int[] Notas
        {
            get => notas;
        }

        public string Dni
        {
            get => dni;
        }

        #endregion

        #region Métodos

        public float mediaAlumno()
        {
            float media = 0;

            foreach (float n in notas)
            {
                media += n;
            }

            return (float) Math.Round((media / notas.Length), 1);
        }

        public byte numSusAlumno()
        {
            int c = 0;

            foreach (int n in notas)
            {
                if (n < 5)
                    c++;
            }

            return Convert.ToByte(c);
        }

        #endregion

        public int CompareTo(object o)
        {
            Alumno b = (Alumno)o;

            return this.Nombre.CompareTo(b.Nombre);
        }
    }
}
