using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Velocidade do inimigo
    public Vector2 speed = new Vector2 (5, 5);

    // Movimento do inimigo
    private Vector2 movement;

    private Vector2 direction = new Vector2 (-1, 0);

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
