using System;
using UnityEngine;

public class TargetHard : MonoBehaviour
{
    [SerializeField] private int _targetValue = 1; 
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
            other.gameObject.GetComponent<PlayerCollect>().UpdateScore(_targetValue);
            Destroy(gameObject);
        }
    }
} 