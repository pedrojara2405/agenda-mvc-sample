using Agenda.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Agenda.DataAccess
{
    public class RepositorioPersona
    {
        public static List<Persona> Data = new List<Persona>
        {
            new Persona{ Id=1, Nombre="Pedro Jara", Numero="1234567891"},
            new Persona{ Id=2, Nombre="Gary Velasquex", Numero="1234567892"},
            new Persona{ Id=3, Nombre="Franklin Prado", Numero="1234567893"},
            new Persona{ Id=4, Nombre="Miguel Condori", Numero="1234567894"},
            new Persona{ Id=5, Nombre="Felipe Pacora", Numero="1234567895"}
        };

        public Persona ObtienePersona(int id)
        {
            return Data.FirstOrDefault(persona => persona.Id == id);
        }

        public void InsertaPersona(Persona persona)
        {
            int nextId = Data.Count + 1;
            persona.Id = nextId;
            Data.Add(persona);
        }


    }
}
