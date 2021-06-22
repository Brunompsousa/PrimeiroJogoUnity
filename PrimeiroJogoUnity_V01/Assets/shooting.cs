using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    
    public Transform firePoint;

    public GameObject bulletpre;

    public float bulletForce = 30f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Criaçao do tiro, dando tb a posicao e rotacao do firepoint que criamos.
        GameObject bullet =  Instantiate(bulletpre, firePoint.position, firePoint.rotation);
        //Da-se um rigidbody2d ao tiro
        Rigidbody2D realB = bullet.GetComponent<Rigidbody2D>();
        //adicionamos uma força a bala para que esta viage
        realB.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
 
    }

}
