using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Victory : MonoBehaviour
{
    private string _MainMenu = "MainMenuScene";
    private string _Level2 = "MapLevel2";
    [SerializeField] private ScoreDatas _scoreData;
    [SerializeField] private GameObject _victoryUI;
    [SerializeField] private int _victoryScore;
    [SerializeField] private AudioSource _VictorySound;
    [SerializeField] private AudioSource _ClickSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null && _scoreData.ScoreValue == _victoryScore)
            {
                if (_VictorySound != null)
                    _VictorySound.Play();
                
                if (_victoryUI != null)
                _victoryUI.SetActive(true);
            }
}
    
    public void Menu()
    {
        if (_ClickSound != null)
            _ClickSound.Play();
        SceneManager.LoadScene(_MainMenu);
    }

    public void Next()
    {
        if (_ClickSound != null)
            _ClickSound.Play();
        if (_scoreData != null)
            _scoreData.ScoreValue = 0;
        SceneManager.LoadScene(_Level2);
    }
}


