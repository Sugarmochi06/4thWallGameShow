using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Next scene");
        SceneManager.LoadScene("GameIntro");
    }

    public void OpenSettings()
    {
        Debug.Log("opened settings");
        SceneManager.LoadScene("SettingScreen");
    }

    public void QuitGame()
    {
        Debug.Log("game quited");

    }
}
