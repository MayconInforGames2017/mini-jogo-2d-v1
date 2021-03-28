using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    public Transform fishPrefab;

    public float spawnRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // A cada 2 segundos esse metodo é acionado
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

    private void Spawn()
    {
        var fishTransform = Instantiate(fishPrefab) as Transform;

        fishTransform.position = fishTransform.position;
    }

}
