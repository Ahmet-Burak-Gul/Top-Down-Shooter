using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform playerPos;

    [SerializeField] private float speed;
    [SerializeField] private float healt;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed *  Time.deltaTime);
    }

    public void DecreaseHealt(float damege)
    {
        if (healt-damege > 0){
            healt -= damege;
        }
        else{
            Destroy(gameObject);
        }
    }
}
