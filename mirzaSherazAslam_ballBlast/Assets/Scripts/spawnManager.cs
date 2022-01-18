using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject Prefab;
    private Vector3 spawnPos = new Vector3(0, 6, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("Spawnprefab", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle()
    {
        Instantiate(Prefab, spawnPos, Prefab.transform.rotation);
    }
}
