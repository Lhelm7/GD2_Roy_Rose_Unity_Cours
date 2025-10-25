using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;  
    [SerializeField] private GameObject gameOverUI;  
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
            other.transform.position = respawnPoint.position; 
            //gameOverUI.SetActive(true); 
        } 
    } 
  
    } 


