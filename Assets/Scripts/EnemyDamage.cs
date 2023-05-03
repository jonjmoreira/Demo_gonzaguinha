using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;

    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth PlayerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        
        if (PlayerHealth != null)
        {
            PlayerHealth.TakeDamage(damage);
        }
    }
}