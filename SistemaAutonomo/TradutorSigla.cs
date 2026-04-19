
using System.Collections.Generic;

public class TradutorSigla
{
    Dictionary<string, string> siglaDinosauro;
    Dictionary<string, string> siglaCercado;

    public TradutorSigla()
    {
        siglaDinosauro = new Dictionary<string, string>
        {
            {"Br", "Braquiossauro"},
            {"Ep", "Espinossauro"},
            {"Et", "Estegossauro"},
            {"Pa", "Parasaurolofo"},
            {"Ti", "Tiranossauro-Rex"},
            {"Tr", "Triceratopo"},
        };
        siglaCercado = new Dictionary<string, string>
        {

            {"FI", "Igualdade" },
            {"RS", "Rei da Selva"},
            {"MT", "Mata Tripla"},
            {"CD", "Diferença"},
            {"PA", "Amor"},
            {"IS", "Solitária"},
            {"RI", "Rio"},
        };
    }

    public string TraduzirSigla(string sigla)
    {
        if (siglaDinosauro.ContainsKey(sigla))
        {
            return siglaDinosauro[sigla];
        }
        
        if (siglaCercado.ContainsKey(sigla))
        {
            return siglaCercado[sigla];
        }

        return;
    }
}