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

    private bool canFight;

    private Vector2 dist;

    private bool bigBattle;

    private void Start()
    {
        dist = new Vector2(1f, 1f);

        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }



    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x < 0)
        {
            direction.x = -1;
            direction.y = 0;
        }
        if (movement.x > 0)
        {
            direction.x = 1;
            direction.y = 0;
        }
        if (movement.y > 0)
        {
            direction.y = 1;
            direction.x = 0;
        }
        if (movement.y < 0)
        {
            direction.y = -1;
            direction.x = 0;
        }
        if (!stopFighting && canFight)
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
        if (!isShooting && (movement.x != 0 || movement.y != 0))
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            freeze();
        }
    }

    private void freeze()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
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

    public void CanFight()
    {
        canFight = true;
    }

    public void BigBattle()
    {
        bigBattle = true;
        Debug.Log("Can do big battle");
    }
}
