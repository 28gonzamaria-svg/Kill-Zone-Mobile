using UnityEngine;

public class AimController : MonoBehaviour
{
    public Camera playerCamera;
    public float aimFOV = 40f; // Campo de visión al apuntar
    private float normalFOV;
    private bool isAiming = false;

    void Start()
    {
        normalFOV = playerCamera.fieldOfView;
    }

    public void OnAimButtonDown() // Asignar al botón táctil
    {
        isAiming = true;
        playerCamera.fieldOfView = aimFOV;
    }

    public void OnAimButtonUp() // Asignar al soltar el botón
    {
        isAiming = false;
        playerCamera.fieldOfView = normalFOV;
    }
}