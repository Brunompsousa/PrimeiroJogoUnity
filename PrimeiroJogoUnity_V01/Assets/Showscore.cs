using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Showscore : MonoBehaviour
{

    public Text myscore;
    public static int score; 

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myscore.text = score.ToString();

        float.TryParse(myscore.text, out float scr);

        float res =  Mathf.Round(scr / 100);

        if (res >= 3)
        {
            spawn.dificulty = (int)res;
        }

    }
}
