using System;
using UnityEngine;

public class TargetHard : MonoBehaviour
{
    [SerializeField] private int _targetValue = 1;
    private CollectibleRespawn _respawn; 
    [SerializeField] private AudioClip _audioSource;
    private void Awake()
    {
        _respawn = GetComponent<CollectibleRespawn>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
            other.gameObject.GetComponent<PlayerCollect>().UpdateScore(_targetValue);
            
            if (_audioSource != null)
                AudioSource.PlayClipAtPoint(_audioSource, transform.position);
            
            if (_respawn != null)
            {
                _respawn.Collect();
            }
            else
            
            {
                Destroy(gameObject);
            }
        }
    }
}