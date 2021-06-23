using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject enemy;

    public static int dificulty = 2;

    public float timespawn = 5f;
    public float countdown;
    
    // Start is called before the first frame update
    void Start()
    {
        dificulty = 2;
        spawnerfun();
        countdown = timespawn;
    }

    // Update is called once per frame
    void Update()
    {

        if (countdown <= 0)
        {
            spawnerfun();
            countdown = timespawn;
        }
        else
        {
            countdown -= Time.deltaTime;
        }

    }

    void spawnerfun()
    {

        for(int i = 0; i<dificulty ;i++)
        {
            int randspaw = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[randspaw].position, transform.rotation);
        }
        
    }

    public void difUp(int dif)
    {
        dificulty = dif;
    }
}
