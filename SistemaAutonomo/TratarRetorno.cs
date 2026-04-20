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
}