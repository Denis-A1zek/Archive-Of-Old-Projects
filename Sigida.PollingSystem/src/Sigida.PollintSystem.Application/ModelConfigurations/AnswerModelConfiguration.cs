using Microsoft.EntityFrameworkCore;
using Sigida.PollingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.PollingSystem.Application.ModelConfigurations
{
    internal class AnswerModelConfiguration : IEntityTypeConfiguration<PollAnswer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PollAnswer> builder)
        {
            builder.ToTable("Answers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(512);
            builder.Property(x => x.Votes);
            builder.Property(x => x.Percents);
        }
    }
}
