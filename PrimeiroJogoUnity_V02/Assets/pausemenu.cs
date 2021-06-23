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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
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
