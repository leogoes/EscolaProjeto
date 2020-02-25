using Escola.Infrastructure.DatabaseMappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infrastructure.Contexto
{
    public class EscolaContext : DbContext, IDisposable
    {
        public EscolaContext()
            :base("EscolaContext")
        {

        }

        public DbSet<Escola.Domain.Models.Escola> Escolas { get; set; }
        public DbSet<Escola.Domain.Models.Aluno> Alunos { get; set; }


        public bool LazyLoading
        {
            get
            {
                return this.Configuration.LazyLoadingEnabled;
            }
            set
            {
                this.Configuration.LazyLoadingEnabled = value;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EscolaMap());
            modelBuilder.Configurations.Add(new AlunoMap());
        }
    }
}
