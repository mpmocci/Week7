using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Paola_Mocci.Entities
{
    public class Studente : Persona
    {
        public int IdStudente { get; set; }
        public Classe Classe { get; set; }
        public List<Interrogazione> Interrogazioni { get; set; } = new List<Interrogazione>();

        public Studente()
        {

        }

        public Studente(int id, string nome, string cognome, string classe)
        {
            IdStudente = id;
            Nome = nome;
            Cognome = cognome;
            Classe.IdClasse = classe;

            }

    }
}
