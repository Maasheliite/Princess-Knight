using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornBushes : MonoBehaviour
{
    public void HasShears()
    {
        if (ItemStatic.shears)
        {
            ItemStatic.hasCut = true;
            Destroy(gameObject);
        }
    }
}
