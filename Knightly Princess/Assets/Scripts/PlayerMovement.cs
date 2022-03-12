using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Slash;
    public Transform Slashpoint;
    private bool stopFighting;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 direction;

    private bool isShooting;
    private float shootDelay = .7f;


    public bool left;
    public bool right;
    public bool up;
    public bool down;

    private Vector2 dist;

    private void Start()
    {
        dist = new Vector2(0.8f, 0.8f);
    }



    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x < 0)
        {
            left = true;
            right = false;
            direction.x = -1;
            direction.y = 0;
        }
        if (movement.x > 0)
        {
            left = false;
            right = true;
            direction.x = 1;
            direction.y = 0;
        }
        if (movement.y > 0)
        {
            up = true;
            down = false;
            direction.y = 1;
            direction.x = 0;
        }
        if (movement.y < 0)
        {
            up = false;
            down = true;
            direction.y = -1;
            direction.x = 0;
        }
        if (!stopFighting)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (isShooting) return;

                isShooting = true;
                Invoke("ActuallyShoot", .1f);
                Invoke("ResetShoot", shootDelay);

            }
        }

        

    }

    private void FixedUpdate()
    {
        if (!isShooting)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }



    private void ResetShoot()
    {
        isShooting = false;

    }

    private void ActuallyShoot()
    {
        Slashpoint.transform.position = rb.position + dist * direction;
        GameObject b = Instantiate(Slash);
        b.transform.position = Slashpoint.transform.position;
        if (direction.y == -1 || direction.y == 1)
        {
            b.transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if (direction.x == -1 || direction.x == 1)
        {
            b.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        Destroy(b, 0.5f);

    }



    public void StopFighting()
    {
        stopFighting = true;
    }

    public void StartFighting()
    {
        stopFighting = false;
    }
}

