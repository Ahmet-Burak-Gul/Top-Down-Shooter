using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enimyPrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float interval;


    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, interval);
    }

    private void Spawn()
    {
        int randomPos = Random.Range(0, spawnPoints.Length);
        GameObject newEnimy = Instantiate(enimyPrefab, spawnPoints[randomPos].position, Quaternion.identity);
    }

}
