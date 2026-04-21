public static class TratarRetorno
{
    public static string[] SepararLinha(string retorno)
    {
        retorno = retorno.Replace("\r", "");
        return retorno.Split('\n');
    }
    public static string[] SepararVirgula(string retorno)
    {
        retorno = retorno.Replace("\r", "");
        return retorno.Split(',');
    }

    public static string[] PegarCaracter(string retorno)
    {
        retorno = retorno.Replace("\r", "");
        retorno = retorno.Substring(0, retorno.Length - 1);
        return retorno.Split('\n');
    }
}