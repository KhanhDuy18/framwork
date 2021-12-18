using Courses_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.configurations
{
    public class ExerciseInUserConfiguration : IEntityTypeConfiguration<ExerciseInUser>
    {
        public void Configure(EntityTypeBuilder<ExerciseInUser> builder)
        {
            builder.ToTable("exerciseInUser"); 

            builder.HasKey(x => new { x.studentId, x.exerciseId });

            builder.Property(x => x.status).IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.submit).IsRequired()
                .HasColumnType("datetime");

            builder.Property(x => x.scores).IsRequired()
                .HasColumnType("float");

            builder.HasOne(x => x.Exercise)
                .WithMany(x => x.ExerciseInUsers)
                .HasForeignKey(x => x.exerciseId);

            builder.HasOne(x => x.AppUser)
                .WithMany(x => x.ExerciseInUsers)
                .HasForeignKey(x => x.studentId);
                
        }
    }
}
