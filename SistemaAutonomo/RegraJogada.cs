public static class RegraJogada
{
    public static ValidarJogada Validar(Dado dado, Cercado cercado, Jogador jogadorLocal, Jogador jogadorComDado)
    {
        if (dado == null)
            return new ValidarJogada(false, "Dado inválido.");

        if (cercado == null)
            return new ValidarJogada(false, "Cercado inválido.");

        if (jogadorLocal == null)
            return new ValidarJogada(false, "Jogador inválido.");

        if (jogadorComDado == null)
            return new ValidarJogada(false, "Jogador do dado inválido.");

        if (jogadorLocal.IdJogador == jogadorComDado.IdJogador)
            return new ValidarJogada(true, "");

        switch (dado.Face)
        {
            case FaceDado.FL:
                if (cercado is CercadoAmor || cercado is CercadoSolitario || cercado is CercadoDiferenca)
                    return new ValidarJogada(false, "O dado sorteado é Floresta, você só pode jogar nos cercados Igualdade, Rei da Selva ou Mata Tripla.");
                break;

            case FaceDado.PR:
                if (cercado is CercadoIgualdade || cercado is CercadoMataTripla || cercado is CercadoReiFloresta)
                    return new ValidarJogada(false, "O dado sorteado é Pradaria, você só pode jogar nos cercados Amor, Solitária ou Diferença.");
                break;

            case FaceDado.WC:
                if (cercado is CercadoIgualdade || cercado is CercadoMataTripla || cercado is CercadoAmor)
                    return new ValidarJogada(false, "O dado sorteado é Banheiros, você só pode jogar nos cercados Rei da Selva, Solitária ou Diferença.");
                break;

            case FaceDado.AL:
                if (cercado is CercadoDiferenca || cercado is CercadoReiFloresta || cercado is CercadoSolitario)
                    return new ValidarJogada(false, "O dado sorteado é Alimentação, você só pode jogar nos cercados Igualdade, Mata Tripla ou Amor.");
                break;
        }

        return new ValidarJogada(true, "");
    }

}