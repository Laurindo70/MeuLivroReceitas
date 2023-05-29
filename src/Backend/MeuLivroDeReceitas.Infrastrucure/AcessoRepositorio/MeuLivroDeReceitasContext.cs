using Microsoft.EntityFrameworkCore;
using MeuLivroDeReceitas.Domain.Entidades;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MeuLivroDeReceitas.Infrastrucure.AcessoRepositorio;
public class MeuLivroDeReceitasContext : DbContext
{
    public MeuLivroDeReceitasContext(DbContextOptions<MeuLivroDeReceitasContext> options)
        : base(options) { }
    public DbSet<Usuario> Usuarios { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuLivroDeReceitasContext).Assembly);
    }
}

