using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

  public int maxHealth = 100; // Vida máxima do jogador
  private int currentHealth; // Vida atual do jogador

  //public GameObject damageTaken = GameObject.Find("DamageTaken"); // Encontrar o objeto DamageTaken na Scene
  public TextMeshProUGUI takenDamageTxt, currentHealthTxt;

  void Start()
  {
      currentHealth = maxHealth; // Inicializa a vida atual como a vida máxima
      
      takenDamageTxt = GameObject.Find("Canvas/DamageTaken").GetComponent<TextMeshProUGUI>(); // Pega o componente TextMesh do objeto
      currentHealthTxt = GameObject.Find("Canvas/CurrentHealth").GetComponent<TextMeshProUGUI>(); // Pega o componente TextMesh do objeto

      takenDamageTxt.text = ""; // Inicializa o campo de texto vazio
      currentHealthTxt.text = maxHealth.ToString(); // Inicializa o campo de texto vazio
  }

  public void TakeDamage(int damageAmount)
  {
      currentHealth -= damageAmount; // Diminui a vida atual pelo dano recebido
      takenDamageTxt.text = "-" + damageAmount.ToString(); // Dano mostrado na tela
      currentHealthTxt.text = currentHealth.ToString(); // Update da vida atual na tela

      if (currentHealth <= 0)
      {
          Die();
      }
  }

 public void Die() // O jogador morreu, faça aqui o que for necessário
  {
    
    gameObject.SetActive(false);
  }
}