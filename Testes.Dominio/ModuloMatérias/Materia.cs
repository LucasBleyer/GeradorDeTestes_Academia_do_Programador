using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes.Dominio.Compartilhado;
using Testes.Dominio.ModuloQuestao;

namespace Testes.Dominio.ModuloMatérias
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }
        public DisciplinaEnum Disciplina { get; set; }
        public List<Questao> Questoes { get; set; }
        public string Serie { get; set; }

        public Materia()
        {
        }

        public override void Atualizar(Materia registro)
        {
            this.Nome = registro.Nome;
        }
    }
}
