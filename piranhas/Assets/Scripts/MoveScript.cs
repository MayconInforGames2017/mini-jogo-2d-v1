﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Velocidade do inimigo
    public Vector2 speed = new Vector2 (5, 5);

    // Movimento do inimigo
    private Vector2 movement;

    public Vector2 direction = new Vector2 (-1, 0);

    // Inimigo vai tirar um de dano do personagem 
    public int damage = 1;

    // Identificar o barco
    //public string objectTag;

    void Start ()
    {
        // Apos se colidir com o barco o inimigo ira desaparecer
        Destroy(gameObject, 10); 
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Boat"))
        {
            Debug.Log("Colidiu!!!");
        }
       // if (collider.gameObject.tag == objectTag)
        //{
          //  HealthScript health = collider.gameObject.GetComponent<HealthScript>();

            //if (health != null)
            //{
              //  health.Damage(damage);
            //}

        //}
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentacao pela direita
        movement = new Vector2(
            direction.x * speed.x,
            direction.y * speed.y);
    }

    void FixedUpdate()
    {
        // Movimento do objeto
        GetComponent<Rigidbody2D>().velocity = movement;
    }

}
