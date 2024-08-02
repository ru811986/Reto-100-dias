using System;
using System.IO;
using System.Text;

namespace ejemplo009
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            Libro[] libros = { new Libro("El Quijote", "Miguel de Cervantes"), new Libro("Romeo y Julieta", "William Shakespeare") };
            StreamWriter sw1 = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\ejemplo009\\ejemplo009\\Ficheros CSV\\libros.csv", false, Encoding.UTF8);
            foreach (Libro libro in libros)
            {
                sw1.Write(libro.Format(';'));
            }
            sw1.Close();
            Usuario[] usuarios = { new Usuario("charlie91", "10_05_1991"), new Usuario("dario91", "05_10_1991") };
            StreamWriter sw2 = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\ejemplo009\\ejemplo009\\Ficheros CSV\\usuarios.csv", false, Encoding.UTF8);
            foreach (Usuario usuario in usuarios)
            {
                sw2.Write(usuario.Format(';'));
            }
            sw2.Close();
            Console.WriteLine("Introduzca el username");
            string username = Console.ReadLine();
            bool isUser = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Username == username)
                {
                    isUser = true;
                }
            }
            Console.WriteLine("Introduzca el título del libro a coger");
            string titulo = Console.ReadLine();
            Console.WriteLine("Introduzca el autor del libro a coger");
            string autor = Console.ReadLine();
            bool isBook = false;
            foreach (Libro libro in libros)
            {
                if (libro.Titulo == titulo && libro.Autor == autor)
                {
                    isBook = true;
                }
            }
            if (isUser && isBook)
            {
                StreamWriter swP = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\ejemplo009\\ejemplo009\\Ficheros CSV\\prestamos.csv", true, Encoding.UTF8);
                Prestamo prestamo = new Prestamo(username, titulo, autor, DateTime.Now.ToShortDateString(), DateTime.Now.AddMonths(1).ToShortDateString());
                swP.Write(prestamo.Format(';'));
                swP.Close();
            }
            StreamWriter swD = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\ejemplo009\\ejemplo009\\Ficheros CSV\\devoluciones.csv", true, Encoding.UTF8);
            Devolucion devolucion = new Devolucion(username, titulo, autor, DateTime.Now.AddMonths(1).ToShortDateString(), DateTime.Now.AddDays(38).ToShortDateString());
            swD.Write(devolucion.Format(';'));
            swD.Close();
        }
    }

    class Libro
    {
        private string titulo;
        private string autor;

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public string Format(char caracter)
        {
            return this.Titulo + caracter + this.Autor + "\n";
        }
    }

    class Usuario
    {
        private string username;
        private string password;

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get { return username; } }
        public string Password { get { return password; } }
        public string Format(char caracter)
        {
            return this.Username + caracter + this.Password + "\n";
        }
    }

    class Prestamo
    {
        private string username;
        private string titulo;
        private string autor;
        private string fechaPrestamo;
        private string fechaDevolucion;

        public Prestamo(string username, string titulo, string autor, string fechaPrestamo, string fechaDevolucion)
        {
            this.username = username;
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
        }

        public string Username { get { return username; } }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public string FechaPrestamo { get {  return fechaPrestamo; } }
        public string FechaDevolucion { get { return fechaDevolucion; } }
        public string Format(char caracter)
        {
            return this.Username + caracter + this.Titulo + caracter + this.Autor + caracter + this.FechaPrestamo + caracter + this.FechaDevolucion + "\n";
        }
    }

    class Devolucion
    {
        private string username;
        private string titulo;
        private string autor;
        private string fechaDevolucion;
        private string fechaExactaDevolucion;

        public Devolucion(string username, string titulo, string autor, string fechaDevolucion, string fechaExactaDevolucion)
        {
            this.username = username;
            this.titulo = titulo;
            this.autor = autor;
            this.fechaDevolucion = fechaDevolucion;
            this.fechaExactaDevolucion = fechaExactaDevolucion;
        }

        public string Username { get { return username; } }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public string FechaDevolucion { get { return fechaDevolucion; } }
        public string FechaExactaDevolucion { get { return fechaExactaDevolucion;} }
        public string Format(char caracter)
        {
            return this.Username + caracter + this.Titulo + caracter + this.Autor + caracter + this.FechaDevolucion + caracter + this.FechaExactaDevolucion + "\n";
        }
    }
}
