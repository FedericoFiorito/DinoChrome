using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Spawner))]
public class SpawnerByTime : MonoBehaviour
{
    public float timeToSpawn;
    public float currentSeconds;


    void Start()
    {

        currentSeconds = timeToSpawn;
    }


    void Update()
    {

        currentSeconds -= Time.deltaTime;

        if (currentSeconds <= 0)
        {
            GetComponent<Spawner>().Spawn();
            currentSeconds = timeToSpawn;
        }
    }
}
