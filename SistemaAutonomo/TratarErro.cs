using System.Windows.Forms;

public class TratarErro
{
    public static bool Verificar(string retorno)
    {
        if (retorno == "")
            return false;

        if (retorno.StartsWith("ERRO:"))
        {
            MessageBox.Show(retorno, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }
        return false;
    }
}