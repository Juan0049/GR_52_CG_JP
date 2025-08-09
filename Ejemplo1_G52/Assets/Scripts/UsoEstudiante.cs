using UnityEngine;
using System;
using packagePersona;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class UsoEstudiante : MonoBehaviour
{
    List<Estudiante> ListaE=new List<Estudiante>();

    public InputField inputCodigo;
    public InputField inputCarrera;
    public InputField inputNombre;
    public InputField inputCorreo;
    public InputField inputDireccion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Estudiante e1= new Estudiante("2025_03", "Ing multimedia", "Juan Pablo", "juan_pablo.alba@uao.edu.co", 
       "carre 34"); 
       Estudiante e2 = new Estudiante("2023_03", "Ing Ambiental", "Maria Perez", "maria_perez.@uao.edu.co",
       "calle 14");

       ListaE.Add(e1);
       ListaE.Add(e2);

       for(int i = 0; i < ListaE.Count; i++)
       {
        Debug.Log("name "+ListaE[i].NameP + "Carrera"+ListaE[i].NameCarreraE);
       }
    }

    public void AgregarEstudiante()
    {
        Estudiante nuevo = new Estudiante(
            inputCodigo.text,
            inputCarrera.text,
            inputNombre.text,
            inputCorreo.text,
            inputDireccion.text
        );

        ListaE.Add(nuevo);

        Debug.Log("Nuevo estudiante agregado: " + nuevo.NameP + " (" + nuevo.NameCarreraE + ")");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
