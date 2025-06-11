using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    private Personagem personagem;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            int forca_atual = personagem.ForcaDoPersonagem() - colisao.gameObject.GetComponent<Ataque>().AtaqueDoInimigo();
           
            personagem.AtribuirForca(forca_atual);
           
            Debug.Log("O personagem " +personagem.NomeDoPersonagem()+" tem agora "+personagem.ForcaDoPersonagem());
        }
    }

    void Start()
    {
        personagem = GetComponent<Personagem>();
    }

  
    void Update()
    {
        
    }
    
    
}
