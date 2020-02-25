using Escola.Domain.Interfaces;
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
    public class BaseRepository<GenericEntity> :  IDisposable, IBaseRepository<GenericEntity> where GenericEntity : class
    {

        public void Adicionar(GenericEntity entity)
        {
            try
            {
                using(var ctx = new EscolaContext())
                {
                    ctx.Set<GenericEntity>().Add(entity);
                    ctx.SaveChanges();
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

        public void Remover(GenericEntity entity)
        {
            try
            {
                using (var ctx = new EscolaContext())
                {
                    ctx.Set<GenericEntity>().Remove(entity);
                    ctx.SaveChanges();
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
        public void Alterar(GenericEntity entity)
        {
            try
            {
                using (var ctx = new EscolaContext())
                {
                    ctx.Entry(entity).State = EntityState.Modified;
                    ctx.SaveChanges();
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

        public IEnumerable<GenericEntity> GetAll()
        {
            try
            {
                using (var ctx = new EscolaContext())
                {
                    ctx.LazyLoading = false;
                    return ctx.Set<GenericEntity>().ToList();
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

        public GenericEntity GetById(int Id)
        {
            try
            {
                using (var ctx = new EscolaContext())
                {
                    ctx.LazyLoading = false;

                    return ctx.Set<GenericEntity>().Find(Id);
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
