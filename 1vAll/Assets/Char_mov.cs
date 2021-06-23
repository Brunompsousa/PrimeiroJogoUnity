using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_mov : MonoBehaviour
{
    public Rigidbody2D player;

    public Camera cam;

    public float speed = 20f; //velocidade a que sera feito o movimento

    Vector2 moveDir; //Posicao para onde queremos que a personagem se mova

    Vector2 mousePos;

    public gameovermenu goscreen;


    // Update is called once per frame
    private void Update()
    {
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");
      
        player.MovePosition(player.position + moveDir * speed * Time.fixedDeltaTime);

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 lookDir = mousePos - player.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        player.rotation = angle;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.collider.name);
        if (collision.collider.tag == "Enemy")
        {
            //Debug.Log("DIE");
            goscreen.Gameover();
        }
    }
}


