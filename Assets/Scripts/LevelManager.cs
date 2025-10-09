using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadANewLevel("MapLevel2");
            
        }
    }

    public void LoadANewLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
}
