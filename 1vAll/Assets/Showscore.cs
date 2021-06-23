using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Showscore : MonoBehaviour
{

    public Text myscore;
    public static int score;
    public Text lvl;


    // Start is called before the first frame update
    void Start()
    {
        //Mete o score a 0 quando iniciamos o jogo
        score = 0;
        //Mete o texto na UI 
        lvl.text = "Nivel 1";
    }

    // Update is called once per frame
    void Update()
    {
        //Está sempre a atualizar o score 
        myscore.text = score.ToString();

        //Antigo sistema de avançar na dificuldade/nivel que era por pontos
        /*float.TryParse(myscore.text, out float scr);

        float res =  Mathf.Round(scr / 100);

        //Debug.Log("lvl");
        if(res >= 2)
            lvl.text = "Nivel " + res;

        if (res >= 3)
            spawn.dificulty = (int)res;*/
    }
}
