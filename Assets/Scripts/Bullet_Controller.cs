using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    [SerializeField] private float Damage;
    [SerializeField] private float lifeTime;

    private Vector2 target;
    [SerializeField] private float speed;
    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        Vector2 final = new Vector2(transform.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (final == target)
        {
            Destroy(gameObject);
        }
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
