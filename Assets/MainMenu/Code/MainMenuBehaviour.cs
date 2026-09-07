using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    public void StartGame()
        {
            Debug.Log("Game start");
            SceneManager.LoadScene("IntroCutscene");

        }
    public void OpenSettings()
    {
        Debug.Log("opened settings");
        SceneManager.LoadScene("SettingsMenu");

    }
    public void QuitGame()
    {
        Debug.Log("game quited");

    }

}
