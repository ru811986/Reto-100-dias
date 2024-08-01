using System;
using System.IO;
using System.Text;

namespace ejemplo008
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            int numPersonas = PedirNumPersonas();
            Persona[] personas = new Persona[numPersonas];
            try
            {
                StreamWriter sw = new StreamWriter($"E:\\Documentos\\Test.txt", false, Encoding.UTF8);
                for (int i = 0; i < personas.Length; i++)
                {
                    personas[i] = CrearPersona();
                    sw.Write(personas[i].Format());
                }
                sw.Close();
                foreach (Persona persona in personas)
                {
                    Console.WriteLine(persona.ToString());
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        private static int PedirNumPersonas()
        {
            Console.WriteLine("Introduzca el número de personas a registrar");
            return int.Parse(Console.ReadLine());
        }

        private static Persona CrearPersona()
        {
            Persona persona = new Persona();
            Console.WriteLine("Introduzca el nombre de la persona");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos de la persona");
            persona.Apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de nacimiento de la persona");
            persona.FechaNacimiento = Console.ReadLine();
            return persona;
        }
    }

    class Persona
    {
        private string nombre;
        private string apellidos;
        private string fechaNacimiento;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get {  return apellidos; } set {  apellidos = value; } }
        public string FechaNacimiento { get {  return fechaNacimiento; } set {  fechaNacimiento = value; } }

        public string Format()
        {
            return $"{this.Nombre},{this.Apellidos},{this.FechaNacimiento}\n";
        }

        public string ToString()
        {
            return $"DATOS PERSONALES\nNombre: {this.Nombre}\nApellidos: {this.Apellidos}\nFecha de nacimiento: {this.FechaNacimiento}";
        }
    }
}
