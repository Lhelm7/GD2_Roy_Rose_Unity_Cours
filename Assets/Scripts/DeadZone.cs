using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;  
    [SerializeField] private GameObject gameOverUI;  
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
            gameOverUI.SetActive(true); 
        } 
    } 
    public void Retry(GameObject player) 

    { 

        player.transform.position = respawnPoint.position; 
        player.transform.rotation = respawnPoint.rotation; 
        player.SetActive(true); 
        gameOverUI.SetActive(false); 

    } 
} 

