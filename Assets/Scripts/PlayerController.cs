using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody2D rg;

    public Animator animator;

    [Header("GamePlay")]

    [SerializeField]private float speed;
    private Vector2 movement;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        rg.linearVelocity = new Vector2 (
            movement.x * speed,
            movement.y * speed);
        runAnim();
    }

    private void runAnim()
    {
        if (movement.x !=0 || movement.y !=0)
        {
            animator.SetBool("isRuning",true);
        }
        else
        {
            animator.SetBool("isRuning", false);
        }
    }
}
