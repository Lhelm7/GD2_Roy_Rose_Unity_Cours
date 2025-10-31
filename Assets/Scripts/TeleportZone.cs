using UnityEngine;

public class TeleportZone : MonoBehaviour
{
    [SerializeField] private Transform teleportTarget; 
[SerializeField] private AudioSource teleportSound;

private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.GetComponent<PlayerCollect>() != null)
    {
        other.transform.position = teleportTarget.position;

        if (teleportSound != null)
            teleportSound.Play();
    }
}
}
  
 




