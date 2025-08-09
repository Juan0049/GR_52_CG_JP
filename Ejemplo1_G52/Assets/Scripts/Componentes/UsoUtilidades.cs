using UnityEngine;
using System.Collections.Generic;
using packageEstudiante;
using packagePuntos;

public class UsoUtilidades : MonoBehaviour
{
    public UsoEstudiante usoEstudiante;
    public UsoPuntos usoPuntos;

    void Start()
    {
        Utilidades.GuardarEstudiantesJSON(usoEstudiante.ListaE, "estudiantes.json");
        Utilidades.GuardarPuntosJSON(usoPuntos.listaPuntos, "puntos.json");
    }
}
