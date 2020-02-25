using Escola.Domain.Models;
using Escola.Infrastructure.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infrastructure.Repository
{
    public class EscolaRepository : BaseRepository<Domain.Models.Escola>, Domain.Interfaces.IEscolaRepository
    {
        public IEnumerable<Aluno> GetAlunos(int IdEscola)
        {
            try
            {
                using (var ctx = new EscolaContext())
                {
                    return ctx.Alunos
                        .Where(e => e.IdEscola == IdEscola)
                        .Include(e => e.Escola);
                }
            }
            catch (DbUpdateException duEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(duEx.ToString()));
            }
            catch (DbEntityValidationException dEx)
            {
                throw new Exception("Erro ao executar comando no Entity", new Exception(dEx.ToString()));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando no Entity", ex);
            }


        }
    }
}
