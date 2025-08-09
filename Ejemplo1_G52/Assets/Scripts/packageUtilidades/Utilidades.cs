using System.Collections.Generic;
using System.IO;
using UnityEngine;
using packageEstudiante;
using packagePuntos;

public static class Utilidades
{
    [System.Serializable]
    private class WrapperEstudiante
    {
        public List<Estudiante> estudiantes;
        public WrapperEstudiante(List<Estudiante> e) { estudiantes = e; }
    }

    [System.Serializable]
    private class WrapperPunto2D
    {
        public List<Punto2D> puntos;
        public WrapperPunto2D(List<Punto2D> p) { puntos = p; }
    }

    public static void GuardarEstudiantesJSON(List<Estudiante> estudiantes, string nombreArchivo)
    {
        string json = JsonUtility.ToJson(new WrapperEstudiante(estudiantes), true);
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        File.WriteAllText(ruta, json);
        Debug.Log("Estudiantes guardados en: " + ruta);
    }

    public static void GuardarPuntosJSON(List<Punto2D> puntos, string nombreArchivo)
    {
        string json = JsonUtility.ToJson(new WrapperPunto2D(puntos), true);
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        File.WriteAllText(ruta, json);
        Debug.Log("Puntos guardados en: " + ruta);
    }
}
