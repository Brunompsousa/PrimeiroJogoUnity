using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour
{
    public Text Nivel;
    public Transform[] spawnPoints;
    public GameObject enemy;

    public static int dificulty;

    public float timespawn = 5f;
    public float timeLvlUp = 15f;
    public float countdownSpawn;
    public float countdownLvl;

    // Start is called before the first frame update
    void Start()
    {
        dificulty = 1;
        spawnerfun();
        countdownSpawn = timespawn;
        countdownLvl = timeLvlUp;
    }

    // Update is called once per frame
    void Update()
    {

        if (countdownSpawn <= 0)
        {
            //Debug.Log("Spawner");
            spawnerfun();
            countdownSpawn = timespawn;
        }
        else
            countdownSpawn -= Time.deltaTime;

        if (countdownLvl <= 0)
        {
            //Debug.Log("Lvl up");
            lvlUpGame();
            Nivel.text = "Nivel " + dificulty;
            countdownLvl = timeLvlUp;
        }
        else
            countdownLvl -= Time.deltaTime;

    }

    void spawnerfun()
    {
        for(int i = 0; i<dificulty+1 ;i++)
        {
            int randspaw = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[randspaw].position, transform.rotation);
        }
    }

    void lvlUpGame()
    {
        //Debug.Log("dif up inside");
        dificulty += 1;
        if (timeLvlUp <= 60)
            timeLvlUp += 5;
    }
}
