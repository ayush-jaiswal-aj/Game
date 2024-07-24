using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab;
    public Transform player;

    private void Start()
    {
        InvokeRepeating("SpawnTarget", 1f, .6f);
    }


    void SpawnTarget()
    {
        float zRange = 15f + player.position.z;
        float xPos = Random.Range(-6.5f, 6.5f);
        float zPos = Random.Range(zRange, 20f + zRange);

        Vector3 randomtargetPos = new Vector3(xPos, 1.5f, zPos);

        Instantiate(targetPrefab, randomtargetPos, Quaternion.identity);
    }
}
