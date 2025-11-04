using UnityEngine;

public class RespawnCollectibleDash : MonoBehaviour
{
    [SerializeField] private GameObject collectiblePrefab;
    [SerializeField] private float respawnDelay = 3f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
            Invoke(nameof(SpawnCollectible), respawnDelay); 
        }
    }

    void SpawnCollectible()
    {
        Instantiate(collectiblePrefab, transform.position, transform.rotation);
    }
}