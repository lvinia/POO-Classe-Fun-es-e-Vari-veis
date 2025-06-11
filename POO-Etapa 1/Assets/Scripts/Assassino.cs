using UnityEngine;

public class Assassino : Personagem
{
    [ SerializeField ]
    public int ataque;
    
    public enum FormaDeAtaque
    {
        ADAGAS, VENENO
    }
    [ SerializeField ]
    private FormaDeAtaque formaDeAtaque;
    
    public void AtribuirFormaDeAtaque(FormaDeAtaque formaDeAtaque)
    {
        this.formaDeAtaque = formaDeAtaque;
    }

    public FormaDeAtaque TipoDeAtaque()
    {
        return this.formaDeAtaque;
    }
    public void AtribuirAtaque(int ataque)
    {
        this.ataque = ataque;
    }
    public int AtaqueDoAssassino()
    {
        return this.ataque;
    }
    
    public int NovoAtaque()
    {

        int dano = 0;

        switch (formaDeAtaque)
        {
            case FormaDeAtaque.ADAGAS:
                dano = AtaqueDoAssassino() + 10;
                break;
            case FormaDeAtaque.VENENO:
                dano = AtaqueDoAssassino() + 25;
                break;
            
        }

        return dano;
    }
    
}
