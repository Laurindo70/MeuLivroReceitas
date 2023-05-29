namespace MeuLivroDeReceitas.Domain.Repositorios;
public interface IUsuarioReadOnlyRepositorio
{
    Task<bool> ExiteUsuarioComEmail(string email);
}