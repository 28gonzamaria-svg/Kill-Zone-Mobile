using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public GameObject primaryWeapon;
    public GameObject secondaryWeapon;

    public Image slot1Icon;
    public Image slot2Icon;

    private bool usingPrimary = true;

    void Update()
    {
        // Cambiar armas (por ejemplo, botón en pantalla)
        if(Input.GetKeyDown(KeyCode.Tab)) // En móvil se usaría botón UI
        {
            SwitchWeapon();
        }
    }

    void SwitchWeapon()
    {
        usingPrimary = !usingPrimary;
        primaryWeapon.SetActive(usingPrimary);
        secondaryWeapon.SetActive(!usingPrimary);
    }
}