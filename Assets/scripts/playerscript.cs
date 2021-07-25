using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float speed = 8f;
    private float maxX = 2.6f;
    private float minX = -2.6f;

    void Update()
    {
        movePlayer();
    }

    private void movePlayer()
    {
       float h = Input.GetAxis("Horizontal");
        Vector2 currentpostion = transform.position;

        if(h> 0)
        {
            currentpostion.x += speed * Time.deltaTime;
        }else if(h< 0)
        {
            currentpostion.x -= speed * Time.deltaTime;
        }
        if (currentpostion.x > maxX)
        {
            currentpostion.x = maxX;
        }else if (currentpostion.x < minX)
        {
            currentpostion.x = minX;
        }
           transform.position      = currentpostion;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if( target.tag == "Bomb")
        {
            Time.timeScale = 0f;
        }
    }
}
