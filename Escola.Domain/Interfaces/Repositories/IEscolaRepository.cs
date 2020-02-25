using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces
{
    public interface IEscolaRepository : IBaseRepository<Domain.Models.Escola>
    {
        IEnumerable<Aluno> GetAlunos(int IdEscola);
    }
}
