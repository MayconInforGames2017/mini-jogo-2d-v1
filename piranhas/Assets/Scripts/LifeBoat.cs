using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBoat : MonoBehaviour
{
    public int lifeMax;

    public int lifeAtual;

    // Start is called before the first frame update
    void Start()
    {
        lifeAtual = lifeMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReceberDano()
    {
        lifeAtual -= 1;

        if (lifeAtual <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
