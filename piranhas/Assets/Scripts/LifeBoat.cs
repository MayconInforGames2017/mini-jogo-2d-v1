using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBoat : MonoBehaviour
{
    private int health;

    public int lifeMax;

    public int lifeAtual;

    // Barra verde
    public Transform healtBar;

    // Objeto pai das barras
    public Transform healtBarObject;

    // Tamanho da barra
    private Vector3 healthBarScale;

    // Percentual de vida, calcular barra
    private float healthPercent;

    // Start is called before the first frame update
    void Start()
    {
        lifeAtual = lifeMax;
        healthBarScale = healtBar.localScale;
        healthPercent = healthBarScale.x / health;
    }

    void UpdateHealthbar()
    {
        healthBarScale.x = healthPercent * health;
        healtBar.localScale = healthBarScale;
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
            UpdateHealthbar();
            //Destroy(gameObject, 10);
            Debug.Log("Game Over");
        }
    }
}
