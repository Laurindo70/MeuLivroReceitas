using MeuLivroDeReceitas.Domain.Entidades;
using MeuLivroDeReceitas.Domain.Repositorios;
using Microsoft.EntityFrameworkCore;
namespace MeuLivroDeReceitas.Infrastrucure.AcessoRepositorio.Repositorio;
public class UsuarioRepositorio : IUsuarioWriteOnlyRespositorio, IUsuarioReadOnlyRepositorio
{
    private readonly MeuLivroDeReceitasContext _contexto;
    public UsuarioRepositorio(MeuLivroDeReceitasContext contexto)
    {
        _contexto = contexto;
    }
    public async Task Adicionar(Usuario usuario)
    {
        await _contexto.Usuarios.AddAsync(usuario);
    }
    public async Task<bool> ExiteUsuarioComEmail(string email)
    {
        return await _contexto.Usuarios.AnyAsync(c => c.Email.Equals(email));
    }
}

