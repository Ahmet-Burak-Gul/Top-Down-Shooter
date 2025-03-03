using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enimyPrefab;

    private Vector3 _spawnPoint;
    [SerializeField] private Transform _target;
    [SerializeField] private float _interval;
    [SerializeField] private float _distance;

    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, _interval);
    }

    private void Spawn()
    {
        Vector3 randomPos = RandomPosition(_target);
        GameObject newEnimy = Instantiate(enimyPrefab, randomPos, Quaternion.identity);
    }

    private Vector3 RandomPosition(Transform target)
    {
        float angle = Random.Range(0f, 2f*Mathf.PI);

        float x = target.position.x + Mathf.Cos(angle) * _distance;
        float y = target.position.y + Mathf.Sin(angle) * _distance;

        return new Vector3(x, y, target.position.z);
    }
}

