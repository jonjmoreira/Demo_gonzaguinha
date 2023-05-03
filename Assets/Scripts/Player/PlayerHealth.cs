using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Vida máxima do jogador
    private int currentHealth; // Vida atual do jogador

    void Start()
    {
        currentHealth = maxHealth; // Inicializa a vida atual como a vida máxima
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Diminui a vida atual pelo dano recebido

        if (currentHealth <= 0)
        {
            Die();
        }
    }

 public void Die()
{
    gameObject.SetActive(false);
}  // O jogador morreu, faça aqui o que for necessário
    }   

