using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{

    public static bool Gpause = false;

    public GameObject PmenuUI;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("PAUSA" + MainmenuUI.Mainmenu);
        if (Input.GetKeyDown(KeyCode.Escape) && !gameovermenu.Gamefim && !MainmenuUI.Mainmenu)
        {
            Debug.Log("PAUSA" + gameovermenu.Gamefim);
            if(Gpause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        PmenuUI.SetActive(false);
        Time.timeScale = 1f;
        Gpause = false;
    }

    void Pause()
    {
        PmenuUI.SetActive(true);
        Time.timeScale = 0f;
        Gpause = true;
    }
}
