using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{


    private void update()
    {
    
        foreach (Touch toque in Input.touches)
        {
            Debug.Log("ID: " + toque.fingerId);
        }

    }
}
