using UnityEngine;

public class DashFlash : MonoBehaviour
{
    public float boostDuration = 5f; // Le dash dure 5 secondes

    private void OnTriggerEnter(Collider other)
    {
        DashPlayer player = other.GetComponent<DashPlayer>();

        if (player != null)
        {
            player.ActivateBoost(boostDuration);
            Destroy(gameObject); // On détruit le collectible après l’avoir ramassé
        }
    }
}

