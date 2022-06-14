using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLogic : MonoBehaviour
{
    public GameObject firstUp;
    public GameObject secondUp;
    public GameObject secondDown;
    public GameObject thirdDown;

    public GameObject player;
    public Renderer rend;

    public Animator first;
    public Animator second;
    public Animator third;
    public Animator fourth;

    public Rigidbody2D rb;


    public void GoUpTo2()
    {
        Invoke("RecieveUpFromFirst", 1f);
        rend.enabled = false;
        first.Play("UpBack");
        
    }

    public void GoUpTo3()
    {
        Invoke("RecieveUpFromSecond", 1f);
        rend.enabled = false;
        third.Play("UpBack");
    }

    public void GoDownTo2()
    {
        Invoke("RecieveDownFromThird", 1f);
        rend.enabled = false;
        fourth.Play("DownBack");
    }

    public void GoDownTo1()
    {
        Invoke("RecieveDownFromSecond", 1f);
        rend.enabled = false;
        second.Play("DownBack");

        
    }
    private void RecieveDownFromSecond()
    {
        player.transform.position = firstUp.transform.position;
        first.Play("DownFront");
        Invoke("EnableSprite", 1f);
    }


    private void RecieveDownFromThird()
    {
        player.transform.position = secondUp.transform.position;
        third.Play("DownFront");
        Invoke("EnableSprite", 1f);

    }

    private void RecieveUpFromSecond()
    {
        player.transform.position = thirdDown.transform.position;
        fourth.Play("UpFront");
        Invoke("EnableSprite", 1f);

    }


    private void RecieveUpFromFirst()
    {
        player.transform.position = secondDown.transform.position;
        second.Play("UpFront");
        Invoke("EnableSprite", 1f);

    }


    private void EnableSprite()
    {
        rend.enabled = true;
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        PlayerMovement.notClimbing = false;


    }


    public void StopMove()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;

        PlayerMovement.notClimbing = true;

    }

}
