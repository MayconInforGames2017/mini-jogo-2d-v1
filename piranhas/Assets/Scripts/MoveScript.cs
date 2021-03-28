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
    public string tag;

    void Start ()
    {
        // Apos se colidir no barco o inimigo ira desaparecer
        Destroy(gameObject, 10); 
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