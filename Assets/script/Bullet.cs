using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public string enemyTag;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.tag == enemyTag)
        {
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
}    
        
    
