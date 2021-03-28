using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    // A velocidade do inimigo
    public Vector2 speed = new Vector2(5, 5);

    // Guarda o movimento do inimigo
    private Vector2 movement;

    private Vector2 direction = new Vector2(-1, 0);

    // Update is called once per frame
    void Update()
    {
        // Movimentacao pela direcao
        movement = new Vector2(
            direction.x * speed.x,
            direction.y * speed.y);
    }

    void FixedUpdate()
    {
        // Movimento do objeto
        rigidbody2D.velocity = movement;
    }
}
