using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_3
{
    public class LibroCalificaciones
    {
        private string nombreDelCurso;

        public LibroCalificaciones(string nombre)
        {
            nombreDelCurso = nombre;
        }
        
        public string NombreCurso 
        {
            get { return nombreDelCurso;  }
            set { nombreDelCurso = value; }
        }
        public void MostrarMensaje()
        {
            Console.WriteLine($"Bienvenido al libro de calificaciones para \n{0}!", nombreDelCurso);
        }
    }
}
