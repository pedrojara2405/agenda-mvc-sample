using Agenda.DataAccess;
using Agenda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Logic
{
    public class LogicaPersonas
    {
        private RepositorioPersona _repositorioPersonas;

        public LogicaPersonas()
        {
            _repositorioPersonas = new RepositorioPersona();
        }

        public Persona ObtienePersona(int id)
        {
            return _repositorioPersonas.ObtienePersona(id);
        }

        public void InsertaPersona(Persona persona)
        {
            _repositorioPersonas.InsertaPersona(persona);
        }

    }
}
