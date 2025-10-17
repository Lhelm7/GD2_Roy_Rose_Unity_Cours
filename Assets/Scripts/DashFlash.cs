using UnityEngine;

public class DashFlash : MonoBehaviour
{

    public float boostDuration = 5f;
    [SerializeField] private int _targetValue = 1;

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

