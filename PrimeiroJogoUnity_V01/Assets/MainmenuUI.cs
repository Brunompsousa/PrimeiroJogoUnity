using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuUI : MonoBehaviour
{

    public static bool Mainmenu = true;

    public GameObject MainUI;

    // Start is called before the first frame update
    void Start()
    {
            Time.timeScale = 0f;
            MainUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        MainUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
