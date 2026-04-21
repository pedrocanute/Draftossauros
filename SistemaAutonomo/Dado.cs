using System;
using System.Drawing;

public enum FaceDado
{
    AL,
    FL,
    PR,
    TI,
    VZ,
    WC
}

public class Dado
{
    FaceDado face;

    public FaceDado Face { get { return face; } set { face = value; } }

    public void DefinirFace(string sigla)
    {
        Face = (FaceDado)Enum.Parse(typeof(FaceDado), sigla);
    }

    public string ObterDescricao()
    {
        switch (Face)
        {
            case FaceDado.AL: return "Alimentação";
            case FaceDado.FL: return "Floresta";
            case FaceDado.PR: return "Pradaria";
            case FaceDado.TI: return "T-Rex";
            case FaceDado.VZ: return "Cercado Vazio";
            case FaceDado.WC: return "Banheiros";
            default: return "";
        }
    }

    public Image ObterImagem()
    {
        switch (Face)
        {
            case FaceDado.AL: return SistemaAutonomo.Properties.Resources.FaceAlimentacao;
            case FaceDado.FL: return SistemaAutonomo.Properties.Resources.FaceFloresta;
            case FaceDado.PR: return SistemaAutonomo.Properties.Resources.FacePradaria;
            case FaceDado.TI: return SistemaAutonomo.Properties.Resources.FaceTRex;
            case FaceDado.VZ: return SistemaAutonomo.Properties.Resources.FaceCercadoVazio;
            case FaceDado.WC: return SistemaAutonomo.Properties.Resources.FaceBanheiro;
            default: return null;
        }
    }
}
