using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameovermenu : MonoBehaviour
{
    public static bool Gamefim = false;

    public GameObject GOmenuUI;
    public ScoreBoard Sb;

    public Text Score;
    public Text TBname;

    public GameObject[] enemys;
    public GameObject[] bullets;

    

    public void Gameover()
    {
        if(Gamefim == false)
        {
            GOmenuUI.SetActive(true);
            Time.timeScale = 0f;
            //Debug.Log(Showscore.score.ToString());
            Score.text = "Pontuação: " + Showscore.score;
            Gamefim = true;
        }    
    }

    public void RRbutton()
    {

        //SceneManager.LoadScene("SampleScene");
        Time.timeScale = 0f;

        if (Gamefim == true)
        {
            if (TBname.text == null)
                TBname.text = "Noob";
            Sb.SaveScore(Showscore.score, TBname.text);

        }

        Gamefim = false;

        enemys = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemys)
            Destroy(enemy);

        bullets = GameObject.FindGameObjectsWithTag("bullet");
        foreach (GameObject bullet in bullets)
            Destroy(bullet);

        //MainmenuUI.Mainmenu = true;
    }


}
