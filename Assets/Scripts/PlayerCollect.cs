using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreData; 

    public void UpdateScore(int value)
    {
        _scoreData.ScoreValue = Mathf.Clamp(_scoreData.ScoreValue+value,min:0,max:_scoreData.ScoreValue+value); 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
