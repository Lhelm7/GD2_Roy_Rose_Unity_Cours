using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string _Level1Scene = "Dev_Map";
    [SerializeField] private AudioSource music;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Play()
        {
            if (music != null && !music.isPlaying)
                music.Play();
            SceneManager.LoadScene(_Level1Scene);
        }

        public void Quit()
        {
            Application.Quit();
        }
    }


