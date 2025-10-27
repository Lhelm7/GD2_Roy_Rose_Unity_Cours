using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;  
    [SerializeField] private GameObject gameOverUI; 
    [SerializeField] private ScoreDatas _scoreData;
    [SerializeField] private UIController _uiController;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
            other.transform.position = respawnPoint.position; 
            //gameOverUI.SetActive(true); 
            // Retire un point (énergie/collectible)
            _scoreData.ScoreValue = Mathf.Max(0, _scoreData.ScoreValue - 1);
            _uiController.UpdateScore(_scoreData.ScoreValue);

            // Fait réapparaître un collectible perdu
            if (CollectibleManager.Instance != null)
                CollectibleManager.Instance.RespawnOneCollectible();

            // Game Over si collectible énergie = 0
            if (_scoreData.ScoreValue <= 0)
            {
                if (gameOverUI != null)
                    gameOverUI.SetActive(true);
            }
        }
    }
}


