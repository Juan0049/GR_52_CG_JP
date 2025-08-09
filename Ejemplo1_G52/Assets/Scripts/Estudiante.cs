using System;

namespace packageEstudiante
{
    [Serializable]
    public class Estudiante
    {
        public string Nombre;
        public string Codigo;
        public string Carrera;
        public string Correo;
        public string Direccion;

        public Estudiante() { }

        public Estudiante(string nombre, string codigo, string carrera, string correo, string direccion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Carrera = carrera;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
