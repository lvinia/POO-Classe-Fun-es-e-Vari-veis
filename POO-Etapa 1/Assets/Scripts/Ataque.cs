using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Assassino inimigo;
    private int ataqueNovo;

    public int AtaqueDoInimigo()
    {
        ataqueNovo = inimigo.NovoAtaque();
        return ataqueNovo;
    }
}
