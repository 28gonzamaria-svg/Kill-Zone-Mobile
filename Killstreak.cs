using UnityEngine;

public class killstreak : MonoBehaviour
{
    public int kills = 0;                // Contador de kills
    public int killstreakThreshold = 5;  // Cantidad de kills para activar efecto
    public GameObject killstreakEffect;  // Prefab de efecto especial

    void Start()
    {
        kills = 0;
    }

    // Llamar esta función cuando matas a un enemigo
    public void AddKill()
    {
        kills++;
        Debug.Log("Kills: " + kills);

        if (kills == killstreakThreshold)
        {
            ActivateKillstreak();
        }
    }

    void ActivateKillstreak()
    {
        Debug.Log("¡Killstreak activado!");
        if (killstreakEffect != null)
        {
            Instantiate(killstreakEffect, transform.position, Quaternion.identity);
        }
        // Aquí puedes añadir más efectos: fuego, explosiones, HUD, etc.
    }

    // Para reiniciar kills (al morir, por ejemplo)
    public void ResetKills()
    {
        kills = 0;
    }
}
if (kills == 10)
{
    ActivateInfernalMode();
}

void ActivateInfernalMode()
{
    Debug.Log("🔥 PODER ACTIVADO 🔥");
    // aquí luego:
    // cambiar arma
    // música
    // pantalla roja
}