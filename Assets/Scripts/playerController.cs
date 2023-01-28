using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{

    private Rigidbody rb;
    public healthScript healthbar;
    public TimerScript timer;


    public float speed = 10;


    // health values
    public int maxHealth = 100;
    private int health = 1;


    // coords
    private float moveX;
    private float moveY;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        health = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        
    }

    void OnMove(InputValue movement)
    {
        Vector2 movementVector = movement.Get<Vector2>();
        moveX = movementVector.x;
        moveY = movementVector.y;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hurtWall")
        {
            if(health <= 11)
            {
                health = 0;
                rb.constraints = RigidbodyConstraints.FreezePosition;
            }

            health = health - 10;
            healthbar.SetHealth(health);
        }
        else if (collision.gameObject.tag == "End")
        {
            timer.StopTimer();
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveX, 0, moveY);
        rb.AddForce(movement * speed);
    }
}
