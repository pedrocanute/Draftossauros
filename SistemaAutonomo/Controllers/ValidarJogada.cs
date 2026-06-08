public class ValidarJogada
{
    bool valido;
    string mensagem;
    public bool Valido { get { return valido; } set { valido = value; } }
    public string Mensagem { get { return mensagem; } set { mensagem = value; } }

    public ValidarJogada(bool valido, string mensagem)
    {
        this.Valido = valido;
        this.Mensagem = mensagem;
    }
}