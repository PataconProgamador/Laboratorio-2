namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            LibroCalificaciones mylibro = new LibroCalificaciones("CS101 Programación en C#");
            LibroCalificaciones mylibro2 = new LibroCalificaciones("CS102 Estructuras de Datos");
            Console.WriteLine("El Nombre del Curso es: {0}", mylibro.NombreCurso);
            Console.WriteLine("El Nombre del Curso es: {0}", mylibro2.NombreCurso);


            //Pide y lee el nombre del curso
            Console.WriteLine("\n Escriba el nombre del curso: ");
            string elNombrecurso = Console.ReadLine();
            mylibro.NombreCurso = elNombrecurso;
            Console.WriteLine("\n El nombre del curso es: {0}", mylibro.NombreCurso);
        }
    }
}
