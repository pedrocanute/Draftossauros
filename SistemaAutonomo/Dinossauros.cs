using System;

public class Dinossauros
{
    public string SiglaNome { get; set; }

    public Dinossauros(string siglaNome)
    {
        if (string.IsNullOrWhiteSpace(siglaNome))
            throw new ArgumentException("A sigla do dinossauro é obrigatória.", nameof(siglaNome));

        SiglaNome = siglaNome;
    }
}
