using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database
{
    public partial class MovieContext : DbContext
    {
        public MovieContext()
        {
        }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Endyear).HasColumnName("endyear");

                entity.Property(e => e.Genres)
                    .HasColumnName("genres")
                    .HasMaxLength(1000)
                    .IsFixedLength();

                entity.Property(e => e.Isadult).HasColumnName("isadult");

                entity.Property(e => e.Originaltitle)
                    .HasColumnName("originaltitle")
                    .HasMaxLength(1000)
                    .IsFixedLength();

                entity.Property(e => e.Primarytitle)
                    .HasColumnName("primarytitle")
                    .HasMaxLength(1000)
                    .IsFixedLength();

                entity.Property(e => e.Runtimeminutes).HasColumnName("runtimeminutes");

                entity.Property(e => e.Startyear).HasColumnName("startyear");

                entity.Property(e => e.Tconst)
                    .HasColumnName("tconst")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Titletype)
                    .HasColumnName("titletype")
                    .HasMaxLength(1000)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
