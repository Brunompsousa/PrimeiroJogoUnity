using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int vida = 1;
    public int pontos = 10;

    public Transform target; //target a dar follow
    public float speed = 25f; //velocidade do bicho

    public GameObject deathEffect;
    public GameObject[] deathEffects;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void takeDamage(int dano) 
    {
        vida -= dano;

        if (transform.localScale.x > 1)
        {
            Vector3 change = new Vector3(1,1,1);
            transform.localScale -= change;
        }

        if (vida == 0)
        {
            morre();
        }
    }

    public void morre()
    {
        SoundManager.PlaySounddeadEnemy();
        Instantiate(deathEffect, transform.position,Quaternion.identity);
        Destroy(gameObject);
        Showscore.score += pontos;

        deathEffects = GameObject.FindGameObjectsWithTag("defect");
        foreach (GameObject defect in deathEffects)
            Destroy(defect, 0.4f);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    
}
