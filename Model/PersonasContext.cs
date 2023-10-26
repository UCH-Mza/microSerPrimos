using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model;

public partial class PersonasContext : DbContext
{
    public PersonasContext()
    {
    }

    public PersonasContext(DbContextOptions<PersonasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=host.docker.internal,8000;Initial Catalog=Personas; User ID=sa; Password=Chau45-99; MultipleActiveResultSets=true;Connection Timeout=30;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuId);

            entity.ToTable("Usuario");

            entity.Property(e => e.UsuId).HasColumnName("usuId");
            entity.Property(e => e.UsuCalve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuCalve");
            entity.Property(e => e.UsuName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuName");
            entity.Property(e => e.UsuUltimoIngreso)
                .HasColumnType("datetime")
                .HasColumnName("usuUltimoIngreso");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
