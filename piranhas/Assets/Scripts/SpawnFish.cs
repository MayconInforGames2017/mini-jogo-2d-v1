using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    public Transform fishPrefab;

    public float spawnRate = 2f;

    private bool isPositionBoat = false;

    private Transform boatTransform;

    // Start is called before the first frame update
    void Start()
    {
        boatTransform = GameObject.FindGameObjectWithTag("Boat").transform;

        // A cada 2 segundos esse metodo é acionado
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

    private void Spawn()
    {
        isPositionBoat = !isPositionBoat;

        Vector3 fishPosition;

        if (isPositionBoat)
        {
            fishPosition = new Vector3(transform.position.x,
                                         boatTransform.position.y,
                                         transform.position.z);
        }

        else
        {
            fishPosition = new Vector3(transform.position.x,
                                        Random.Range(-4, -3),
                                        transform.position.z);
        }

        var fishTransform = Instantiate(fishPrefab) as Transform;

        fishTransform.position = fishPosition;
    }

}
