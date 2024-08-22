using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto20
{
    internal class Libro
    {
        private string signatura;
        private string titulo;
        private string autor;

        public string Signatura { get { return signatura; } set { signatura = value; } }
        public string Titulo { get {  return titulo; } set {  titulo = value; } }
        public string Autor { get {  return autor; } set {  autor = value; } }

        private string Concatenar(string texto)
        {
            return texto.Replace(" ", "");
        }

        public string HallarSignatura()
        {
            string tituloUnido = Concatenar(this.Titulo).ToUpper();
            string autorUnido = Concatenar(this.Autor).ToUpper();
            string signatura = tituloUnido.Substring(0, 3) + " - " + autorUnido.Substring(0, 3);
            return signatura;
        }

        public string FormatearCadena()
        {
            return $"{this.Signatura};{this.Titulo};{this.Autor}";
        }
    }
}
