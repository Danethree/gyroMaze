using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
     SpriteRenderer playerSprite;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
      
    }

    void MovePlayer()
    {
       rb.velocity = new Vector3(Input.acceleration.x*speed,Input.acceleration.y*speed);
      
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerSprite.enabled = false;
          Invoke("RestartScene",1f);
        }
    }
    public void RestartScene()
    {
        GameManager._gameManager.ReloadScene();
    }

}

