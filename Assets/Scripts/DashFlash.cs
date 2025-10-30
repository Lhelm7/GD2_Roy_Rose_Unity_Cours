using UnityEngine;

public class DashFlash : MonoBehaviour
{
    public float boostDuration = 5f; 

    private void OnTriggerEnter(Collider other)
    {
        DashPlayer player = other.GetComponent<DashPlayer>(); 
        
        if (player != null)
        {
            player.ActivateBoost(boostDuration);
            Destroy(gameObject); 
        }
    }
}

