using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private int damage;

    void OnCollisionEnter2D(Collision2D collision)
    {

      damage = Random.Range( 10, 30 );
      PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
      
      if (playerHealth != null)
      {
          playerHealth.TakeDamage(damage);
      }
    }
}