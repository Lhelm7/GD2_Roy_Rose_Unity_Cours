using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private AudioSource _ClickSound;
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

