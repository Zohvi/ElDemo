using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace testi13._12.Models {
         
    public partial class EläimiäContext : DbContext
    { 
    
    public EläimiäContext()
    {
    }

    public EläimiäContext(DbContextOptions<EläimiäContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Eläinlääkärit> Eläinlääkärit { get; set; }
    public virtual DbSet<Omistajat> Omistajat { get; set; }
    public virtual DbSet<Potilastiedot> Potilastiedot { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Eläimiä;Trusted_Connection=True;");
        }
    }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eläinlääkärit>(entity =>
            {
               entity.HasKey(e => e.Ideläinlääkäri);

                entity.Property(e => e.Ideläinlääkäri)
                    .HasColumnName("IDEläinlääkäri")
                    .ValueGeneratedNever();

                entity.Property(e => e.Etunimi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Osoite)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Puhelinnumero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sukunimi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Omistajat>(entity =>
            {
                entity.HasKey(e => e.Idomistaja);

                entity.Property(e => e.Idomistaja)
                    .HasColumnName("IDOmistaja")
                    .ValueGeneratedNever();

                entity.Property(e => e.Etunimi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Osoite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Puhelinnumero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sukunimi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Potilastiedot>(entity =>
            {
                entity.HasKey(e => e.Idasiakas);

                entity.Property(e => e.Idasiakas)
                    .HasColumnName("IDAsiakas")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ideläinlääkäri).HasColumnName("IDEläinlääkäri");

                entity.Property(e => e.Idomistaja).HasColumnName("IDOmistaja");

                entity.Property(e => e.Laji)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nimi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rotu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

            });


        }
    }

}






