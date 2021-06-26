using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuUI : MonoBehaviour
{

    public static bool Mainmenu = true;

    public GameObject MainUI;
    public GameObject ScoreB;

    public GameObject plr;

    Vector2 originalPos;

    public spawn resetspawn;

    public ScoreBoard scrB;
    

    // Start is called before the first frame update
    void Start()
    {
        ScoreB.SetActive(false);
        originalPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        Time.timeScale = 0f;
        MainUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {

        //MainUI.SetActive(false);
        Time.timeScale = 1f;
        Mainmenu = false;
        
        plr.transform.position = originalPos;

        Showscore.score = 0;
        spawn.dificulty = 1;

        resetspawn = FindObjectOfType<spawn>();
        resetspawn.rrTimers();
    }

    public void QuitGame()
    {
        scrB.SaveScores();
        Application.Quit();
    }

}
