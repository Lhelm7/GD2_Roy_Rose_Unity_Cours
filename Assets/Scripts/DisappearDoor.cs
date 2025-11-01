using System;
using UnityEngine;

public class DisappearDoor : MonoBehaviour
{
    [SerializeField] private AudioClip _OpenDoor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
            if (_OpenDoor != null)
                AudioSource.PlayClipAtPoint(_OpenDoor, transform.position);
        {
         Destroy(gameObject);    
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
