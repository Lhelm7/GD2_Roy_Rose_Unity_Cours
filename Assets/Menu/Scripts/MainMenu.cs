using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string _Level1Scene = "Dev_Map";
    [SerializeField] private AudioSource music;
    private static bool musicHasPlayed = false;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Play()
        {
            if (music != null && !musicHasPlayed)
            {
                music.Play();
                musicHasPlayed = true;
            }
            SceneManager.LoadScene(_Level1Scene);
        }
        public void Quit()
        {
            Application.Quit();
        }
    }


