using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string NomeEscola { get; set; }
        public int IdAluno { get; set; }
        public DateTime DataEntradaUltimoAluno { get; set; }
        public DateTime DataSaidaUltimoAluno { get; set; }
        public Aluno Aluno { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
        public bool HasAluno { get; set; }
    }
}
