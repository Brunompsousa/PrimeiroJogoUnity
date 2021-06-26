using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour
{
    public Text Nivel;              //Ligacao para o texto onde escrevemos o nivel no UI
    public Transform[] spawnPoints; //Array para guardar todos os pontos em que os inimigos podem aparecer
    public GameObject[] enemy;        //Objecto do tipo inimigo para que possamos inicializar os inimigos em jogo

    public static int dificulty;    //Variavel para a dificuldade, static para podermos acessar de outras classes

    public float timespawn = 5f;    //Tempo de intervalo que demora a aparecer os inimigos de cada wave
    public float timeLvlUp = 15f;   //Tempo inicial para o primeiro nivel
    public float countdownSpawn;    //Contagem do tempo para o aparecimento dos inimigo
    public float countdownLvl;      //Contagem para a mudança de nivel/dificuldade

    int randspaw, randEnem;

    // Start is called before the first frame update
    void Start()
    {
        dificulty = 1;
        countdownSpawn = timespawn;
        countdownLvl = timeLvlUp;
        //spawnerfun();
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
        if(dificulty < 3)
        {
            spawnenemis(1);
        }
        else
        {
            spawnenemis(0);
        }
    }

    void lvlUpGame()
    {
        //Debug.Log("dif up inside");
        dificulty += 1;
        if (timeLvlUp <= 60)
            timeLvlUp += 5;
    }

    public void rrTimers()
    {
        dificulty = 1;
        Nivel.text = "Nivel " + dificulty;
        countdownSpawn = timespawn;
        countdownLvl = timeLvlUp;
        spawnerfun();
    }

    public void spawnenemis(int dif)
    {
        for (int i = 0; i < dificulty + 1; i++)
        {
            randspaw = Random.Range(0, spawnPoints.Length);
            randEnem = Random.Range(0, enemy.Length - dif);
            Instantiate(enemy[randEnem], spawnPoints[randspaw].position, transform.rotation);
        }
    }

}
