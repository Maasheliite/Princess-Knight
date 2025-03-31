using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileCode : MonoBehaviour
{
    private GameObject player;
    private PlayerMovement playerMovement;
    public Toggle toggleMobile;
    public GameObject buttonParent;
    public GameObject attack;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();

        if (ItemStatic.mobile)
        {
            buttonParent.SetActive(ItemStatic.mobile);
            if (ItemStatic.sword || ItemStatic.magicSword)
            {
                attack.SetActive(true);
            }
        }
    }

    public void Up()
    {
        playerMovement.movement.y = 1;
    }
    public void Down()
    {
        playerMovement.movement.y = -1;
    }
    public void Left()
    {
        playerMovement.movement.x = -1;
    }
    public void Right()
    {
        playerMovement.movement.x = 1;
    }


    public void Release()
    {
        playerMovement.movement.x = 0;
        playerMovement.movement.y = 0;
    }

    public void ChangeMobileValue()
    {
        ItemStatic.mobile = toggleMobile.isOn;
    }

    public void UpdateMobileUI()
    {
        buttonParent.SetActive(ItemStatic.mobile);
        if (ItemStatic.sword || ItemStatic.magicSword)
        {
            attack.SetActive(true);
        }
    }

    public void SyncMobileData()
    {
        toggleMobile.isOn = ItemStatic.mobile;
    }

    public void ChangeButtonStatus()
    {
        ItemStatic.buttonPressed = true;
    }

    public void AttackButton()
    {
        ItemStatic.attack = true;
    }

    public void HideUI()
    {
        attack.SetActive(false);
        buttonParent.SetActive(false);
    }

}