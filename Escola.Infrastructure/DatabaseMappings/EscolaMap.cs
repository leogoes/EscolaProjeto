using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.Models;

namespace Escola.Infrastructure.DatabaseMappings
{
    public class EscolaMap : EntityTypeConfiguration<Domain.Models.Escola>
    {
        public EscolaMap()
        {
            HasKey(a => a.Id);

            ToTable("Escola");
            Property(e => e.Id).HasColumnName("Id_Escola").HasColumnType("int");
            Property(e => e.NomeEscola).HasColumnName("Nm_Escola").HasColumnType("varchar");
            Property(e => e.DataEntradaUltimoAluno).HasColumnName("Dt_Entrada").HasColumnType("datetime");
            Property(e => e.DataSaidaUltimoAluno).HasColumnName("Dt_Saida").HasColumnType("datetime"); ;
            Property(e => e.IdAluno).HasColumnName("Id_Aluno").HasColumnType("int"); ;
        }
    }
}
