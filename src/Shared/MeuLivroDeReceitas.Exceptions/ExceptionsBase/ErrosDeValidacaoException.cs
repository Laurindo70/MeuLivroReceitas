namespace MeuLivroDeReceitas.Exceptions.ExceptionsBase;

public class ErrosDeValidacaoException : MeuLivroDeReceitasException
{
    public List<string> MensagemDeErro { get; set; }

    public ErrosDeValidacaoException(List<string> mensagemDeErro)
    {
        MensagemDeErro = mensagemDeErro;
    }
}
