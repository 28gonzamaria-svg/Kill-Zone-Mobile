using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : MonoBehaviour
{
    public Text serverNameText;
    public Image loadingBar;

    public void SetServer(string serverName)
    {
        serverNameText.text = "Servidor: " + serverName;
    }

    public void SetProgress(float progress) // 0 a 1
    {
        loadingBar.fillAmount = progress;
    }
}