using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPalce : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public Sprite newsprite;

    private void Start()
    {
        if (ItemStatic.HasWatered) spriterenderer.sprite = newsprite;
    }

    public void FullBucket()
    {
        if (ItemStatic.filledBucket)
        {
            ItemStatic.filledBucket = false;
            ItemStatic.HasWatered = true;

            spriterenderer.sprite = newsprite;
        }
    }
}
