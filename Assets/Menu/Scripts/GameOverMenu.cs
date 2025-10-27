using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private string _MainMenu = "MainMenuScene";
    
    public void Retry()
    {
        SceneManager.LoadScene(_MainMenu);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

