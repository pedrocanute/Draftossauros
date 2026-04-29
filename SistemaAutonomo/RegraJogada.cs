public static class RegraJogada
{
    public static ValidarJogada Validar(
        Dado dado,
        Cercado cercado,
        Dinossauro dinossauro,
        Jogador jogadorQueVaiJogar,
        Jogador jogadorComDado
    )
    {
        if (dado == null)
            return new ValidarJogada(false, "Dado inválido.");

        if (cercado == null)
            return new ValidarJogada(false, "Cercado inválido.");

        if (dinossauro == null)
            return new ValidarJogada(false, "Dinossauro inválido.");

        if (jogadorQueVaiJogar == null)
            return new ValidarJogada(false, "Jogador inválido.");

        if (jogadorComDado == null)
            return new ValidarJogada(false, "Jogador do dado inválido.");

        ValidarJogada regraCercado = ValidarRegraDoCercado(cercado, dinossauro);

        if (!regraCercado.Valido)
            return regraCercado;

        // Quem lançou o dado não precisa obedecer à restrição do dado.
        if (jogadorQueVaiJogar.IdJogador == jogadorComDado.IdJogador)
            return new ValidarJogada(true, "");

        return ValidarRegraDoDado(dado, cercado);
    }

    private static ValidarJogada ValidarRegraDoDado(Dado dado, Cercado cercado)
    {
        switch (dado.Face)
        {
            case FaceDado.FL:
                if (cercado is CercadoAmor || cercado is CercadoSolitario || cercado is CercadoDiferenca)
                    return new ValidarJogada(false, "Dado Floresta: jogue em Igualdade, Rei da Selva ou Mata Tripla.");
                break;

            case FaceDado.PR:
                if (cercado is CercadoIgualdade || cercado is CercadoMataTripla || cercado is CercadoReiFloresta)
                    return new ValidarJogada(false, "Dado Pradaria: jogue em Amor, Solitária ou Diferença.");
                break;

            case FaceDado.WC:
                if (cercado is CercadoIgualdade || cercado is CercadoMataTripla || cercado is CercadoAmor)
                    return new ValidarJogada(false, "Dado Banheiros: jogue em Rei da Selva, Solitária ou Diferença.");
                break;

            case FaceDado.AL:
                if (cercado is CercadoDiferenca || cercado is CercadoReiFloresta || cercado is CercadoSolitario)
                    return new ValidarJogada(false, "Dado Alimentação: jogue em Igualdade, Mata Tripla ou Amor.");
                break;

            case FaceDado.VZ:
                if (cercado.Dinossauros.Count > 0)
                    return new ValidarJogada(false, "Dado Cercado Vazio: jogue em um cercado vazio.");
                break;

            case FaceDado.TI:
                foreach (Dinossauro dino in cercado.Dinossauros)
                {
                    if (dino is TiranossauroRex)
                        return new ValidarJogada(false, "Dado T-Rex: jogue em um cercado sem T-Rex.");
                }
                break;
        }

        return new ValidarJogada(true, "");
    }

    private static ValidarJogada ValidarRegraDoCercado(Cercado cercado, Dinossauro dinossauro)
    {
        if (cercado is Rio)
            return new ValidarJogada(true, "");

        if (cercado is CercadoIgualdade)
        {
            foreach (Dinossauro dino in cercado.Dinossauros)
            {
                if (dino.Sigla != dinossauro.Sigla)
                    return new ValidarJogada(false, "Floresta da Igualdade só aceita dinossauros da mesma espécie.");
            }

            if (cercado.Dinossauros.Count >= 6)
                return new ValidarJogada(false, "Floresta da Igualdade já está cheia.");
        }

        if (cercado is CercadoDiferenca)
        {
            foreach (Dinossauro dino in cercado.Dinossauros)
            {
                if (dino.Sigla == dinossauro.Sigla)
                    return new ValidarJogada(false, "Campina da Diferença só aceita espécies diferentes.");
            }

            if (cercado.Dinossauros.Count >= 6)
                return new ValidarJogada(false, "Campina da Diferença já está cheia.");
        }

        if (cercado is CercadoMataTripla)
        {
            if (cercado.Dinossauros.Count >= 3)
                return new ValidarJogada(false, "Mata Tripla só aceita até 3 dinossauros.");
        }

        if (cercado is CercadoReiFloresta || cercado is CercadoSolitario)
        {
            if (cercado.Dinossauros.Count >= 1)
                return new ValidarJogada(false, "Esse cercado só aceita 1 dinossauro.");
        }

        return new ValidarJogada(true, "");
    }
}