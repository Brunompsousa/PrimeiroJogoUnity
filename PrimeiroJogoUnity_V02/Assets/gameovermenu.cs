using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameovermenu : MonoBehaviour
{
    public static bool Gamefim = false;

    public GameObject GOmenuUI;

    public Text Score;

    public void Gameover()
    {
        if(Gamefim == false)
        {
            GOmenuUI.SetActive(true);
            Time.timeScale = 0f;
            //Debug.Log(Showscore.score.ToString());
            Score.text = "Pontua��o: " + Showscore.score;
            Gamefim = true;
        }    
    }

    public void RRbutton()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        Gamefim = false;
        MainmenuUI.Mainmenu = true;
    }

}
