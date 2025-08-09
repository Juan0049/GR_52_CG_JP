using UnityEngine;
using System;

namespace packagePersona {

public class Estudiante : Persona
{
private string codeE;
private string nameCarreraE;

public Estudiante()
{
}

public Estudiante(string codeE, string nameCarreraE, string nameP, string mailP, string dirP)
: base(nameP, mailP, dirP)
{
    this.codeE = codeE;
    this.nameCarreraE = nameCarreraE;
}

public global::System.String CodeE { get => codeE; set => codeE = value; }
public global::System.String NameCarreraE { get => nameCarreraE; set => nameCarreraE = value; }

}

}