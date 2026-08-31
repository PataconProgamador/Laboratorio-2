namespace LibroCalificaciones_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            LibroCalificaciones miLibro = new LibroCalificaciones();
            Console.WriteLine("Porfavor ingrese el nombre del curso:");
            string nombreCurso = Console.ReadLine();
            Console.WriteLine();
            miLibro.MostrarMensaje(nombreCurso);
        }
    }
}
