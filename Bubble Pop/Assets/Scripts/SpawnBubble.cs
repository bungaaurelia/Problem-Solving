using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBubble : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 2, 1);
    }

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-6f, 6f);
        float y = Random.Range(-4f, 4f);

        return new Vector2(x, y);
    }

    void SpawnObj()
    {
        Instantiate(objectToSpawn, GetSpawnPoint(), Quaternion.identity);
    }
}
