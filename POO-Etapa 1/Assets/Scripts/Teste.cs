using UnityEngine;

public class Teste : MonoBehaviour
{
    Personagem Assassino;
    Assassino Classe;
    void Start()
    {
        Assassino = new Personagem();
        Classe = new Assassino();
        
        
        Assassino.AtribuirNome("Assassino");
        Assassino.AtribuirIdade(30);
        Assassino.AtribuirForca(50);
        Assassino.AtribuirVelocidade(15f);
        
        Debug.Log("O "+ Assassino.NomeDoPersonagem() + " tem " + Assassino.IdadeDoPersonagem() + " anos e " 
                  + Assassino.ForcaDoPersonagem() +  " de força com velocidade igual à " + Assassino.VelocidadeDoPersonagem() );
        
        Classe.AtribuirAtaque(10);
        
        Debug.Log("O "+ Assassino.NomeDoPersonagem() + " tem " +Classe.AtaqueDoAssassino() + " de ataque" );
    }
}
