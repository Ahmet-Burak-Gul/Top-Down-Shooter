using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    [SerializeField] private float Damage;
    [SerializeField] private float lifeTime;
    Vector3 Direction;
    private Vector2 target;
    [SerializeField] private float speed;
    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Direction = new Vector3(target.x, target.y, 0f) - transform.position;
        Direction.Normalize();
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.position += Direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyController>().DecreaseHealt(Damage);
            Destroy(gameObject);
        }
    }
}
