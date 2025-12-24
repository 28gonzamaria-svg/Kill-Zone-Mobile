using UnityEngine;
using UnityEngine.UI;

public class SandboxUnlock : MonoBehaviour
{
    // Tareas del jugador
    public int totalKills = 0;
    public int spins360 = 0;
    public int headFootKills = 0;

    // Cantidades requeridas
    public int requiredKills = 100;
    public int requiredSpins = 1; // 1 giro 360 completo
    public int requiredHeadFootKills = 20;

    // HUD
    public Text hudText;

    // Estado desbloqueo
    private bool sandboxUnlocked = false;

    void Update()
    {
        if (!sandboxUnlocked)
        {
            CheckTasks();
        }
    }

    void CheckTasks()
    {
        if(totalKills >=