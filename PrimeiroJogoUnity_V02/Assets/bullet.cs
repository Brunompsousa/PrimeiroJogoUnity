using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy target = hitInfo.GetComponent<Enemy>();

        if(target != null)
        {
            target.takeDamage(1);
        }
        Destroy(gameObject);
    }
}
