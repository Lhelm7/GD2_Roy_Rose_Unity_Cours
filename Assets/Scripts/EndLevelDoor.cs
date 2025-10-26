using System;
using UnityEngine;

public class EndLevelDoor : MonoBehaviour
{
  [SerializeField] private ScoreDatas _scoreData;
  [SerializeField] private int _ScoreToOpen;
  
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.GetComponent<PlayerCollect>() != null)
    {
      if (_scoreData != null && _scoreData.ScoreValue == _ScoreToOpen)
      {
        Destroy(gameObject);
      }
    }
  }
}
