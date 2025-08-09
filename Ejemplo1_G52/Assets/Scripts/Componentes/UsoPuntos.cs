using UnityEngine;
using System.Collections.Generic;
using packagePuntos;

public class UsoPuntos : MonoBehaviour
{
    public List<Punto2D> listaPuntos = new List<Punto2D>();

    void Start()
    {
        listaPuntos.Add(new Punto2D(1, 2));
        listaPuntos.Add(new Punto2D(3, 4));
        listaPuntos.Add(new Punto2D(5, 6));

        foreach(var p in listaPuntos)
        {
            Debug.Log($"Punto: ({p.X}, {p.Y})");
        }
    }
}
