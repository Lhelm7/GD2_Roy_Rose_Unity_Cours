using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Victory : MonoBehaviour
{
    private string _MainMenu = "MainMenuScene";
    private string _Level2 = "Level2Scene";
    [SerializeField] private ScoreDatas _scoreData;
    [SerializeField] private GameObject _victoryUI;
    [SerializeField] private int _victoryScore;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null && _scoreData.ScoreValue == _victoryScore)
            {
                if (_victoryUI != null)
                _victoryUI.SetActive(true);
            }
}
    
    public void Menu()
    {
        SceneManager.LoadScene(_MainMenu);
    }

    public void Next()
    {
        SceneManager.LoadScene(_Level2);
    }
}


