using Escola.Domain.Interfaces;
using Escola.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Services
{
    public class ServiceBase<GenericEntity> : IDisposable, IServiceBase<GenericEntity> where GenericEntity : class
    {
        private readonly IBaseRepository<GenericEntity> _repository; 

        public void Adicionar(GenericEntity entity)
        {
            _repository.Adicionar(entity);
        }

        public void Alterar(GenericEntity entity)
        {
            _repository.Alterar(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<GenericEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public GenericEntity GetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public void Remover(GenericEntity entity)
        {
            _repository.Remover(entity);
        }
    }
}
