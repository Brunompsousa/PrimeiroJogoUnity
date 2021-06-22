using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int vida = 1;
    public int pontos = 10;

    public Transform target; //target a dar follow
    public float speed = 25f; //velocidade do bicho

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void takeDamage(int dano) 
    {
        vida -= dano;

        if(vida == 0)
        {
            morre();
        }
    }

    public void morre()
    {
        Destroy(gameObject);
        Showscore.score += pontos;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    
}
