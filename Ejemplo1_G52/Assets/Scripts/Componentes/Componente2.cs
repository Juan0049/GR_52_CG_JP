using UnityEngine;
using System.Collections.Generic;
using packagePuntos;

public class Componente2 : MonoBehaviour
{
    public List<Punto2D> puntos = new List<Punto2D>();

    private void Start() 
    {
        puntos.Add(new Punto2D(1.0, 2.0));
        puntos.Add(new Punto2D(3.0, 4.0));
        puntos.Add(new Punto2D(5.0, 6.0));

        foreach (var punto in puntos)
        {
            Debug.Log($"Punto: ({punto.X}, {punto.Y})");
        }
    }
}
