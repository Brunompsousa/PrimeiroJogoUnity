using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameovermenu : MonoBehaviour
{
    public static bool Gamefim = false;

    public GameObject GOmenuUI;

    public void Gameover()
    {
        if(Gamefim == false)
        {
            GOmenuUI.SetActive(true);
            Time.timeScale = 0f;
            Gamefim = true;
        }    
    }

    public void RRbutton()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        Gamefim = false;
    }

}
