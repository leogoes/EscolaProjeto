using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string NomeAluno { get; set; }
        public string MatriculaAluno { get; set; }
        public DateTime DataMatricula { get; set; }
        public DateTime DataCancelamentoMatricula{ get; set; }
        public int IdEscola { get; set; }
        public virtual Escola Escola { get; set; }
        public bool HasEscola { get; set; }
    }
}
