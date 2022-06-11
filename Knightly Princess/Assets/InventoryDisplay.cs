using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public GameObject InventoryTab;
    public GameObject Berries;
    public GameObject FilledBucket;
    public GameObject EmptyBucket;
    public GameObject Shears;
    public GameObject Ring;
    public GameObject Helmet;
    public GameObject Sword;
    public GameObject MagicSword;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InventoryTab.SetActive(true);


            if (ItemStatic.berries)
            {
                Berries.SetActive(true);
            }

            if (ItemStatic.filledBucket)
            {
                FilledBucket.SetActive(true);
            }

            if (ItemStatic.emptyBucket)
            {
                EmptyBucket.SetActive(true);
            }

            if (ItemStatic.shears)
            {
                Shears.SetActive(true);
            }
            if (ItemStatic.ring)
            {
                Ring.SetActive(true);
            }
            if (ItemStatic.helmet)
            {
                Helmet.SetActive(true);
            }
            if (ItemStatic.sword && ItemStatic.magicSword == false)
            {
                Sword.SetActive(true);
            }
            if (ItemStatic.magicSword)
            {
                MagicSword.SetActive(true);
            }
        }



        if (Input.GetKeyUp(KeyCode.Space))
        {

            InventoryTab.SetActive(false);

            Berries.SetActive(false);
            FilledBucket.SetActive(false);
            EmptyBucket.SetActive(false);
            Shears.SetActive(false);
            Ring.SetActive(false);
            Helmet.SetActive(false);
            Sword.SetActive(false);
            MagicSword.SetActive(false);
        }
    }



}
