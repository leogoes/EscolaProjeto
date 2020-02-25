using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infrastructure.DatabaseMappings
{
    public class AlunoMap : EntityTypeConfiguration<Domain.Models.Aluno>
    {
        public AlunoMap()
        {
            HasKey(a => a.Id);

            ToTable("Aluno");
            Property(a => a.Id).HasColumnName("Id_Aluno").HasColumnType("int");
            Property(a => a.MatriculaAluno).HasColumnName("Cd_Matricula").HasColumnType("varchar").HasMaxLength(22);
            Property(a => a.NomeAluno).HasColumnName("Nm_Aluno").HasColumnType("varchar");
            Property(a => a.IdEscola).HasColumnName("Id_Escola").HasColumnType("int");
            Property(a => a.DataMatricula).HasColumnName("Dt_Matricula").HasColumnType("datetime");
            Property(a => a.DataCancelamentoMatricula).HasColumnName("Dt_Cancelamento").HasColumnType("datetime");
            Property(a => a.HasEscola).HasColumnName("Bt_HasEscola").HasColumnType("bit");

            HasRequired(e => e.Escola)
                .WithMany(a => a.Alunos)
                .HasForeignKey(e => e.IdEscola);
        }
    }
}
