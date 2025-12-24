using UnityEngine;

public class WeaponSpin : MonoBehaviour
{
    public Animator weaponAnimator; // Animator del arma
    private bool isSpinning = false;

    void Update()
    {
        // Detecta si el jugador corre (ejemplo: tecla W o botón móvil)
        if(Input.GetKeyDown(KeyCode.W) && !isSpinning) // Reemplazar por botón móvil
        {
            StartCoroutine(SpinWeapon());
        }
    }

    System.Collections.IEnumerator SpinWeapon()
    {
        isSpinning = true;
        weaponAnimator.SetTrigger("Spin"); // Trigger en Animator
        yield return new WaitForSeconds(2f); // Duración del giro
        isSpinning = false;
    }
}