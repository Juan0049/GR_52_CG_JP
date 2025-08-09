using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using packageEstudiante;

public class UsoEstudiante : MonoBehaviour
{
    public List<Estudiante> ListaE = new List<Estudiante>();


    public InputField inputCodigo;
    public InputField inputCarrera;
    public InputField inputNombre;
    public InputField inputCorreo;
    public InputField inputDireccion;

    void Start()
    {
        Estudiante e1 = new Estudiante("Juan Pablo", "2025_03", "Ing multimedia", "juan_pablo.alba@uao.edu.co", "carre 34");
        Estudiante e2 = new Estudiante("Maria Perez", "2023_03", "Ing Ambiental", "maria_perez.@uao.edu.co", "calle 14");

        ListaE.Add(e1);
        ListaE.Add(e2);

        foreach (var est in ListaE)
        {
            Debug.Log("Nombre: " + est.Nombre + ", Carrera: " + est.Carrera);
        }
    }

    public void AgregarEstudiante()
    {
        Estudiante nuevo = new Estudiante(
            inputNombre.text,
            inputCodigo.text,
            inputCarrera.text,
            inputCorreo.text,
            inputDireccion.text
        );

        ListaE.Add(nuevo);

        Debug.Log("Nuevo estudiante agregado: " + nuevo.Nombre + " (" + nuevo.Carrera + ")");
    }
}
