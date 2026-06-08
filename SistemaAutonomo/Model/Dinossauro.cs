using System.Drawing;

public abstract class Dinossauro
{
    string sigla;
    string nomeDinossauro;
    string cor;
    Image imagemDinossauro;

    public string Sigla { get { return sigla; } set { sigla = value; } }

    public string NomeDinossauro { get { return nomeDinossauro; } set { nomeDinossauro = value; } }
 
    public string Cor { get { return cor; } set { cor = value; } }

    public Image ImagemDinossauro { get { return  imagemDinossauro; } set {  imagemDinossauro = value; } }

    public Dinossauro(string sigla, string nomeDinossauro, string cor, Image imagemDinossauro)
    {
        this.Sigla = sigla;
        this.NomeDinossauro = nomeDinossauro;
        this.Cor = cor;
        this.ImagemDinossauro= imagemDinossauro;
    }
}

public class Braquiossauro : Dinossauro
{
    public Braquiossauro() : base("Br", "Braquiossauro", "Roxo", SistemaAutonomo.Properties.Resources.Braquiossauro) { }
}

public class Espinossauro : Dinossauro
{
    public Espinossauro() : base("Ep", "Espinossauro", "Laranja", SistemaAutonomo.Properties.Resources.Espinossauro) { }
}

public class Estegossauro : Dinossauro
{
    public Estegossauro() : base("Et", "Estegossauro", "Azul", SistemaAutonomo.Properties.Resources.Estegossauro) { }
}

public class Parasaurolofo : Dinossauro
{
    public Parasaurolofo() : base("Pa", "Parasaurolofo", "Verde", SistemaAutonomo.Properties.Resources.Parasaurolofo) { }
}

public class TiranossauroRex : Dinossauro
{
    public TiranossauroRex() : base("Ti", "Tiranossauro-Rex", "Vermelho", SistemaAutonomo.Properties.Resources.Tiranossauro_Rex) { }
}
public class Triceratops : Dinossauro
{
    public Triceratops() : base("Tr", "Triceratops", "Amarelo", SistemaAutonomo.Properties.Resources.Triceratops) { }
}