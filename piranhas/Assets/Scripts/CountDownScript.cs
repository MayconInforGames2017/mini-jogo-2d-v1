using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    public Text displayContagem;

    public float contagem = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contagem > 0)
        {
            contagem -= Time.deltaTime;
            displayContagem.text = contagem.ToString();
        }
        else
        {
            displayContagem.text = "Game Over!!";
        }
    }
}
