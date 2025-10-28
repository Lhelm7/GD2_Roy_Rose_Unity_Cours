using System;
using UnityEngine;
using UnityEngine.UI;

public class EndLevelDoor : MonoBehaviour
{
  [SerializeField] private ScoreDatas _scoreData;
  [SerializeField] private int _ScoreToOpen;
  [SerializeField] private GameObject _TextDoor;
  
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.GetComponent<PlayerCollect>() != null)
    {
      if (_scoreData != null && _scoreData.ScoreValue == _ScoreToOpen)
      {
        Destroy(gameObject);
      }
      else
      {
        if (_TextDoor != null)
          _TextDoor.SetActive(true);
      }
      
    }
  }

  private void OnTriggerExit(Collider other)
  {
    if (other.gameObject.GetComponent<PlayerCollect>() != null)
    {
        _TextDoor.SetActive(false);
    }
  }
}
