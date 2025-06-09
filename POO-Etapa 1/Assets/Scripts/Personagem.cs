using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private int idade;
    [ SerializeField ]
    private int forca;
    [ SerializeField ]
    private float velocidade;
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }
    public string NomeDoPersonagem()
    {
        return this.nome;
    }
    
    public void AtribuirIdade(int idade)
    {
        this.idade = idade;
    }
    public int IdadeDoPersonagem()
    {
        return this.idade;
    }
    
    public void AtribuirForca(int forca)
    {
        this.forca = forca;
    }
    public int ForcaDoPersonagem()
    {
        return this.idade;
    }
    
    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float VelocidadeDoPersonagem()
    {
        return this.velocidade;
    }
    
    public bool CompareForca( Personagem forca )
    {
        if (this.forca > forca.VelocidadeDoPersonagem())
        {
            return true;
        }
     
        return false;

    }
    
}
