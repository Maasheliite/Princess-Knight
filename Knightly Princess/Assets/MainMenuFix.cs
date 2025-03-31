using UnityEngine;
using UnityEngine.UI;

public class MainMenuFix : MonoBehaviour
{

    public Toggle toggleMobile;

    public void SyncMobileData()
    {
        toggleMobile.isOn = ItemStatic.mobile;
    }

    public void SetMobileMenu()
    {
        ItemStatic.mobile = toggleMobile.isOn;
    }
}
