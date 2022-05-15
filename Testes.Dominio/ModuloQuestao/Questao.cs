using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes.Dominio.Compartilhado;
using Testes.Dominio.ModuloMatérias;

namespace Testes.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Materia Materia { get; set; }
        public DisciplinaEnum Disciplina { get; set; }
        public string Titulo { get; set; }
        public string Enunciado { get; set; }
        public List<string> Alternativas { get; set; }
        public string Gabarito { get; set; }

        public override void Atualizar(Questao registro)
        {
            this.Materia = registro.Materia;
            this.Enunciado = registro.Enunciado;
            this.Alternativas = registro.Alternativas;
            this.Gabarito = registro.Gabarito;
        }
    }
}
