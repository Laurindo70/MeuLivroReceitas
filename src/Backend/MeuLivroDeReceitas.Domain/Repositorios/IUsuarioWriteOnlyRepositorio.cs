using MeuLivroDeReceitas.Domain.Entidades;
namespace MeuLivroDeReceitas.Domain.Repositorios;
public interface IUsuarioWriteOnlyRespositorio
{
    Task Adicionar(Usuario usuario);
}