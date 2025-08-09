using UnityEngine;
using System;


namespace packagePersona
{
    public class Persona
    {
        private string nameP;
        private string mailP;
        private string dirP;

        public Persona()
        {
        }

        public Persona(string nameP, string mailP, string dirP)
        {
            this.nameP = nameP;
            this.mailP = mailP;
            this.dirP = dirP;
        }
        
        public global::System.String NameP { get => nameP; set => nameP = value; }
        public global::System.String MailP { get => mailP; set => mailP = value; }
        public global::System.String DirP { get => dirP; set => dirP = value; }
    }
}