using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifySimpleSpawner : MonoBehaviour
{
    public int spawnCount = 0;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        while (spawnCount <= 20)
        {
            Instantiate(prefab, new Vector3(Random.Range(-5, 5), Random.Range(-
           5, 5), 0), Quaternion.identity);
            spawnCount++;
        }
    }

}
