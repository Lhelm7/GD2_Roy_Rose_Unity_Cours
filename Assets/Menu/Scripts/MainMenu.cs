using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string _Level1Scene = "Dev_Map";
    
    public void Play()
    {
        SceneManager.LoadScene(_Level1Scene);
    }

    public void Quit()
        {
            Debug.Log("Quit"); 
            Application.Quit();
    }
}

